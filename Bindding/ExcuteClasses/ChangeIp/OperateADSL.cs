using DotRas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace Bindding.ExcuteClasses
{
    public class OperateADSL
    {
        /// <summary>
        /// 创建或更新一个PPPOE连接(指定PPPOE名称)
        /// </summary>
        public void CreateOrUpdatePPPOE(string updatePPPOEname)
        {
            RasDialer dialer = new RasDialer();
            RasPhoneBook allUsersPhoneBook = new RasPhoneBook();
            string path = RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.AllUsers);
            allUsersPhoneBook.Open(path);

            if (allUsersPhoneBook.Entries.Contains(updatePPPOEname))
            {
                allUsersPhoneBook.Entries[updatePPPOEname].PhoneNumber = " ";
                // 不管当前PPPOE是否连接，服务器地址的更新总能成功，如果正在连接，则需要PPPOE重启后才能起作用
                allUsersPhoneBook.Entries[updatePPPOEname].Update();
            }
            else
            {
                string adds = string.Empty;
                ReadOnlyCollection<RasDevice> readOnlyCollection = RasDevice.GetDevices();
                // Find the device that will be used to dial the connection.
                RasDevice device = RasDevice.GetDevices().Where(o => o.DeviceType == RasDeviceType.PPPoE).First();
                RasEntry entry = RasEntry.CreateBroadbandEntry(updatePPPOEname, device);    //建立宽带连接Entry
                entry.PhoneNumber = " ";
                allUsersPhoneBook.Entries.Add(entry);
            }
        }

        /// <summary>
        /// ADSL链接
        /// </summary>
        /// <param name="strConnName">连接名称</param>
        public bool Connect()
        {
            try
            {
                // CreateOrUpdatePPPOE(strConnName);
                RasDialer dialer = new RasDialer();
                dialer.EntryName = ConstParameter.EntryName;
                dialer.PhoneNumber = " ";
                dialer.AllowUseStoredCredentials = true;
                dialer.PhoneBookPath = RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.AllUsers);
                dialer.Credentials = new NetworkCredential(
                    CommonParameter.ConfigParam.adsl_info.username,
                    CommonParameter.ConfigParam.adsl_info.password);
                dialer.Timeout = 1000;
                RasHandle myras = dialer.Dial();
                if (!myras.IsInvalid)
                {
                    CommonFunction.WriteLogInFile("RasDialer Success! ", LogType.RunLog);
                    return true;
                }
            }
            catch (Exception ex)
            {
                CommonFunction.WriteLogInFile("RasDialer error!  error is :" + ex.ToString(), LogType.RunLog);
            }

            return false;
        }

        public bool DisConnenct()
        {
            try
            {
                ReadOnlyCollection<RasConnection> conList = RasConnection.GetActiveConnections();
                foreach (RasConnection con in conList)
                {
                    if (con.EntryName == ConstParameter.EntryName
                        && con.GetConnectionStatus().ConnectionState == RasConnectionState.Connected)
                    {
                        string ipAddresses = this.GetIPAddress();
                        con.HangUp();
                        CommonFunction.WriteLogInFile("RasDialer HangUp!IP:" + ipAddresses, LogType.RunLog);
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                CommonFunction.WriteLogInFile("RasDialer HangUp error!  error is :" + ex.ToString(), LogType.RunLog);
            }

            return false;
        }

        public void ReConnect()
        {
            DisConnenct();
            Thread.Sleep(CommonParameter.ConfigParam.sleep_seconds.recon_time.ToRandom());
            Connect();
        }

        /// <summary>
        /// 获取当前的ADSL ip
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <param name="oldConn"></param>
        private string GetIPAddress()
        {
            string ipAddress = string.Empty;
            var conns = RasConnection.GetActiveConnections();
            foreach (var conn in conns)
            {
                if (conn.Device.DeviceType == RasDeviceType.PPPoE)
                {
                    RasIPInfo ipAddresses = (RasIPInfo)conn.GetProjectionInfo(RasProjectionType.IP);
                    ipAddress = ipAddresses.IPAddress.ToString();
                    return ipAddress;
                }
            }

            return string.Empty;
        }
    }
}