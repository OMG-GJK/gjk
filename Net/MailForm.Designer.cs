namespace Net
{
    partial class MailForm
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
            this.Content = new System.Windows.Forms.RichTextBox();
            this.mailtoBox = new System.Windows.Forms.TextBox();
            this.mailTo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.Sendbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.Location = new System.Drawing.Point(35, 127);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(556, 297);
            this.Content.TabIndex = 0;
            this.Content.Text = "";
            // 
            // mailtoBox
            // 
            this.mailtoBox.Location = new System.Drawing.Point(100, 15);
            this.mailtoBox.Name = "mailtoBox";
            this.mailtoBox.Size = new System.Drawing.Size(491, 21);
            this.mailtoBox.TabIndex = 1;
            this.mailtoBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mailTo
            // 
            this.mailTo.Location = new System.Drawing.Point(35, 15);
            this.mailTo.Name = "mailTo";
            this.mailTo.Size = new System.Drawing.Size(51, 31);
            this.mailTo.TabIndex = 2;
            this.mailTo.Text = "发送给";
            this.mailTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(479, 21);
            this.textBox2.TabIndex = 3;
            // 
            // subject
            // 
            this.subject.AutoSize = true;
            this.subject.Location = new System.Drawing.Point(57, 98);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(29, 12);
            this.subject.TabIndex = 4;
            this.subject.Text = "主题";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(35, 441);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 5;
            this.add.Text = "添加附件";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Sendbtn
            // 
            this.Sendbtn.Location = new System.Drawing.Point(514, 440);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(75, 23);
            this.Sendbtn.TabIndex = 6;
            this.Sendbtn.Text = "发送";
            this.Sendbtn.UseVisualStyleBackColor = true;
            this.Sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 479);
            this.Controls.Add(this.Sendbtn);
            this.Controls.Add(this.add);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.mailTo);
            this.Controls.Add(this.mailtoBox);
            this.Controls.Add(this.Content);
            this.Name = "MailForm";
            this.Text = "Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Content;
        private System.Windows.Forms.TextBox mailtoBox;
        private System.Windows.Forms.Label mailTo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label subject;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button Sendbtn;
    }
}