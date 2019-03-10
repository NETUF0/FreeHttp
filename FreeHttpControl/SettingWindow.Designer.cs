﻿namespace FreeHttp.FreeHttpControl
{
    partial class SettingWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingWindow));
            this.lb_info_1 = new System.Windows.Forms.Label();
            this.lb_info_2 = new System.Windows.Forms.Label();
            this.lb_info_3 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.myEnableSwitch_IsDefaultEnableRule = new FreeHttp.FreeHttpControl.MyEnableSwitch();
            this.myEnableSwitch_IsSkipConnectTunnels = new FreeHttp.FreeHttpControl.MyEnableSwitch();
            this.myEnableSwitch_IsOnlyMatchFistTamperRule = new FreeHttp.FreeHttpControl.MyEnableSwitch();
            this.SuspendLayout();
            // 
            // lb_info_1
            // 
            this.lb_info_1.AutoSize = true;
            this.lb_info_1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_info_1.Location = new System.Drawing.Point(3, 21);
            this.lb_info_1.Name = "lb_info_1";
            this.lb_info_1.Size = new System.Drawing.Size(224, 14);
            this.lb_info_1.TabIndex = 1;
            this.lb_info_1.Text = "is only match fist tamper rule ";
            // 
            // lb_info_2
            // 
            this.lb_info_2.AutoSize = true;
            this.lb_info_2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_info_2.Location = new System.Drawing.Point(3, 53);
            this.lb_info_2.Name = "lb_info_2";
            this.lb_info_2.Size = new System.Drawing.Size(168, 14);
            this.lb_info_2.TabIndex = 2;
            this.lb_info_2.Text = "is skip connect tunnels";
            // 
            // lb_info_3
            // 
            this.lb_info_3.AutoSize = true;
            this.lb_info_3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_info_3.Location = new System.Drawing.Point(3, 85);
            this.lb_info_3.Name = "lb_info_3";
            this.lb_info_3.Size = new System.Drawing.Size(224, 14);
            this.lb_info_3.TabIndex = 3;
            this.lb_info_3.Text = "is  default enable tanper rule ";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 123);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // myEnableSwitch_IsDefaultEnableRule
            // 
            this.myEnableSwitch_IsDefaultEnableRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myEnableSwitch_IsDefaultEnableRule.IsEnable = false;
            this.myEnableSwitch_IsDefaultEnableRule.Location = new System.Drawing.Point(284, 84);
            this.myEnableSwitch_IsDefaultEnableRule.Name = "myEnableSwitch_IsDefaultEnableRule";
            this.myEnableSwitch_IsDefaultEnableRule.Size = new System.Drawing.Size(54, 27);
            this.myEnableSwitch_IsDefaultEnableRule.TabIndex = 6;
            // 
            // myEnableSwitch_IsSkipConnectTunnels
            // 
            this.myEnableSwitch_IsSkipConnectTunnels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myEnableSwitch_IsSkipConnectTunnels.IsEnable = false;
            this.myEnableSwitch_IsSkipConnectTunnels.Location = new System.Drawing.Point(284, 48);
            this.myEnableSwitch_IsSkipConnectTunnels.Name = "myEnableSwitch_IsSkipConnectTunnels";
            this.myEnableSwitch_IsSkipConnectTunnels.Size = new System.Drawing.Size(54, 27);
            this.myEnableSwitch_IsSkipConnectTunnels.TabIndex = 5;
            // 
            // myEnableSwitch_IsOnlyMatchFistTamperRule
            // 
            this.myEnableSwitch_IsOnlyMatchFistTamperRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myEnableSwitch_IsOnlyMatchFistTamperRule.IsEnable = false;
            this.myEnableSwitch_IsOnlyMatchFistTamperRule.Location = new System.Drawing.Point(284, 12);
            this.myEnableSwitch_IsOnlyMatchFistTamperRule.Name = "myEnableSwitch_IsOnlyMatchFistTamperRule";
            this.myEnableSwitch_IsOnlyMatchFistTamperRule.Size = new System.Drawing.Size(54, 27);
            this.myEnableSwitch_IsOnlyMatchFistTamperRule.TabIndex = 0;
            // 
            // SettingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 123);
            this.Controls.Add(this.myEnableSwitch_IsDefaultEnableRule);
            this.Controls.Add(this.myEnableSwitch_IsSkipConnectTunnels);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lb_info_3);
            this.Controls.Add(this.lb_info_2);
            this.Controls.Add(this.lb_info_1);
            this.Controls.Add(this.myEnableSwitch_IsOnlyMatchFistTamperRule);
            this.Font = new System.Drawing.Font("华文楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingWindow";
            this.Load += new System.EventHandler(this.SettingWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyEnableSwitch myEnableSwitch_IsOnlyMatchFistTamperRule;
        private System.Windows.Forms.Label lb_info_1;
        private System.Windows.Forms.Label lb_info_2;
        private System.Windows.Forms.Label lb_info_3;
        private System.Windows.Forms.Splitter splitter1;
        private MyEnableSwitch myEnableSwitch_IsSkipConnectTunnels;
        private MyEnableSwitch myEnableSwitch_IsDefaultEnableRule;
    }
}