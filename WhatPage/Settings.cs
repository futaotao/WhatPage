using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

namespace WhatPage
{
    public partial class Settings : Form, OnProcessListener
    {

        private Thread runThread = null;

        private static String BASE_PATH = "";

        //循环是否启动
        private static bool isRun = false;

        

        private static bool isVpnConnect = false;
        


        public Settings()
        {
            InitializeComponent();

            Settings.CheckForIllegalCrossThreadCalls = false;


            runThread = new Thread(run);

            BASE_PATH = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\") + 1);

           

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            initUI();

            
            //"C:\\Users\\Administrator\\AppData\\Local\\Google\\Chrome\\Application\\chrome.exe";
            //"C:\\Program Files (x86)\\Internet Explorer\\iexplore.exe";
        }

        private void initUI() {
            cfgPath.Text = BASE_PATH + Constant.CONFIG_NAME;

            initCfg();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            isRun = true;

            if (runThread != null)
            {
                runThread.Start();
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string cfg = "";
            cfg += "vpnName=" + vpnNameTb.Text + "\n";
            cfg += "vpnUser=" + vpnUserTb.Text + "\n";
            cfg += "vpnPass=" + vpnPassTb.Text + "\n";
            cfg += "adRTime=" + adRTimeTb.Text + "\n";
            cfg += "adX=" + adXTb.Text + "\n";
            cfg += "adY=" + adYTb.Text + "\n";
            cfg += "adRClick=" + adRClickTb.Text + "\n";
            cfg += "exePath=" + exePathTb.Text + "\n";
            cfg += "process=" + processTb.Text + "\n";
            cfg += "url=" + urlTb.Text + "\n";
            cfg += "randomScroll=" + randomScrollTb.Text + "\n";
            saveCfg(cfgPath.Text, cfg);
        }

        private void run() {
            
            while (isRun) {
                //LogUtil.LogMessage(log, "--------while begin----------");
                // 零.连接vpn 检测ip是否有效
                //如果无效,如果无效 七
                if (!isVpnConnect)
                {
                    LogUtil.LogMessage(log, "-----changeNet----------");
                    isVpnConnect = true;
                    changeNet();
                }



                // 三.随机时间点击 （广告）

                // 四.随机浏览网页

                // 五.关闭清除缓存数据

                // 六.保存日志

                // 七.关闭vpn


                //isRun = false;
               
                //LogUtil.LogMessage(log, "--------while end----------");

            }
        }


        /// <summary>
        /// 初始化cfg
        /// </summary>
        private void initCfg() {
            LogUtil.LogMessage(log, "--------initCfg----------");
            Dictionary<string, string> cfgDic = readCfg(cfgPath.Text);
            if (cfgDic != null && cfgDic.Count > 0)
            {
                vpnNameTb.Text = cfgDic["vpnName"];
                vpnUserTb.Text = cfgDic["vpnUser"];
                vpnPassTb.Text = cfgDic["vpnPass"];
                adRTimeTb.Text = cfgDic["adRTime"];
                adXTb.Text = cfgDic["adX"];
                adYTb.Text = cfgDic["adY"];
                adRClickTb.Text = cfgDic["adRClick"];
                exePathTb.Text = cfgDic["exePath"];
                processTb.Text = cfgDic["process"];
                urlTb.Text = cfgDic["url"];
                randomScrollTb.Text = cfgDic["randomScroll"];
            }
        }

        /// <summary>
        /// 保存cfg
        /// </summary>
        private bool saveCfg(string filePath, string content)
        {
            LogUtil.LogMessage(log, "--------saveCfg----------");
            LogUtil.LogMessage(log, content);
            try
            {
                if (!File.Exists(filePath))
                {
                    FileStream stream = File.Create(filePath);
                    stream.Close();
                }
                StreamWriter writer = new StreamWriter(filePath, false);
                writer.Write(content);
                writer.Flush();
                writer.Close();
                return true;


                //if (File.Exists(propPath))
                //{
                //    删除后重新创建
                //    File.Delete(propPath);
                //    File.Copy(modelPath, propPath);
                //    return true;
                //}
                //else
                //{
                //    创建一个文件改写
                //    File.Copy(modelPath, propPath);
                //    return true;
                //}
            }
            catch (Exception e)
            {

            }
            return false;
        }

        /// <summary>
        /// 读取一个property内容
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private Dictionary<string, string> readCfg(string filePath)
        {
            Dictionary<string, string> contentDictionary = new Dictionary<string, string>();
            if (!File.Exists(filePath))
            {
                return contentDictionary;
            }
            FileStream fileStream = null;
            StreamReader streamReader = null;
            try
            {
                fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                streamReader = new StreamReader(fileStream, Encoding.Default);
                fileStream.Seek(0, SeekOrigin.Begin);
                string content = streamReader.ReadLine();
                while (content != null)
                {
                    if (content.Contains("="))
                    {
                        string key = content.Substring(0, content.LastIndexOf("=")).Trim();
                        string value = content.Substring(content.LastIndexOf("=") + 1).Trim();
                        if (!contentDictionary.ContainsKey(key))
                        {
                            contentDictionary.Add(key, value);
                        }
                    }
                    content = streamReader.ReadLine();
                }
            }
            catch
            {
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
            return contentDictionary;
        }

        /// <summary>
        /// 随机点击广告
        /// </summary>
        private void clickAd(int x, int y, int random) {
            LogUtil.LogMessage(log, "--------click ad----------");
            int val = getRandomVal(random);
            LogUtil.LogMessage(log, "--------sleep "+ val +"s----------");
            Thread.Sleep(val * 1000);
            click(x, y);
        }

        /// <summary>
        /// 随机访问网页
        /// </summary>
        private void radomWebpage(int times) {
            LogUtil.LogMessage(log, "--------radomWebpage----------");
            for (int i = 0; i <= times; i++)
            {
                LogUtil.LogMessage(log, "--------sleep 0.5s----------");
                Thread.Sleep(500);
                scroll();
            }
        }

        /// <summary>
        /// 连接vpn
        /// </summary>
        private void changeNet()
        {
            LogUtil.LogMessage(log, "-----changeNet----------" + "\n " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            //isStartChangeNet = true;
            //changeNetHour = DateTime.Now.Hour;
            //changeNetMin = DateTime.Now.Minute;
            //changeNetSec = DateTime.Now.Second;
            Util.callConnectVpn(BASE_PATH + Constant.Folders.BAT_FOLDER_NAME + "\\" + Constant.Apktool.VPN_C_BAT_NAME, "VPN", "b160", "222", this);
        }

        /// <summary>
        /// 关闭
        /// </summary>
        private void closeNet()
        {
            LogUtil.LogMessage(log, "-----closeNet----------");
            Util.callDisconnectVpn(BASE_PATH + Constant.Folders.BAT_FOLDER_NAME + "\\" + Constant.Apktool.VPN_D_BAT_NAME, "VPN", this);
        }

        /// <summary>
        /// 启动浏览器
        /// </summary>
        /// <param name="exePath"></param>
        /// <param name="url"></param>
        private void launchBrower(String exePath, String url) {
            Util.callLaunchBrower(BASE_PATH + Constant.Folders.BAT_FOLDER_NAME + "\\" + Constant.Apktool.BROWER_BAT_NAME, exePath, url, this);
        }

        public void onProcessOver(int type) { 
            switch (type){
                case Constant.ProcessType.TYPE_OF_PROCESS_CONNECT_VPN:

                    if (Util.myThread != null)
                    {
                        List<String> logList = Util.myThread.getLog();
                        String content = "";
                        if (logList != null && logList.Count > 0)
                        {
                            foreach (String logs in logList)
                            {
                                content = content + logs;
                            }
                        }


                        LogUtil.LogMessage(log, content);
                        //isStartChangeNet = false;
                        //changeNetHour = -1;
                        //changeNetMin = -1;
                        //changeNetSec = -1;

                        if (content.Contains("已连接") || content.Contains("已经连接"))
                        {
                            LogUtil.LogMessage(log, "---------vpn connect----------");
                            isVpnConnect = true;
                        }
                        else
                        {
                            LogUtil.LogMessage(log, "-----vpn connect failed----------");
                            isVpnConnect = true;
                            closeNet();

                            // 一.启动浏览器
                            launchBrower(exePathTb.Text, "www.baidu.com");
   
                        }

                    }
                    break;
                case Constant.ProcessType.TYPE_OF_PROCESS_DISCONNECT_VPN:
                    if (Util.myThread != null)
                    {
                        List<String> logList = Util.myThread.getLog();
                        String content = "";
                        if (logList != null && logList.Count > 0)
                        {
                            foreach (String logs in logList)
                            {
                                content = content + logs;
                            }
                        }           
                    }
                    break;
                case Constant.ProcessType.TYPE_OF_PROCESS_LAUNCH_BROWER:

                    if (Util.myThread != null)
                    {
                        List<String> logList = Util.myThread.getLog();
                        String content = "";
                        if (logList != null && logList.Count > 0)
                        {
                            foreach (String logs in logList)
                            {
                                content = content + logs;
                            }
                        }

                        LogUtil.LogMessage(log, content);

                        // 二.添加检测网页是否打开的
                        LogUtil.LogMessage(log, "添加检测网页是否打开的");
                        Thread.Sleep(3000); //TODO 添加检测网页是否打开的
                        
                        if (Util.getProcessStaus(processTb.Text) == Util.PROCESS_RUNNING)
                        {
                            LogUtil.LogMessage(log, "----网页已经打开----");
                            clickAd(1468, 96, 5);

                            Thread.Sleep(3000);

                            radomWebpage(4);

                            //TODO 清除缓存
                            LogUtil.LogMessage(log, "----关闭网页----");
                            Util.closeProcess(processTb.Text);

                        }

                        

                        //关闭vpn
                        LogUtil.LogMessage(log, "----关闭VPN----");
                        isVpnConnect = false;
                        closeNet();

                    }

                    break;
            }
        }


        //获取一个随机值
        private int getRandomVal(int max)
        {
            Random rd = new Random();
            return rd.Next(0, max);
        }

        #region
        //双击
        private void doubleClick(int x, int y)
        {
            LogUtil.LogMessage(log, "双：" + x + "  " + y);
            SetCursorPos(x, y);
            mouse_event(MouseEventFlag.LeftDown, 0, 0, 0, UIntPtr.Zero);
            mouse_event(MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
            mouse_event(MouseEventFlag.LeftDown, 0, 0, 0, UIntPtr.Zero);
            mouse_event(MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
        }

        //单击
        private void click(int x, int y)
        {
            LogUtil.LogMessage(log, "单：" + x + "  " + y);
            SetCursorPos(x, y);
            mouse_event(MouseEventFlag.LeftDown, 0, 0, 0, UIntPtr.Zero);
            mouse_event(MouseEventFlag.LeftUp, 0, 0, 0, UIntPtr.Zero);
        }

        //滚动
        
        private void scroll() {
            mouse_event(MouseEventFlag.Wheel, 0, 0, -2000, UIntPtr.Zero);
        }

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        static extern void mouse_event(MouseEventFlag flags,
            int dx, int dy, int data, UIntPtr extraInfo);

        [Flags]
        enum MouseEventFlag : uint
        {
            Move = 0x0001,
            LeftDown = 0x0002,
            LeftUp = 0x0004,
            RightDown = 0x0008,
            RightUp = 0x0010,
            MiddleDown = 0x0020,
            MiddleUp = 0x0040,
            XDown = 0x0080,
            XUp = 0x0100,
            Wheel = 0x0800,
            VirtualDesk = 0x4000,
            Absolute = 0x8000
        }
        #endregion

        #region 模拟输入

        private void inputStr(String processName, String text)
        {
            Process[] pro = Process.GetProcessesByName(processName);
            if (pro != null && pro.Length > 0)
            {
                if (pro[0].MainWindowHandle != IntPtr.Zero)
                {
                    IntPtr vHandle = FindWindow("QWidget", "Configure virtual device");
                    if (vHandle != IntPtr.Zero)
                    {
                        if (!text.Trim().Equals(""))
                        {
                            char[] t = text.ToCharArray();
                            foreach (char c in t)
                            {
                                SendMessage(vHandle, 0x0100, (int)c, 0);
                                SendMessage(vHandle, 0x0101, (int)c, 0);
                            }
                        }
                    }
                    //else {
                    //    MessageBox.Show("没找到子窗口");
                    //}

                }
                //else {
                //    MessageBox.Show("没找到父窗口");
                //}
            }

        }

        [DllImport("User32.DLL")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int param, int para);

        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.DLL")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        public const uint WM_SETTEXT = 0x000C;

        //private void movegenymotionwin()
        //{
        //    process[] ps = process.getprocessesbyname("genymotion");
        //    if (ps != null && ps.length > 0)
        //    {
        //        if (ps[0].mainwindowhandle != intptr.zero)
        //        {
        //            intptr genymotionhandle = findwindow("qwidget", "genymotion for personal use");
        //            if (genymotionhandle != intptr.zero)
        //            {
        //                rect rect = new rect();
        //                getwindowrect(genymotionhandle, ref rect);
        //                找到窗体
        //                movewindow(genymotionhandle, 0, 0, rect.right - rect.left, rect.bottom - rect.top, false);
        //            }

        //        }
        //    }
        //}

        [DllImportAttribute("user32.dll", EntryPoint = "MoveWindow")]
        public static extern bool MoveWindow(System.IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left; //最左坐标
            public int Top; //最上坐标
            public int Right; //最右坐标
            public int Bottom; //最下坐标
        }

        #endregion

       


      
 
    }
}
