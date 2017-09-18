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

namespace WhatPage
{
    public partial class Settings : Form, OnProcessListener
    {

        private Thread runThread = null;

        private static String BASE_PATH = "";

        private static bool isRun = false;

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

            exePathTb.Text = "C:\\Users\\Administrator\\AppData\\Local\\Google\\Chrome\\Application\\chrome.exe";
                //"C:\\Program Files (x86)\\Internet Explorer\\iexplore.exe";
        }

        private void initUI() {
           
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            isRun = true;

            if (runThread != null)
            {
                runThread.Start();
            }

        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            isRun = false;
        }

        private void run() {
            
            while (isRun) {
                // 零.连接vpn 检测ip是否有效
                //如果无效,如果无效 七

                // 一.启动浏览器
                launchBrower(exePathTb.Text, "www.baidu.com");
                // 二.检测浏览器是否打开
                Thread.Sleep(3000);
                // 三.随机时间点击 （广告）

                // 四.随机浏览网页

                // 五.关闭清除缓存数据

                // 六.保存日志

                // 七.关闭vpn

                
                isRun = false;

            }
        }

        private void launchBrower(String exePath, String url) {
            Util.callLaunchBrower(BASE_PATH + Constant.Folders.BAT_FOLDER_NAME + "\\" + Constant.Apktool.BROWER_BAT_NAME, exePath, url, this);
        }

        public void onProcessOver(int type) { 
            switch (type){
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
                    }

                    break;
            }
        }

      
 
    }
}
