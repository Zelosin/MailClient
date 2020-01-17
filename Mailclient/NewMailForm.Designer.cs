namespace Mailclient
{
    partial class NewMailForm
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
            this.SendNewMailButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewMailAddress = new System.Windows.Forms.TextBox();
            this.NewMailSubject = new System.Windows.Forms.TextBox();
            this.NewMailText = new System.Windows.Forms.TextBox();
            this.DisplayedName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SendingMailResult = new System.Windows.Forms.Label();
            this.AddFile = new System.Windows.Forms.Button();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SendNewMailButton
            // 
            this.SendNewMailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendNewMailButton.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendNewMailButton.ForeColor = System.Drawing.Color.White;
            this.SendNewMailButton.Location = new System.Drawing.Point(133, 416);
            this.SendNewMailButton.Name = "SendNewMailButton";
            this.SendNewMailButton.Size = new System.Drawing.Size(133, 32);
            this.SendNewMailButton.TabIndex = 0;
            this.SendNewMailButton.Text = "Отправить";
            this.SendNewMailButton.UseVisualStyleBackColor = true;
            this.SendNewMailButton.Click += new System.EventHandler(this.SendNewMailButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Адрес отправки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тема письма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Текст письма";
            // 
            // NewMailAddress
            // 
            this.NewMailAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewMailAddress.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewMailAddress.ForeColor = System.Drawing.Color.White;
            this.NewMailAddress.Location = new System.Drawing.Point(16, 25);
            this.NewMailAddress.Name = "NewMailAddress";
            this.NewMailAddress.Size = new System.Drawing.Size(357, 15);
            this.NewMailAddress.TabIndex = 4;
            // 
            // NewMailSubject
            // 
            this.NewMailSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewMailSubject.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewMailSubject.ForeColor = System.Drawing.Color.White;
            this.NewMailSubject.Location = new System.Drawing.Point(16, 64);
            this.NewMailSubject.Name = "NewMailSubject";
            this.NewMailSubject.Size = new System.Drawing.Size(359, 15);
            this.NewMailSubject.TabIndex = 5;
            // 
            // NewMailText
            // 
            this.NewMailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewMailText.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewMailText.ForeColor = System.Drawing.Color.White;
            this.NewMailText.Location = new System.Drawing.Point(16, 142);
            this.NewMailText.Multiline = true;
            this.NewMailText.Name = "NewMailText";
            this.NewMailText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NewMailText.Size = new System.Drawing.Size(378, 205);
            this.NewMailText.TabIndex = 6;
            // 
            // DisplayedName
            // 
            this.DisplayedName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DisplayedName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisplayedName.ForeColor = System.Drawing.Color.White;
            this.DisplayedName.Location = new System.Drawing.Point(16, 103);
            this.DisplayedName.Name = "DisplayedName";
            this.DisplayedName.Size = new System.Drawing.Size(359, 15);
            this.DisplayedName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Отображаемое имя";
            // 
            // SendingMailResult
            // 
            this.SendingMailResult.AutoSize = true;
            this.SendingMailResult.Location = new System.Drawing.Point(147, 451);
            this.SendingMailResult.Name = "SendingMailResult";
            this.SendingMailResult.Size = new System.Drawing.Size(0, 13);
            this.SendingMailResult.TabIndex = 9;
            // 
            // AddFile
            // 
            this.AddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFile.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddFile.ForeColor = System.Drawing.Color.White;
            this.AddFile.Location = new System.Drawing.Point(16, 353);
            this.AddFile.Name = "AddFile";
            this.AddFile.Size = new System.Drawing.Size(90, 23);
            this.AddFile.TabIndex = 10;
            this.AddFile.Text = "Вложить файл";
            this.AddFile.UseVisualStyleBackColor = true;
            this.AddFile.Click += new System.EventHandler(this.AddFile_Click);
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoEllipsis = true;
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilePathLabel.ForeColor = System.Drawing.Color.White;
            this.FilePathLabel.Location = new System.Drawing.Point(13, 393);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(0, 14);
            this.FilePathLabel.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Location = new System.Drawing.Point(13, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 1);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Location = new System.Drawing.Point(12, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(360, 1);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.Location = new System.Drawing.Point(12, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(360, 1);
            this.panel5.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(374, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(31, 363);
            this.panel1.TabIndex = 0;
            // 
            // NewMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(384, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.AddFile);
            this.Controls.Add(this.SendingMailResult);
            this.Controls.Add(this.SendNewMailButton);
            this.Controls.Add(this.NewMailText);
            this.Controls.Add(this.DisplayedName);
            this.Controls.Add(this.NewMailSubject);
            this.Controls.Add(this.NewMailAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewMailForm";
            this.Text = "New Mail";
            this.Load += new System.EventHandler(this.NewMailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendNewMailButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewMailAddress;
        private System.Windows.Forms.TextBox NewMailSubject;
        private System.Windows.Forms.TextBox NewMailText;
        private System.Windows.Forms.TextBox DisplayedName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SendingMailResult;
        private System.Windows.Forms.Button AddFile;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
    }
}