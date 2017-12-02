using EasyLicense.Lib.License;
using EasyLicense.Lib.License.Validator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace Bindding.ExcuteClasses
{
    internal static class LicenseHelper
    {
        private static string _path_pub = Environment.CurrentDirectory + "\\publicKey";
        private static string _path_pri = Environment.CurrentDirectory + "\\privateKey";
        private static string _path_license = Environment.CurrentDirectory + "\\license.lic";

        #region 生成序列号

        /// <summary>
        /// 生成封装的 key
        /// </summary>
        /// <returns></returns>
        internal static string GetOnwerPrivateKey()
        {
            if (File.Exists(_path_pub) && File.Exists(_path_pri))
            {
                return File.ReadAllText(_path_pri);
            }

            string _xmlStr = "<Root><Params><id></id><name></name><expirationDate></expirationDate><dictionary></dictionary></Params><PrivateKey></PrivateKey></Root>";
            XmlDocument _xmlDoc = new XmlDocument();
            _xmlDoc.LoadXml(_xmlStr);
            _xmlDoc.SelectSingleNode("/Root/PrivateKey").InnerXml = GenerateLicenseKey();
            _xmlDoc.SelectSingleNode("/Root/Params/id").InnerText = Guid.NewGuid().ToString();
            _xmlDoc.SelectSingleNode("/Root/Params/name").InnerText = "百叶竞价点击用户";
            _xmlDoc.SelectSingleNode("/Root/Params/expirationDate").InnerText = DateTime.Now.ToString();
            _xmlDoc.SelectSingleNode("/Root/Params/dictionary").InnerText = getMachineKey();

            File.WriteAllText(_path_pri, _xmlDoc.OuterXml);
            return _xmlDoc.OuterXml;
        }

        /// <summary>
        /// 生成key
        /// </summary>
        /// <returns>返回 privatekey</returns>
        private static string GenerateLicenseKey()
        {
            string publicKey = string.Empty;
            string privateKey = string.Empty;

            LicenseGenerator.GenerateLicenseKey(out privateKey, out publicKey);
            File.WriteAllText(_path_pub, publicKey);

            return privateKey;
        }

        /// <summary>
        /// 获取机器码（用md5 ）
        /// </summary>
        /// <returns></returns>
        internal static string getMachineKey()
        {
            string _key = getCpuId() + getMainBoard() + "写代码很烦人啊" + getDiskID();
            byte[] encodedPassword = new UTF8Encoding().GetBytes(_key);
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
            string encoded = BitConverter.ToString(hash).Replace("-", string.Empty).ToUpper();

            return encoded;
        }

        #region 获取本机的信息

        /// <summary>
        /// 获得CPU的序列号
        /// </summary>
        /// <returns></returns>
        private static string getCpuId()
        {
            var mbs = new ManagementObjectSearcher("Select ProcessorID From Win32_processor");
            var mbsList = mbs.Get();
            string strCpuID = string.Empty;
            foreach (ManagementObject mo in mbsList)
            {
                strCpuID = mo["ProcessorID"].ToString();
            }

            return strCpuID;
        }

        /// <summary>
        /// 获取硬盘ID
        /// </summary>
        /// <returns></returns>
        private static string getDiskID()
        {
            string HDid = string.Empty;
            var dk = new ManagementObjectSearcher("Select Model From Win32_DiskDrive");
            var mbsList = dk.Get();
            foreach (ManagementObject mo in mbsList)
            {
                HDid += (string)mo.Properties["Model"].Value;
            }

            return HDid;
        }

        /// <summary>
        /// 获取主板信息
        /// </summary>
        /// <returns></returns>
        private static string getMainBoard()
        {
            var mos = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BaseBoard");
            var moc = mos.Get();
            string serial = string.Empty;
            foreach (ManagementObject mo in moc)
            {
                serial = (string)mo["SerialNumber"];
            }

            return serial;
        }

        #endregion 获取本机的信息

        #endregion 生成序列号

        /// <summary>
        /// 验证并且返回验证信息
        /// </summary>
        /// <returns>不成功返回空</returns>
        internal static LicenseValidator ValidationGetInfo()
        {
            if (!File.Exists(_path_license) || !File.Exists(_path_pub))
            {
                return null; // 如果文件不全，则不验证
            }

            string publicKey = File.ReadAllText(_path_pub);
            try
            {
                var licenseValidator = new LicenseValidator(publicKey, _path_license);
                licenseValidator.AssertValidLicense();

                return licenseValidator;
            }
            catch
            {
            }

            return null;
        }

        /// <summary>
        /// 注册，后的操作
        /// </summary>
        /// <param name="_is_success">注册是否成功</param>
        internal static void RegsterIsSuccess(bool _is_success)
        {
            if (_is_success)
            {
                // 注册成功 删除private
                File.Delete(_path_pri);
            }
            else
            {
                // 注册失败，删除 license
                File.Delete(_path_license);
            }
        }

        /// <summary>
        /// 获取网络时间
        /// </summary>
        /// <returns></returns>
        internal static DateTime getWebsiteDatetime()
        {
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create("https://www.baidu.com");
            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            return Convert.ToDateTime(myResponse.Headers["date"]);
        }
    }
}