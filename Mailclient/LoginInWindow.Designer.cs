namespace Mailclient
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmailAddressTxt = new System.Windows.Forms.TextBox();
            this.EmailPasswordTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoginInBtn = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.RememberChk = new System.Windows.Forms.CheckBox();
            this.ErrorLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailAddressTxt
            // 
            this.EmailAddressTxt.BackColor = System.Drawing.Color.White;
            this.EmailAddressTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailAddressTxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailAddressTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.EmailAddressTxt.Location = new System.Drawing.Point(132, 59);
            this.EmailAddressTxt.Name = "EmailAddressTxt";
            this.EmailAddressTxt.Size = new System.Drawing.Size(227, 19);
            this.EmailAddressTxt.TabIndex = 2;
            this.EmailAddressTxt.Text = "E-Mail address";
            // 
            // EmailPasswordTxt
            // 
            this.EmailPasswordTxt.BackColor = System.Drawing.Color.White;
            this.EmailPasswordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailPasswordTxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailPasswordTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.EmailPasswordTxt.Location = new System.Drawing.Point(132, 132);
            this.EmailPasswordTxt.Name = "EmailPasswordTxt";
            this.EmailPasswordTxt.PasswordChar = '*';
            this.EmailPasswordTxt.Size = new System.Drawing.Size(227, 19);
            this.EmailPasswordTxt.TabIndex = 3;
            this.EmailPasswordTxt.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(130, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(132, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 7;
            // 
            // LoginInBtn
            // 
            this.LoginInBtn.BackColor = System.Drawing.Color.Black;
            this.LoginInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginInBtn.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginInBtn.ForeColor = System.Drawing.Color.White;
            this.LoginInBtn.Location = new System.Drawing.Point(130, 195);
            this.LoginInBtn.Name = "LoginInBtn";
            this.LoginInBtn.Size = new System.Drawing.Size(161, 30);
            this.LoginInBtn.TabIndex = 8;
            this.LoginInBtn.Text = "Войти";
            this.LoginInBtn.UseVisualStyleBackColor = false;
            this.LoginInBtn.Click += new System.EventHandler(this.LoginInBtn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Mailclient.Properties.Resources.padlock_4_48;
            this.pictureBox4.Location = new System.Drawing.Point(57, 124);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 46);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Mailclient.Properties.Resources.mail_2_48;
            this.pictureBox3.Location = new System.Drawing.Point(57, 46);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 46);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // RememberChk
            // 
            this.RememberChk.AutoSize = true;
            this.RememberChk.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RememberChk.Location = new System.Drawing.Point(161, 246);
            this.RememberChk.Name = "RememberChk";
            this.RememberChk.Size = new System.Drawing.Size(112, 23);
            this.RememberChk.TabIndex = 9;
            this.RememberChk.Text = "Запомнить ";
            this.RememberChk.UseVisualStyleBackColor = true;
            // 
            // ErrorLb
            // 
            this.ErrorLb.AutoSize = true;
            this.ErrorLb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLb.Location = new System.Drawing.Point(44, 9);
            this.ErrorLb.Name = "ErrorLb";
            this.ErrorLb.Size = new System.Drawing.Size(349, 19);
            this.ErrorLb.TabIndex = 10;
            this.ErrorLb.Text = "Не удалось подключиться к почтовому ящику";
            this.ErrorLb.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(424, 288);
            this.Controls.Add(this.ErrorLb);
            this.Controls.Add(this.RememberChk);
            this.Controls.Add(this.LoginInBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.EmailPasswordTxt);
            this.Controls.Add(this.EmailAddressTxt);
            this.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailClient";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EmailAddressTxt;
        private System.Windows.Forms.TextBox EmailPasswordTxt;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LoginInBtn;
        private System.Windows.Forms.CheckBox RememberChk;
        private System.Windows.Forms.Label ErrorLb;
    }
}

