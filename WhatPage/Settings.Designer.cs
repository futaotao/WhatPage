namespace WhatPage
{
    partial class Settings
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vpnPass = new System.Windows.Forms.Label();
            this.vpnPassTb = new System.Windows.Forms.TextBox();
            this.vpnUser = new System.Windows.Forms.Label();
            this.vpnUserTb = new System.Windows.Forms.TextBox();
            this.vpnName = new System.Windows.Forms.Label();
            this.vpnNameTb = new System.Windows.Forms.TextBox();
            this.web = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.urlTb = new System.Windows.Forms.TextBox();
            this.exePath = new System.Windows.Forms.Label();
            this.exePathTb = new System.Windows.Forms.TextBox();
            this.runBtn = new System.Windows.Forms.Button();
            this.testCB = new System.Windows.Forms.CheckBox();
            this.log = new System.Windows.Forms.RichTextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.ad = new System.Windows.Forms.GroupBox();
            this.adTap = new System.Windows.Forms.Label();
            this.adRClickTb = new System.Windows.Forms.TextBox();
            this.adY = new System.Windows.Forms.Label();
            this.adYTb = new System.Windows.Forms.TextBox();
            this.adX = new System.Windows.Forms.Label();
            this.adXTb = new System.Windows.Forms.TextBox();
            this.adRmTime = new System.Windows.Forms.Label();
            this.adRTimeTb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.randomScrollTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cfgPath = new System.Windows.Forms.Label();
            this.processLabel = new System.Windows.Forms.Label();
            this.processTb = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.web.SuspendLayout();
            this.ad.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vpnPass);
            this.groupBox1.Controls.Add(this.vpnPassTb);
            this.groupBox1.Controls.Add(this.vpnUser);
            this.groupBox1.Controls.Add(this.vpnUserTb);
            this.groupBox1.Controls.Add(this.vpnName);
            this.groupBox1.Controls.Add(this.vpnNameTb);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vpn";
            // 
            // vpnPass
            // 
            this.vpnPass.AutoSize = true;
            this.vpnPass.Location = new System.Drawing.Point(7, 78);
            this.vpnPass.Name = "vpnPass";
            this.vpnPass.Size = new System.Drawing.Size(53, 12);
            this.vpnPass.TabIndex = 6;
            this.vpnPass.Text = "vpnPass:";
            // 
            // vpnPassTb
            // 
            this.vpnPassTb.Location = new System.Drawing.Point(60, 74);
            this.vpnPassTb.Name = "vpnPassTb";
            this.vpnPassTb.Size = new System.Drawing.Size(100, 21);
            this.vpnPassTb.TabIndex = 5;
            // 
            // vpnUser
            // 
            this.vpnUser.AutoSize = true;
            this.vpnUser.Location = new System.Drawing.Point(7, 51);
            this.vpnUser.Name = "vpnUser";
            this.vpnUser.Size = new System.Drawing.Size(53, 12);
            this.vpnUser.TabIndex = 4;
            this.vpnUser.Text = "vpnUser:";
            // 
            // vpnUserTb
            // 
            this.vpnUserTb.Location = new System.Drawing.Point(60, 47);
            this.vpnUserTb.Name = "vpnUserTb";
            this.vpnUserTb.Size = new System.Drawing.Size(100, 21);
            this.vpnUserTb.TabIndex = 3;
            // 
            // vpnName
            // 
            this.vpnName.AutoSize = true;
            this.vpnName.Location = new System.Drawing.Point(6, 23);
            this.vpnName.Name = "vpnName";
            this.vpnName.Size = new System.Drawing.Size(53, 12);
            this.vpnName.TabIndex = 2;
            this.vpnName.Text = "vpnName:";
            // 
            // vpnNameTb
            // 
            this.vpnNameTb.Location = new System.Drawing.Point(60, 20);
            this.vpnNameTb.Name = "vpnNameTb";
            this.vpnNameTb.Size = new System.Drawing.Size(100, 21);
            this.vpnNameTb.TabIndex = 1;
            // 
            // web
            // 
            this.web.Controls.Add(this.processLabel);
            this.web.Controls.Add(this.processTb);
            this.web.Controls.Add(this.label1);
            this.web.Controls.Add(this.urlTb);
            this.web.Controls.Add(this.exePath);
            this.web.Controls.Add(this.exePathTb);
            this.web.Location = new System.Drawing.Point(197, 29);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(200, 108);
            this.web.TabIndex = 1;
            this.web.TabStop = false;
            this.web.Text = "Web";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "url:";
            // 
            // urlTb
            // 
            this.urlTb.Location = new System.Drawing.Point(38, 73);
            this.urlTb.Name = "urlTb";
            this.urlTb.Size = new System.Drawing.Size(154, 21);
            this.urlTb.TabIndex = 8;
            // 
            // exePath
            // 
            this.exePath.AutoSize = true;
            this.exePath.Location = new System.Drawing.Point(11, 22);
            this.exePath.Name = "exePath";
            this.exePath.Size = new System.Drawing.Size(29, 12);
            this.exePath.TabIndex = 7;
            this.exePath.Text = "exe:";
            // 
            // exePathTb
            // 
            this.exePathTb.Location = new System.Drawing.Point(38, 19);
            this.exePathTb.Name = "exePathTb";
            this.exePathTb.Size = new System.Drawing.Size(154, 21);
            this.exePathTb.TabIndex = 6;
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(138, 319);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(83, 39);
            this.runBtn.TabIndex = 2;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // testCB
            // 
            this.testCB.AutoSize = true;
            this.testCB.Location = new System.Drawing.Point(173, 364);
            this.testCB.Name = "testCB";
            this.testCB.Size = new System.Drawing.Size(48, 16);
            this.testCB.TabIndex = 3;
            this.testCB.Text = "Test";
            this.testCB.UseVisualStyleBackColor = true;
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(404, 13);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(249, 381);
            this.log.TabIndex = 4;
            this.log.Text = "";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(342, 7);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(42, 22);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "保存";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // ad
            // 
            this.ad.Controls.Add(this.adTap);
            this.ad.Controls.Add(this.adRClickTb);
            this.ad.Controls.Add(this.adY);
            this.ad.Controls.Add(this.adYTb);
            this.ad.Controls.Add(this.adX);
            this.ad.Controls.Add(this.adXTb);
            this.ad.Controls.Add(this.adRmTime);
            this.ad.Controls.Add(this.adRTimeTb);
            this.ad.Location = new System.Drawing.Point(12, 143);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(178, 127);
            this.ad.TabIndex = 6;
            this.ad.TabStop = false;
            this.ad.Text = "广告";
            // 
            // adTap
            // 
            this.adTap.AutoSize = true;
            this.adTap.Location = new System.Drawing.Point(5, 100);
            this.adTap.Name = "adTap";
            this.adTap.Size = new System.Drawing.Size(59, 12);
            this.adTap.TabIndex = 14;
            this.adTap.Text = "点击概率:";
            // 
            // adRClickTb
            // 
            this.adRClickTb.Location = new System.Drawing.Point(66, 97);
            this.adRClickTb.Name = "adRClickTb";
            this.adRClickTb.Size = new System.Drawing.Size(88, 21);
            this.adRClickTb.TabIndex = 13;
            // 
            // adY
            // 
            this.adY.AutoSize = true;
            this.adY.Location = new System.Drawing.Point(24, 74);
            this.adY.Name = "adY";
            this.adY.Size = new System.Drawing.Size(41, 12);
            this.adY.TabIndex = 12;
            this.adY.Text = "Y坐标:";
            // 
            // adYTb
            // 
            this.adYTb.Location = new System.Drawing.Point(66, 70);
            this.adYTb.Name = "adYTb";
            this.adYTb.Size = new System.Drawing.Size(88, 21);
            this.adYTb.TabIndex = 11;
            // 
            // adX
            // 
            this.adX.AutoSize = true;
            this.adX.Location = new System.Drawing.Point(25, 48);
            this.adX.Name = "adX";
            this.adX.Size = new System.Drawing.Size(41, 12);
            this.adX.TabIndex = 10;
            this.adX.Text = "X坐标:";
            // 
            // adXTb
            // 
            this.adXTb.Location = new System.Drawing.Point(66, 43);
            this.adXTb.Name = "adXTb";
            this.adXTb.Size = new System.Drawing.Size(88, 21);
            this.adXTb.TabIndex = 9;
            // 
            // adRmTime
            // 
            this.adRmTime.AutoSize = true;
            this.adRmTime.Location = new System.Drawing.Point(6, 19);
            this.adRmTime.Name = "adRmTime";
            this.adRmTime.Size = new System.Drawing.Size(59, 12);
            this.adRmTime.TabIndex = 8;
            this.adRmTime.Text = "随机时间:";
            // 
            // adRTimeTb
            // 
            this.adRTimeTb.Location = new System.Drawing.Point(66, 15);
            this.adRTimeTb.Name = "adRTimeTb";
            this.adRTimeTb.Size = new System.Drawing.Size(88, 21);
            this.adRTimeTb.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.randomScrollTb);
            this.groupBox2.Location = new System.Drawing.Point(198, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 127);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "随机事件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "滚动次数:";
            // 
            // randomScrollTb
            // 
            this.randomScrollTb.Location = new System.Drawing.Point(75, 18);
            this.randomScrollTb.Name = "randomScrollTb";
            this.randomScrollTb.Size = new System.Drawing.Size(88, 21);
            this.randomScrollTb.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cfg：";
            // 
            // cfgPath
            // 
            this.cfgPath.AutoSize = true;
            this.cfgPath.Location = new System.Drawing.Point(53, 9);
            this.cfgPath.Name = "cfgPath";
            this.cfgPath.Size = new System.Drawing.Size(0, 12);
            this.cfgPath.TabIndex = 9;
            // 
            // processLabel
            // 
            this.processLabel.AutoSize = true;
            this.processLabel.Location = new System.Drawing.Point(11, 50);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(53, 12);
            this.processLabel.TabIndex = 11;
            this.processLabel.Text = "process:";
            // 
            // processTb
            // 
            this.processTb.Location = new System.Drawing.Point(70, 46);
            this.processTb.Name = "processTb";
            this.processTb.Size = new System.Drawing.Size(122, 21);
            this.processTb.TabIndex = 10;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 401);
            this.Controls.Add(this.cfgPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.log);
            this.Controls.Add(this.testCB);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.web);
            this.Controls.Add(this.groupBox1);
            this.Name = "Settings";
            this.Text = "设置";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.web.ResumeLayout(false);
            this.web.PerformLayout();
            this.ad.ResumeLayout(false);
            this.ad.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label vpnPass;
        private System.Windows.Forms.TextBox vpnPassTb;
        private System.Windows.Forms.Label vpnUser;
        private System.Windows.Forms.TextBox vpnUserTb;
        private System.Windows.Forms.Label vpnName;
        private System.Windows.Forms.TextBox vpnNameTb;
        private System.Windows.Forms.GroupBox web;
        private System.Windows.Forms.Label exePath;
        private System.Windows.Forms.TextBox exePathTb;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.CheckBox testCB;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox ad;
        private System.Windows.Forms.Label adY;
        private System.Windows.Forms.TextBox adYTb;
        private System.Windows.Forms.Label adX;
        private System.Windows.Forms.TextBox adXTb;
        private System.Windows.Forms.Label adRmTime;
        private System.Windows.Forms.TextBox adRTimeTb;
        private System.Windows.Forms.Label adTap;
        private System.Windows.Forms.TextBox adRClickTb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox randomScrollTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cfgPath;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.TextBox processTb;
    }
}

