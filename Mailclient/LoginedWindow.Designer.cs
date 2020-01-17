namespace Mailclient
{
    partial class LoginedWindow
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
            this.components = new System.ComponentModel.Container();
            this.SlideMenu = new System.Windows.Forms.Panel();
            this.InboxBtn = new System.Windows.Forms.Button();
            this.SendBtn = new System.Windows.Forms.Button();
            this.SpamBtn = new System.Windows.Forms.Button();
            this.NewMailButton = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.TopPnl = new System.Windows.Forms.Panel();
            this.ToEndBtn = new System.Windows.Forms.Button();
            this.ToBeginBtn = new System.Windows.Forms.Button();
            this.CurrentPageLb = new System.Windows.Forms.Label();
            this.PrevPageBtn = new System.Windows.Forms.Button();
            this.NextPageBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MessagesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SlideTimer = new System.Windows.Forms.Timer(this.components);
            this.SlideMenu.SuspendLayout();
            this.TopPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SlideMenu
            // 
            this.SlideMenu.Controls.Add(this.InboxBtn);
            this.SlideMenu.Controls.Add(this.SendBtn);
            this.SlideMenu.Controls.Add(this.SpamBtn);
            this.SlideMenu.Controls.Add(this.NewMailButton);
            this.SlideMenu.Controls.Add(this.RefreshBtn);
            this.SlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlideMenu.Location = new System.Drawing.Point(0, 0);
            this.SlideMenu.Name = "SlideMenu";
            this.SlideMenu.Size = new System.Drawing.Size(0, 576);
            this.SlideMenu.TabIndex = 1;
            // 
            // InboxBtn
            // 
            this.InboxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InboxBtn.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InboxBtn.ForeColor = System.Drawing.Color.White;
            this.InboxBtn.Location = new System.Drawing.Point(14, 103);
            this.InboxBtn.Name = "InboxBtn";
            this.InboxBtn.Size = new System.Drawing.Size(140, 24);
            this.InboxBtn.TabIndex = 3;
            this.InboxBtn.Text = "Входящие";
            this.InboxBtn.UseVisualStyleBackColor = true;
            this.InboxBtn.Click += new System.EventHandler(this.InboxBtn_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendBtn.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendBtn.ForeColor = System.Drawing.Color.White;
            this.SendBtn.Location = new System.Drawing.Point(14, 133);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(140, 24);
            this.SendBtn.TabIndex = 2;
            this.SendBtn.Text = "Отправленные";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // SpamBtn
            // 
            this.SpamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpamBtn.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpamBtn.ForeColor = System.Drawing.Color.White;
            this.SpamBtn.Location = new System.Drawing.Point(14, 164);
            this.SpamBtn.Name = "SpamBtn";
            this.SpamBtn.Size = new System.Drawing.Size(140, 24);
            this.SpamBtn.TabIndex = 1;
            this.SpamBtn.Text = "Важное";
            this.SpamBtn.UseVisualStyleBackColor = true;
            this.SpamBtn.Click += new System.EventHandler(this.SpamBtn_Click);
            // 
            // NewMailButton
            // 
            this.NewMailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewMailButton.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewMailButton.ForeColor = System.Drawing.Color.White;
            this.NewMailButton.Location = new System.Drawing.Point(14, 14);
            this.NewMailButton.Name = "NewMailButton";
            this.NewMailButton.Size = new System.Drawing.Size(140, 23);
            this.NewMailButton.TabIndex = 0;
            this.NewMailButton.Text = "Новое письмо";
            this.NewMailButton.UseVisualStyleBackColor = true;
            this.NewMailButton.Click += new System.EventHandler(this.NewMailButton_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshBtn.Location = new System.Drawing.Point(14, 44);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(140, 24);
            this.RefreshBtn.TabIndex = 0;
            this.RefreshBtn.Text = "Обновить";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // TopPnl
            // 
            this.TopPnl.Controls.Add(this.ToEndBtn);
            this.TopPnl.Controls.Add(this.ToBeginBtn);
            this.TopPnl.Controls.Add(this.CurrentPageLb);
            this.TopPnl.Controls.Add(this.PrevPageBtn);
            this.TopPnl.Controls.Add(this.NextPageBtn);
            this.TopPnl.Controls.Add(this.pictureBox1);
            this.TopPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPnl.Location = new System.Drawing.Point(0, 0);
            this.TopPnl.Name = "TopPnl";
            this.TopPnl.Size = new System.Drawing.Size(1228, 43);
            this.TopPnl.TabIndex = 2;
            // 
            // ToEndBtn
            // 
            this.ToEndBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToEndBtn.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToEndBtn.ForeColor = System.Drawing.Color.White;
            this.ToEndBtn.Location = new System.Drawing.Point(714, 12);
            this.ToEndBtn.Name = "ToEndBtn";
            this.ToEndBtn.Size = new System.Drawing.Size(87, 24);
            this.ToEndBtn.TabIndex = 6;
            this.ToEndBtn.Text = "В конец";
            this.ToEndBtn.UseVisualStyleBackColor = true;
            this.ToEndBtn.Click += new System.EventHandler(this.ToEndBtn_Click);
            // 
            // ToBeginBtn
            // 
            this.ToBeginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToBeginBtn.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToBeginBtn.ForeColor = System.Drawing.Color.White;
            this.ToBeginBtn.Location = new System.Drawing.Point(808, 12);
            this.ToBeginBtn.Name = "ToBeginBtn";
            this.ToBeginBtn.Size = new System.Drawing.Size(87, 24);
            this.ToBeginBtn.TabIndex = 5;
            this.ToBeginBtn.Text = "В начало";
            this.ToBeginBtn.UseVisualStyleBackColor = true;
            this.ToBeginBtn.Click += new System.EventHandler(this.ToBeginBtn_Click);
            // 
            // CurrentPageLb
            // 
            this.CurrentPageLb.AutoSize = true;
            this.CurrentPageLb.ForeColor = System.Drawing.Color.White;
            this.CurrentPageLb.Location = new System.Drawing.Point(1002, 17);
            this.CurrentPageLb.Name = "CurrentPageLb";
            this.CurrentPageLb.Size = new System.Drawing.Size(14, 14);
            this.CurrentPageLb.TabIndex = 4;
            this.CurrentPageLb.Text = "1";
            // 
            // PrevPageBtn
            // 
            this.PrevPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevPageBtn.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrevPageBtn.ForeColor = System.Drawing.Color.White;
            this.PrevPageBtn.Location = new System.Drawing.Point(903, 12);
            this.PrevPageBtn.Name = "PrevPageBtn";
            this.PrevPageBtn.Size = new System.Drawing.Size(87, 24);
            this.PrevPageBtn.TabIndex = 3;
            this.PrevPageBtn.Text = "<<";
            this.PrevPageBtn.UseVisualStyleBackColor = true;
            this.PrevPageBtn.Click += new System.EventHandler(this.PrevPageBtn_Click);
            // 
            // NextPageBtn
            // 
            this.NextPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPageBtn.ForeColor = System.Drawing.Color.White;
            this.NextPageBtn.Location = new System.Drawing.Point(1113, 12);
            this.NextPageBtn.Name = "NextPageBtn";
            this.NextPageBtn.Size = new System.Drawing.Size(87, 24);
            this.NextPageBtn.TabIndex = 2;
            this.NextPageBtn.Text = ">>";
            this.NextPageBtn.UseVisualStyleBackColor = true;
            this.NextPageBtn.Click += new System.EventHandler(this.NextPageBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mailclient.Properties.Resources.addition2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 43);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.MessagesListView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1228, 576);
            this.panel3.TabIndex = 3;
            // 
            // MessagesListView
            // 
            this.MessagesListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.MessagesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.MessagesListView.ForeColor = System.Drawing.Color.White;
            this.MessagesListView.FullRowSelect = true;
            this.MessagesListView.HideSelection = false;
            this.MessagesListView.Location = new System.Drawing.Point(0, 17);
            this.MessagesListView.Name = "MessagesListView";
            this.MessagesListView.Size = new System.Drawing.Size(1254, 559);
            this.MessagesListView.TabIndex = 1;
            this.MessagesListView.UseCompatibleStateImageBehavior = false;
            this.MessagesListView.View = System.Windows.Forms.View.Details;
            this.MessagesListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.MessagesListView_ColumnWidthChanging);
            this.MessagesListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.MessagesListView_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Дата";
            this.columnHeader1.Width = 127;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Отправитель";
            this.columnHeader2.Width = 315;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Тема";
            this.columnHeader3.Width = 591;
            // 
            // SlideTimer
            // 
            this.SlideTimer.Interval = 10;
            this.SlideTimer.Tick += new System.EventHandler(this.SlideTimer_Tick);
            // 
            // LoginedWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 576);
            this.Controls.Add(this.TopPnl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SlideMenu);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginedWindow";
            this.Text = "LoginedClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginedWindow_FormClosing);
            this.Load += new System.EventHandler(this.LoginedWindow_Load);
            this.SlideMenu.ResumeLayout(false);
            this.TopPnl.ResumeLayout(false);
            this.TopPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SlideMenu;
        private System.Windows.Forms.Panel TopPnl;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer SlideTimer;
        private System.Windows.Forms.ListView MessagesListView;
        private System.Windows.Forms.Button NewMailButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CurrentPageLb;
        private System.Windows.Forms.Button PrevPageBtn;
        private System.Windows.Forms.Button NextPageBtn;
        private System.Windows.Forms.Button ToEndBtn;
        private System.Windows.Forms.Button ToBeginBtn;
        protected System.Windows.Forms.ColumnHeader columnHeader1;
        protected System.Windows.Forms.ColumnHeader columnHeader2;
        protected System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button InboxBtn;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Button SpamBtn;
    }
}