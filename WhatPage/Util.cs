using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Net;
using System.IO;



namespace WhatPage
{
    class Util
    {
        public static MyThread myThread = null;

        //检查时间是否开刷
        public static int checkTime(List<int> hourList, List<int> minList)
        {

            if (hourList != null && hourList.Count > 0 && minList != null && minList.Count > 0)
            {
                //每次刷一个小时  半个小时的时会替换一次包
                int hour = DateTime.Now.Hour;
                int min = DateTime.Now.Minute;
                foreach (int h in hourList)
                {
                    if (h == hour)
                    {
                        foreach (int m in minList)
                        {
                            if (m == min)
                            {
                                if (minList.Count > 1)
                                {
                                    return min;
                                }
                                else
                                {
                                    return hour;
                                }
                            }
                        }

                    }
                }
            }

            return -1;
        }

        //启动浏览器并且全屏
        public static void callLaunchBrower(String batPath,String exePath, String url, OnProcessListener onProcessListener)
        {
            if (onProcessListener == null)
            {
                return;
            }

            try
            {
                myThread = new MyThread(ThreadUtil.getBatOrExeStartInfo(batPath, new String[] { exePath, url }), onProcessListener, Constant.ProcessType.TYPE_OF_PROCESS_LAUNCH_BROWER);
                myThread.start();
            }
            catch (Exception e)
            {
            }
        }


        //连接vpn
        public static void callConnectVpn(String batPath, String vpnName, String userName, String userPassword, OnProcessListener onProcessListener)
        {
            if (onProcessListener == null)
            {
                return;
            }

            try
            {
                myThread = new MyThread(ThreadUtil.getBatOrExeStartInfo(batPath, new String[] { vpnName, userName, userPassword }), onProcessListener, Constant.ProcessType.TYPE_OF_PROCESS_CONNECT_VPN);
                myThread.start();
            }
            catch (Exception e)
            {
            }
        }

     

        //断开vpn
        public static void callDisconnectVpn(String batPath, String vpnName, OnProcessListener onProcessListener)
        {
            if (onProcessListener == null)
            {
                return;
            }

            try
            {
                myThread = new MyThread(ThreadUtil.getBatOrExeStartInfo(batPath, new String[] { vpnName }), onProcessListener, Constant.ProcessType.TYPE_OF_PROCESS_DISCONNECT_VPN);
                myThread.start();
            }
            catch (Exception e)
            {
            }
        }

     

        //获取ip
        public static Dictionary<string, string> getIpInfo()
        {
            string url = "http://www.ip.cn/";
            Dictionary<string, string> dic = null;
            try
            {
                dic = new Dictionary<string, string>();
                WebRequest wr = WebRequest.Create(url);
                Stream s = wr.GetResponse().GetResponseStream();
                StreamReader sr = new StreamReader(s, Encoding.UTF8);
                string all = sr.ReadToEnd(); //读取网站的数据
                sr.Close();
                s.Close();
                int isp = all.IndexOf("<code>") + 6;
                int iep = all.IndexOf("</code>");
                string _ip = all.Substring(isp, iep - isp);
                dic.Add("ip", _ip.Trim());
                int lsp = all.IndexOf("来自：") + 3;
                int lep = all.IndexOf("</p><p>GeoIP:");
                string _location = all.Substring(lsp, lep - lsp);
                dic.Add("location", _location);
            }
            catch (Exception e)
            {


            }
            return dic;
        }


        public const int PROCESS_NO_START = 0x0000;
        public const int PROCESS_RUNNING = 0x0001;
        public const int PROCESS_DEAD = 0x0002;
        // 判断当前进程的状态
        public static int getProcessStaus(String name)
        {
            Process[] temp = Process.GetProcessesByName(name);
            if (temp != null && temp.Length > 0)
            {
                foreach (Process p in temp)
                {
                    if (!p.Responding)
                    {
                        return PROCESS_DEAD;
                    }
                }
                return PROCESS_RUNNING;
            }
            else
            {
                return PROCESS_NO_START;
            }
        }

        //启动一个应用程序
        public static void launchProcess(string name)
        {
            try
            {
                Process.Start(name);
            }
            catch (Exception e)
            {
            }
        }

        //关闭一个程序
        public static void closeProcess(String name)
        {
            Process[] temp = Process.GetProcessesByName(name);
            if (temp != null && temp.Length > 0)
            {
                foreach (Process p in temp)
                {
                    p.Kill();
                }
            }
        }
    }
}
