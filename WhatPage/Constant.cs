using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatPage
{
    class Constant
    {
      
        public class Folders
        {
            public const String IPS_FOLDER_NAME = "ips";
            public const String BAT_FOLDER_NAME = "bats";
            public const String TEMP_FOLDER_NAME = "temp";
        }

        public class Apktool
        {
           
            public const String VPN_C_BAT_NAME = "vpn_c.bat";
            public const String VPN_D_BAT_NAME = "vpn_d.bat";
            public const String BROWER_BAT_NAME = "brower.bat";

        }

        public class ProcessType
        {
            public const int TYPE_OF_PROCESS_START_UNKNOWN = 0x0000;
            public const int TYPE_OF_PROCESS_CONNECT_VPN = 0x0011;
            public const int TYPE_OF_PROCESS_DISCONNECT_VPN = 0x0012;

            public const int TYPE_OF_PROCESS_LAUNCH_BROWER = 0x0013;

        }
    }
}
