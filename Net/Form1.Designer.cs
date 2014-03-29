namespace Net
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ShowField = new System.Windows.Forms.RichTextBox();
            this.MsgField = new System.Windows.Forms.RichTextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.VoiceCommunication = new AxVSESSIONLib.AxVSession();
            this.startVoiceCommunication = new System.Windows.Forms.Button();
            this.stopVoiceCommunication = new System.Windows.Forms.Button();
            this.SendMail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VoiceCommunication)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowField
            // 
            this.ShowField.Location = new System.Drawing.Point(53, 24);
            this.ShowField.Name = "ShowField";
            this.ShowField.Size = new System.Drawing.Size(409, 250);
            this.ShowField.TabIndex = 0;
            this.ShowField.Text = "";
            this.ShowField.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // MsgField
            // 
            this.MsgField.Location = new System.Drawing.Point(53, 372);
            this.MsgField.Multiline = false;
            this.MsgField.Name = "MsgField";
            this.MsgField.Size = new System.Drawing.Size(398, 28);
            this.MsgField.TabIndex = 1;
            this.MsgField.Text = "";
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(480, 377);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 23);
            this.SendBtn.TabIndex = 2;
            this.SendBtn.Text = "发送";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // VoiceCommunication
            // 
            this.VoiceCommunication.Enabled = true;
            this.VoiceCommunication.Location = new System.Drawing.Point(53, 313);
            this.VoiceCommunication.Name = "VoiceCommunication";
            this.VoiceCommunication.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VoiceCommunication.OcxState")));
            this.VoiceCommunication.Size = new System.Drawing.Size(32, 32);
            this.VoiceCommunication.TabIndex = 3;
            this.VoiceCommunication.Visible = false;
            this.VoiceCommunication.Enter += new System.EventHandler(this.axVSession2_Enter);
            // 
            // startVoiceCommunication
            // 
            this.startVoiceCommunication.Location = new System.Drawing.Point(480, 319);
            this.startVoiceCommunication.Name = "startVoiceCommunication";
            this.startVoiceCommunication.Size = new System.Drawing.Size(75, 23);
            this.startVoiceCommunication.TabIndex = 4;
            this.startVoiceCommunication.Text = "语音通话";
            this.startVoiceCommunication.UseVisualStyleBackColor = true;
            this.startVoiceCommunication.Click += new System.EventHandler(this.startVoiceCommunication_Click);
            // 
            // stopVoiceCommunication
            // 
            this.stopVoiceCommunication.Location = new System.Drawing.Point(480, 348);
            this.stopVoiceCommunication.Name = "stopVoiceCommunication";
            this.stopVoiceCommunication.Size = new System.Drawing.Size(75, 23);
            this.stopVoiceCommunication.TabIndex = 5;
            this.stopVoiceCommunication.Text = "停止语音";
            this.stopVoiceCommunication.UseVisualStyleBackColor = true;
            this.stopVoiceCommunication.Click += new System.EventHandler(this.stopVoiceCommunication_Click);
            // 
            // SendMail
            // 
            this.SendMail.Location = new System.Drawing.Point(480, 290);
            this.SendMail.Name = "SendMail";
            this.SendMail.Size = new System.Drawing.Size(75, 23);
            this.SendMail.TabIndex = 6;
            this.SendMail.Text = "发送邮件";
            this.SendMail.UseVisualStyleBackColor = true;
            this.SendMail.Click += new System.EventHandler(this.SendMail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 426);
            this.Controls.Add(this.SendMail);
            this.Controls.Add(this.stopVoiceCommunication);
            this.Controls.Add(this.startVoiceCommunication);
            this.Controls.Add(this.VoiceCommunication);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.MsgField);
            this.Controls.Add(this.ShowField);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.VoiceCommunication)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ShowField;
        private System.Windows.Forms.RichTextBox MsgField;
        private System.Windows.Forms.Button SendBtn;
        private AxVSESSIONLib.AxVSession axVSession1;
        private AxVSESSIONLib.AxVSession VoiceCommunication;
        private System.Windows.Forms.Button startVoiceCommunication;
        private System.Windows.Forms.Button stopVoiceCommunication;
        private System.Windows.Forms.Button SendMail;
    }
}

