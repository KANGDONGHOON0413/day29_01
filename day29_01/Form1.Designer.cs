
namespace day29_01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_SERVER_STAT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_PWD = new System.Windows.Forms.TextBox();
            this.TXT_ID = new System.Windows.Forms.TextBox();
            this.TXT_DB_NAME = new System.Windows.Forms.TextBox();
            this.BTN_ACCESS = new System.Windows.Forms.Button();
            this.BTN_DB_OPEN = new System.Windows.Forms.Button();
            this.BTN_DB_CLOSE = new System.Windows.Forms.Button();
            this.BTN_SERVER_CLOSE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "서버연결상태:";
            // 
            // TXT_SERVER_STAT
            // 
            this.TXT_SERVER_STAT.AutoSize = true;
            this.TXT_SERVER_STAT.Location = new System.Drawing.Point(127, 20);
            this.TXT_SERVER_STAT.Name = "TXT_SERVER_STAT";
            this.TXT_SERVER_STAT.Size = new System.Drawing.Size(50, 20);
            this.TXT_SERVER_STAT.TabIndex = 1;
            this.TXT_SERVER_STAT.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "DB NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "PW:";
            // 
            // TXT_PWD
            // 
            this.TXT_PWD.Location = new System.Drawing.Point(126, 150);
            this.TXT_PWD.Name = "TXT_PWD";
            this.TXT_PWD.PasswordChar = '*';
            this.TXT_PWD.Size = new System.Drawing.Size(193, 27);
            this.TXT_PWD.TabIndex = 5;
            // 
            // TXT_ID
            // 
            this.TXT_ID.Location = new System.Drawing.Point(126, 101);
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.Size = new System.Drawing.Size(193, 27);
            this.TXT_ID.TabIndex = 6;
            // 
            // TXT_DB_NAME
            // 
            this.TXT_DB_NAME.Location = new System.Drawing.Point(126, 55);
            this.TXT_DB_NAME.Name = "TXT_DB_NAME";
            this.TXT_DB_NAME.Size = new System.Drawing.Size(193, 27);
            this.TXT_DB_NAME.TabIndex = 7;
            // 
            // BTN_ACCESS
            // 
            this.BTN_ACCESS.Location = new System.Drawing.Point(18, 192);
            this.BTN_ACCESS.Name = "BTN_ACCESS";
            this.BTN_ACCESS.Size = new System.Drawing.Size(301, 29);
            this.BTN_ACCESS.TabIndex = 8;
            this.BTN_ACCESS.Text = "서버 연결";
            this.BTN_ACCESS.UseVisualStyleBackColor = true;
            this.BTN_ACCESS.Click += new System.EventHandler(this.BTN_ACCESS_Click);
            // 
            // BTN_DB_OPEN
            // 
            this.BTN_DB_OPEN.Location = new System.Drawing.Point(18, 227);
            this.BTN_DB_OPEN.Name = "BTN_DB_OPEN";
            this.BTN_DB_OPEN.Size = new System.Drawing.Size(94, 57);
            this.BTN_DB_OPEN.TabIndex = 9;
            this.BTN_DB_OPEN.Text = "DB 열기";
            this.BTN_DB_OPEN.UseVisualStyleBackColor = true;
            this.BTN_DB_OPEN.Click += new System.EventHandler(this.BTN_DB_OPEN_Click);
            // 
            // BTN_DB_CLOSE
            // 
            this.BTN_DB_CLOSE.Location = new System.Drawing.Point(118, 227);
            this.BTN_DB_CLOSE.Name = "BTN_DB_CLOSE";
            this.BTN_DB_CLOSE.Size = new System.Drawing.Size(94, 57);
            this.BTN_DB_CLOSE.TabIndex = 10;
            this.BTN_DB_CLOSE.Text = "DB 닫기";
            this.BTN_DB_CLOSE.UseVisualStyleBackColor = true;
            this.BTN_DB_CLOSE.Click += new System.EventHandler(this.BTN_DB_CLOSE_Click);
            // 
            // BTN_SERVER_CLOSE
            // 
            this.BTN_SERVER_CLOSE.Location = new System.Drawing.Point(218, 227);
            this.BTN_SERVER_CLOSE.Name = "BTN_SERVER_CLOSE";
            this.BTN_SERVER_CLOSE.Size = new System.Drawing.Size(101, 57);
            this.BTN_SERVER_CLOSE.TabIndex = 11;
            this.BTN_SERVER_CLOSE.Text = "서버 연결 해제";
            this.BTN_SERVER_CLOSE.UseVisualStyleBackColor = true;
            this.BTN_SERVER_CLOSE.Click += new System.EventHandler(this.BTN_SERVER_CLOSE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 313);
            this.Controls.Add(this.BTN_SERVER_CLOSE);
            this.Controls.Add(this.BTN_DB_CLOSE);
            this.Controls.Add(this.BTN_DB_OPEN);
            this.Controls.Add(this.BTN_ACCESS);
            this.Controls.Add(this.TXT_DB_NAME);
            this.Controls.Add(this.TXT_ID);
            this.Controls.Add(this.TXT_PWD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_SERVER_STAT);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TXT_SERVER_STAT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_PWD;
        private System.Windows.Forms.TextBox TXT_ID;
        private System.Windows.Forms.TextBox TXT_DB_NAME;
        private System.Windows.Forms.Button BTN_ACCESS;
        private System.Windows.Forms.Button BTN_DB_OPEN;
        private System.Windows.Forms.Button BTN_DB_CLOSE;
        private System.Windows.Forms.Button BTN_SERVER_CLOSE;
    }
}

