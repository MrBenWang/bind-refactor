//-----------------------------------------------------------------------------
// Description: Sets resolution of a specified display through the call of
//              ScreenResolution.ChangeResolution().
//
// Author: Timothy Mui (https://github.com/timmui)
//
// Date: Jan. 7, 2015
//
// Acknowledgements: Many thanks to Andy Schneider for providing the original code
//                   for a single monitor.
//                   TechNet (https://gallery.technet.microsoft.com/ScriptCenter/2a631d72-206d-4036-a3f2-2e150f297515/)
//-----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Bindding.ExcuteClasses
{
    [Flags()]
    public enum DisplayDeviceStateFlags : int
    {
        /// <summary>The device is part of the desktop.</summary>
        AttachedToDesktop = 0x1,

        MultiDriver = 0x2,

        /// <summary>The device is part of the desktop.</summary>
        PrimaryDevice = 0x4,

        /// <summary>Represents a pseudo device used to mirror application drawing for remoting or other purposes.</summary>
        MirroringDriver = 0x8,

        /// <summary>The device is VGA compatible.</summary>
        VGACompatible = 0x10,

        /// <summary>The device is removable; it cannot be the primary display.</summary>
        Removable = 0x20,

        /// <summary>The device has more display modes than its output devices support.</summary>
        ModesPruned = 0x8000000,

        Remote = 0x4000000,
        Disconnect = 0x2000000
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DISPLAY_DEVICE
    {
        [MarshalAs(UnmanagedType.U4)]
        public int cb;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceString;

        [MarshalAs(UnmanagedType.U4)]
        public DisplayDeviceStateFlags StateFlags;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceID;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceKey;
    }

    [Flags()]
    public enum ChangeDisplaySettingsFlags : uint
    {
        CDS_NONE = 0,
        CDS_UPDATEREGISTRY = 0x00000001,
        CDS_TEST = 0x00000002,
        CDS_FULLSCREEN = 0x00000004,
        CDS_GLOBAL = 0x00000008,
        CDS_SET_PRIMARY = 0x00000010,
        CDS_VIDEOPARAMETERS = 0x00000020,
        CDS_ENABLE_UNSAFE_MODES = 0x00000100,
        CDS_DISABLE_UNSAFE_MODES = 0x00000200,
        CDS_RESET = 0x40000000,
        CDS_RESET_EX = 0x20000000,
        CDS_NORESET = 0x10000000
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DEVMODE
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmDeviceName;

        public short dmSpecVersion;
        public short dmDriverVersion;
        public short dmSize;
        public short dmDriverExtra;
        public int dmFields;

        public short dmOrientation;
        public short dmPaperSize;
        public short dmPaperLength;
        public short dmPaperWidth;

        public short dmScale;
        public short dmCopies;
        public short dmDefaultSource;
        public short dmPrintQuality;
        public short dmColor;
        public short dmDuplex;
        public short dmYResolution;
        public short dmTTOption;
        public short dmCollate;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmFormName;

        public short dmLogPixels;
        public short dmBitsPerPel;
        public int dmPelsWidth;
        public int dmPelsHeight;
        public int dmPosition;

        public int dmDisplayFlags;
        public int dmDisplayFrequency;

        public int dmICMMethod;
        public int dmICMIntent;
        public int dmMediaType;
        public int dmDitherType;
        public int dmReserved1;
        public int dmReserved2;

        public int dmPanningWidth;
        public int dmPanningHeight;
    };

    [Flags()]
    public enum DISP_CHANGE : int
    {
        SUCCESSFUL = 0,
        RESTART = 1,
        FAILED = -1,
        BADMODE = -2,
        NOTUPDATED = -3,
        BADFLAGS = -4,
        BADPARAM = -5,
        BADDUALVIEW = -6
    }

    public class User_32
    {
        [DllImport("user32.dll")]
        public static extern bool EnumDisplayDevices(string lpDevice, uint iDevNum, ref DISPLAY_DEVICE lpDisplayDevice, uint dwFlags);

        [DllImport("user32.dll")]
        public static extern int EnumDisplaySettingsEx(string lpszDeviceName, int iModeNum, ref DEVMODE lpDevMode, uint dwFlags);

        [DllImport("user32.dll")]
        public static extern int ChangeDisplaySettingsEx(string lpszDeviceName, ref DEVMODE lpDevMode, IntPtr hwnd, ChangeDisplaySettingsFlags dwflags, IntPtr lParam);

        public const int ENUM_CURRENT_SETTINGS = -1;
    }

    public class ScreenResolution
    {
        // Arguments
        // int width : Desired Width in pixels
        // int height : Desired Height in pixels
        // int deviceIDIn : DeviceID of the monitor to be changed. DeviceID starts with 0 representing your first
        //                  monitor. For Laptops, the built-in display is usually 0.

        static public string ChangeResolution(int width, int height, int deviceIDIn)
        {
            var d = GetDeviceByNo(deviceIDIn);
            DEVMODE dm = GetDevMode();

            //Attempt to change settings
            if (0 != User_32.EnumDisplaySettingsEx(d.DeviceName, User_32.ENUM_CURRENT_SETTINGS, ref dm, 0))
            {
                dm.dmPelsWidth = width;
                dm.dmPelsHeight = height;

                int iRet = User_32.ChangeDisplaySettingsEx(d.DeviceName, ref dm, IntPtr.Zero, ChangeDisplaySettingsFlags.CDS_TEST, IntPtr.Zero);

                if (iRet == (int)DISP_CHANGE.FAILED)
                {
                    return "Unable To Process Your Request. Sorry For This Inconvenience.";
                }
                else
                {
                    iRet = User_32.ChangeDisplaySettingsEx(d.DeviceName, ref dm, IntPtr.Zero, ChangeDisplaySettingsFlags.CDS_UPDATEREGISTRY, IntPtr.Zero);

                    switch (iRet)
                    {
                        case (int)DISP_CHANGE.SUCCESSFUL:
                            {
                                return "Success";
                            }
                        case (int)DISP_CHANGE.RESTART:
                            {
                                return "You Need To Reboot For The Change To Happen.\n If You Feel Any Problem After Rebooting Your Machine\nThen Try To Change Resolution In Safe Mode.";
                            }
                        default:
                            {
                                return "Failed To Change The Resolution.";
                            }
                    }
                }
            }
            else
            {
                return "Failed To Change The Resolution.";
            }
        }

        private static DEVMODE GetDevMode()
        {
            DEVMODE dm = new DEVMODE();
            dm.dmDeviceName = new String(new char[32]);
            dm.dmFormName = new String(new char[32]);
            dm.dmSize = (short)Marshal.SizeOf(dm);
            return dm;
        }

        public static DISPLAY_DEVICE GetDeviceByNo(int deviceIDIn)
        {
            //Basic Error Check
            uint deviceID = 0;
            if (deviceIDIn < 0)
            {
                deviceID = 0;
            }
            else
            {
                deviceID = (uint)deviceIDIn;
            }

            DISPLAY_DEVICE d = new DISPLAY_DEVICE();
            d.cb = Marshal.SizeOf(d);

            User_32.EnumDisplayDevices(null, deviceID, ref d, 1); //Get Device Information

            // Print Device Information
            Console.WriteLine("DeviceName: {0} \nDeviceString: {1}\nDeviceID: {2}\nDeviceKey {3}\nStateFlags {4}\n", d.DeviceName, d.DeviceString, d.DeviceID, d.DeviceKey, d.StateFlags);
            return d;
        }

        /// <summary>
        /// ��ȡ֧�ֵķֱ����б�
        /// </summary>
        /// <returns></returns>
        public static IList<ScreenSize> GetSupportedScreenResolutions(int deviceIDIn)
        {
            // get current screen info
            var d = GetDeviceByNo(deviceIDIn);
            var dm = GetDevMode();
            if (0 == User_32.EnumDisplaySettingsEx(d.DeviceName, User_32.ENUM_CURRENT_SETTINGS, ref dm, 0))
            {
                throw new Exception("Can't get current screen info!");
            }

            var devmode = GetDevMode();
            int i = 0;
            var retList = new List<ScreenSize>();
            while (User_32.EnumDisplaySettingsEx(null, i, ref devmode, 0) == 1)
            {
                if (dm.dmBitsPerPel == devmode.dmBitsPerPel
                    && dm.dmDefaultSource == devmode.dmDefaultSource
                    && dm.dmDisplayFlags == devmode.dmDisplayFlags
                    && devmode.dmPelsHeight > 760)
                {
                    retList.Insert(0, new ScreenSize
                    {
                        Width = devmode.dmPelsWidth,
                        Height = devmode.dmPelsHeight
                    });
                }
                i++;
            }

            return retList;
        }
    }

    public class ScreenSize
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public string ShowText
        {
            get
            {
                return Width.ToString() + " X " + Height.ToString();
            }
        }
    }
}