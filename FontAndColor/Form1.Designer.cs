﻿namespace FontAndColor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tlsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnFont = new System.Windows.Forms.ToolStripButton();
            this.tsbtnColor = new System.Windows.Forms.ToolStripButton();
            this.fontDlg = new System.Windows.Forms.FontDialog();
            this.colorDlg = new System.Windows.Forms.ColorDialog();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlsMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsMenu
            // 
            this.tlsMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tlsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnFont,
            this.tsbtnColor});
            this.tlsMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsMenu.Name = "tlsMenu";
            this.tlsMenu.Size = new System.Drawing.Size(460, 25);
            this.tlsMenu.TabIndex = 0;
            this.tlsMenu.Text = "toolStrip1";
            // 
            // tsbtnFont
            // 
            this.tsbtnFont.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbtnFont.BackgroundImage")));
            this.tsbtnFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbtnFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFont.Name = "tsbtnFont";
            this.tsbtnFont.Size = new System.Drawing.Size(34, 20);
            this.tsbtnFont.Text = "toolStripButton1";
            this.tsbtnFont.Click += new System.EventHandler(this.TsbtnFont_Click);
            // 
            // tsbtnColor
            // 
            this.tsbtnColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbtnColor.BackgroundImage")));
            this.tsbtnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbtnColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnColor.Name = "tsbtnColor";
            this.tsbtnColor.Size = new System.Drawing.Size(34, 23);
            this.tsbtnColor.Text = "toolStripButton1";
            this.tsbtnColor.Click += new System.EventHandler(this.TsbtnColor_Click);
            // 
            // rtbText
            // 
            this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbText.Location = new System.Drawing.Point(0, 25);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(460, 323);
            this.rtbText.TabIndex = 1;
            this.rtbText.Text = "로렘 입숨Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 316);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(460, 32);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "3108 방채연";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(112, 25);
            this.toolStripStatusLabel1.Text = "3108 방채연";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(460, 348);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.tlsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "3108 방채연";
            this.tlsMenu.ResumeLayout(false);
            this.tlsMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsMenu;
        private System.Windows.Forms.FontDialog fontDlg;
        private System.Windows.Forms.ToolStripButton tsbtnFont;
        private System.Windows.Forms.ColorDialog colorDlg;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.ToolStripButton tsbtnColor;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
