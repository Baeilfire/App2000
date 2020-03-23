namespace FastFoodDemo
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainPanelSettingSubmenu = new System.Windows.Forms.Panel();
            this.mainSubSettingsLogOutButton = new System.Windows.Forms.Button();
            this.mainSubSettingSecurityButton = new System.Windows.Forms.Button();
            this.mainSubSettingAccountButton = new System.Windows.Forms.Button();
            this.mainSettingsMenuButton = new System.Windows.Forms.Button();
            this.mainSongsButton = new System.Windows.Forms.Button();
            this.mainAdminButton = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.mainHelpButton = new System.Windows.Forms.Button();
            this.mainUsersButton = new System.Windows.Forms.Button();
            this.mainHomeButton = new System.Windows.Forms.Button();
            this.mainTopPanel = new System.Windows.Forms.Panel();
            this.mainPanelTopLogo = new System.Windows.Forms.Panel();
            this.mainPictureLogo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mainTopExit = new System.Windows.Forms.Button();
            this.mainTopNotification = new System.Windows.Forms.Button();
            this.mainTopInstagram = new System.Windows.Forms.Button();
            this.mainTopTwitter = new System.Windows.Forms.Button();
            this.mainTopFacebook = new System.Windows.Forms.Button();
            this.settingsControlSecurity = new FastFoodDemo.SettingsControl2();
            this.settingsControlAccount = new FastFoodDemo.SettingsControl();
            this.mySecondCustmControl1 = new FastFoodDemo.MySecondCustmControl();
            this.firstCustomControl1 = new FastFoodDemo.FirstCustomControl();
            this.adminTaskControl1 = new FastFoodDemo.adminTaskControl();
            this.mainPanel.SuspendLayout();
            this.mainPanelSettingSubmenu.SuspendLayout();
            this.mainPanelTopLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.mainPanel.Controls.Add(this.mainPanelSettingSubmenu);
            this.mainPanel.Controls.Add(this.mainSettingsMenuButton);
            this.mainPanel.Controls.Add(this.mainSongsButton);
            this.mainPanel.Controls.Add(this.mainAdminButton);
            this.mainPanel.Controls.Add(this.SidePanel);
            this.mainPanel.Controls.Add(this.mainHelpButton);
            this.mainPanel.Controls.Add(this.mainUsersButton);
            this.mainPanel.Controls.Add(this.mainHomeButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(209, 615);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // mainPanelSettingSubmenu
            // 
            this.mainPanelSettingSubmenu.Controls.Add(this.mainSubSettingsLogOutButton);
            this.mainPanelSettingSubmenu.Controls.Add(this.mainSubSettingSecurityButton);
            this.mainPanelSettingSubmenu.Controls.Add(this.mainSubSettingAccountButton);
            this.mainPanelSettingSubmenu.Location = new System.Drawing.Point(0, 269);
            this.mainPanelSettingSubmenu.Name = "mainPanelSettingSubmenu";
            this.mainPanelSettingSubmenu.Size = new System.Drawing.Size(209, 161);
            this.mainPanelSettingSubmenu.TabIndex = 8;
            // 
            // mainSubSettingsLogOutButton
            // 
            this.mainSubSettingsLogOutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainSubSettingsLogOutButton.FlatAppearance.BorderSize = 0;
            this.mainSubSettingsLogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainSubSettingsLogOutButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainSubSettingsLogOutButton.ForeColor = System.Drawing.SystemColors.Control;
            this.mainSubSettingsLogOutButton.Location = new System.Drawing.Point(0, 88);
            this.mainSubSettingsLogOutButton.Name = "mainSubSettingsLogOutButton";
            this.mainSubSettingsLogOutButton.Size = new System.Drawing.Size(209, 44);
            this.mainSubSettingsLogOutButton.TabIndex = 10;
            this.mainSubSettingsLogOutButton.Text = "Log Out";
            this.mainSubSettingsLogOutButton.UseVisualStyleBackColor = true;
            this.mainSubSettingsLogOutButton.Click += new System.EventHandler(this.mainSubSettingsLogOutButton_Click);
            // 
            // mainSubSettingSecurityButton
            // 
            this.mainSubSettingSecurityButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainSubSettingSecurityButton.FlatAppearance.BorderSize = 0;
            this.mainSubSettingSecurityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainSubSettingSecurityButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainSubSettingSecurityButton.ForeColor = System.Drawing.SystemColors.Control;
            this.mainSubSettingSecurityButton.Location = new System.Drawing.Point(0, 44);
            this.mainSubSettingSecurityButton.Name = "mainSubSettingSecurityButton";
            this.mainSubSettingSecurityButton.Size = new System.Drawing.Size(209, 44);
            this.mainSubSettingSecurityButton.TabIndex = 9;
            this.mainSubSettingSecurityButton.Text = "Security";
            this.mainSubSettingSecurityButton.UseVisualStyleBackColor = true;
            this.mainSubSettingSecurityButton.Click += new System.EventHandler(this.mainSubSettingSecurityButton_Click);
            // 
            // mainSubSettingAccountButton
            // 
            this.mainSubSettingAccountButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainSubSettingAccountButton.FlatAppearance.BorderSize = 0;
            this.mainSubSettingAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainSubSettingAccountButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainSubSettingAccountButton.ForeColor = System.Drawing.SystemColors.Control;
            this.mainSubSettingAccountButton.Location = new System.Drawing.Point(0, 0);
            this.mainSubSettingAccountButton.Name = "mainSubSettingAccountButton";
            this.mainSubSettingAccountButton.Size = new System.Drawing.Size(209, 44);
            this.mainSubSettingAccountButton.TabIndex = 8;
            this.mainSubSettingAccountButton.Text = "Account";
            this.mainSubSettingAccountButton.UseVisualStyleBackColor = true;
            this.mainSubSettingAccountButton.Click += new System.EventHandler(this.mainSubSettingAccountButton_Click_1);
            // 
            // mainSettingsMenuButton
            // 
            this.mainSettingsMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainSettingsMenuButton.FlatAppearance.BorderSize = 0;
            this.mainSettingsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainSettingsMenuButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainSettingsMenuButton.ForeColor = System.Drawing.Color.White;
            this.mainSettingsMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("mainSettingsMenuButton.Image")));
            this.mainSettingsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainSettingsMenuButton.Location = new System.Drawing.Point(0, 216);
            this.mainSettingsMenuButton.Name = "mainSettingsMenuButton";
            this.mainSettingsMenuButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.mainSettingsMenuButton.Size = new System.Drawing.Size(209, 54);
            this.mainSettingsMenuButton.TabIndex = 7;
            this.mainSettingsMenuButton.Text = "       Settings";
            this.mainSettingsMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainSettingsMenuButton.UseVisualStyleBackColor = true;
            this.mainSettingsMenuButton.Click += new System.EventHandler(this.mainSettingsMenuButton_Click);
            // 
            // mainSongsButton
            // 
            this.mainSongsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainSongsButton.FlatAppearance.BorderSize = 0;
            this.mainSongsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainSongsButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainSongsButton.ForeColor = System.Drawing.Color.White;
            this.mainSongsButton.Image = ((System.Drawing.Image)(resources.GetObject("mainSongsButton.Image")));
            this.mainSongsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainSongsButton.Location = new System.Drawing.Point(0, 162);
            this.mainSongsButton.Name = "mainSongsButton";
            this.mainSongsButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.mainSongsButton.Size = new System.Drawing.Size(209, 54);
            this.mainSongsButton.TabIndex = 6;
            this.mainSongsButton.Text = "       Songs";
            this.mainSongsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainSongsButton.UseVisualStyleBackColor = true;
            // 
            // mainAdminButton
            // 
            this.mainAdminButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainAdminButton.FlatAppearance.BorderSize = 0;
            this.mainAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainAdminButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainAdminButton.ForeColor = System.Drawing.Color.White;
            this.mainAdminButton.Image = ((System.Drawing.Image)(resources.GetObject("mainAdminButton.Image")));
            this.mainAdminButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainAdminButton.Location = new System.Drawing.Point(0, 108);
            this.mainAdminButton.Name = "mainAdminButton";
            this.mainAdminButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.mainAdminButton.Size = new System.Drawing.Size(209, 54);
            this.mainAdminButton.TabIndex = 5;
            this.mainAdminButton.Text = "       Admin";
            this.mainAdminButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainAdminButton.UseVisualStyleBackColor = true;
            this.mainAdminButton.Click += new System.EventHandler(this.mainAdminButton_Click_1);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(4, 54);
            this.SidePanel.TabIndex = 4;
            // 
            // mainHelpButton
            // 
            this.mainHelpButton.FlatAppearance.BorderSize = 0;
            this.mainHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainHelpButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHelpButton.ForeColor = System.Drawing.Color.White;
            this.mainHelpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainHelpButton.Location = new System.Drawing.Point(3, 546);
            this.mainHelpButton.Name = "mainHelpButton";
            this.mainHelpButton.Size = new System.Drawing.Size(36, 34);
            this.mainHelpButton.TabIndex = 4;
            this.mainHelpButton.Text = "?";
            this.mainHelpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainHelpButton.UseVisualStyleBackColor = true;
            this.mainHelpButton.Click += new System.EventHandler(this.mainHelpButton_Click);
            // 
            // mainUsersButton
            // 
            this.mainUsersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainUsersButton.FlatAppearance.BorderSize = 0;
            this.mainUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainUsersButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainUsersButton.ForeColor = System.Drawing.Color.White;
            this.mainUsersButton.Image = ((System.Drawing.Image)(resources.GetObject("mainUsersButton.Image")));
            this.mainUsersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainUsersButton.Location = new System.Drawing.Point(0, 54);
            this.mainUsersButton.Name = "mainUsersButton";
            this.mainUsersButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.mainUsersButton.Size = new System.Drawing.Size(209, 54);
            this.mainUsersButton.TabIndex = 4;
            this.mainUsersButton.Text = "       Users";
            this.mainUsersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainUsersButton.UseVisualStyleBackColor = true;
            this.mainUsersButton.Click += new System.EventHandler(this.mainUsersButton_Click);
            // 
            // mainHomeButton
            // 
            this.mainHomeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainHomeButton.FlatAppearance.BorderSize = 0;
            this.mainHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainHomeButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHomeButton.ForeColor = System.Drawing.Color.White;
            this.mainHomeButton.Image = ((System.Drawing.Image)(resources.GetObject("mainHomeButton.Image")));
            this.mainHomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainHomeButton.Location = new System.Drawing.Point(0, 0);
            this.mainHomeButton.Name = "mainHomeButton";
            this.mainHomeButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.mainHomeButton.Size = new System.Drawing.Size(209, 54);
            this.mainHomeButton.TabIndex = 4;
            this.mainHomeButton.Text = "       Home";
            this.mainHomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainHomeButton.UseVisualStyleBackColor = true;
            this.mainHomeButton.Click += new System.EventHandler(this.mainHomeButton_Click);
            // 
            // mainTopPanel
            // 
            this.mainTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.mainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTopPanel.Location = new System.Drawing.Point(209, 0);
            this.mainTopPanel.Name = "mainTopPanel";
            this.mainTopPanel.Size = new System.Drawing.Size(846, 10);
            this.mainTopPanel.TabIndex = 1;
            this.mainTopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainTopPanel_Paint);
            // 
            // mainPanelTopLogo
            // 
            this.mainPanelTopLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.mainPanelTopLogo.Controls.Add(this.mainPictureLogo);
            this.mainPanelTopLogo.Location = new System.Drawing.Point(243, 0);
            this.mainPanelTopLogo.Name = "mainPanelTopLogo";
            this.mainPanelTopLogo.Size = new System.Drawing.Size(111, 143);
            this.mainPanelTopLogo.TabIndex = 2;
            // 
            // mainPictureLogo
            // 
            this.mainPictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("mainPictureLogo.Image")));
            this.mainPictureLogo.Location = new System.Drawing.Point(-121, -31);
            this.mainPictureLogo.Name = "mainPictureLogo";
            this.mainPictureLogo.Size = new System.Drawing.Size(357, 294);
            this.mainPictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPictureLogo.TabIndex = 4;
            this.mainPictureLogo.TabStop = false;
            this.mainPictureLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(360, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "PROTOMUSIC";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mainTopExit
            // 
            this.mainTopExit.FlatAppearance.BorderSize = 0;
            this.mainTopExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainTopExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTopExit.ForeColor = System.Drawing.Color.White;
            this.mainTopExit.Image = ((System.Drawing.Image)(resources.GetObject("mainTopExit.Image")));
            this.mainTopExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainTopExit.Location = new System.Drawing.Point(977, 19);
            this.mainTopExit.Name = "mainTopExit";
            this.mainTopExit.Size = new System.Drawing.Size(32, 35);
            this.mainTopExit.TabIndex = 4;
            this.mainTopExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainTopExit.UseVisualStyleBackColor = true;
            this.mainTopExit.Click += new System.EventHandler(this.mainTopExit_Click);
            // 
            // mainTopNotification
            // 
            this.mainTopNotification.FlatAppearance.BorderSize = 0;
            this.mainTopNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainTopNotification.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTopNotification.ForeColor = System.Drawing.Color.White;
            this.mainTopNotification.Image = ((System.Drawing.Image)(resources.GetObject("mainTopNotification.Image")));
            this.mainTopNotification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainTopNotification.Location = new System.Drawing.Point(874, 20);
            this.mainTopNotification.Name = "mainTopNotification";
            this.mainTopNotification.Size = new System.Drawing.Size(32, 35);
            this.mainTopNotification.TabIndex = 4;
            this.mainTopNotification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainTopNotification.UseVisualStyleBackColor = true;
            this.mainTopNotification.Click += new System.EventHandler(this.mainTopNotification_Click);
            // 
            // mainTopInstagram
            // 
            this.mainTopInstagram.FlatAppearance.BorderSize = 0;
            this.mainTopInstagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainTopInstagram.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTopInstagram.ForeColor = System.Drawing.Color.White;
            this.mainTopInstagram.Image = ((System.Drawing.Image)(resources.GetObject("mainTopInstagram.Image")));
            this.mainTopInstagram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainTopInstagram.Location = new System.Drawing.Point(761, 20);
            this.mainTopInstagram.Name = "mainTopInstagram";
            this.mainTopInstagram.Size = new System.Drawing.Size(36, 34);
            this.mainTopInstagram.TabIndex = 4;
            this.mainTopInstagram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainTopInstagram.UseVisualStyleBackColor = true;
            this.mainTopInstagram.Click += new System.EventHandler(this.mainTopInstagram_Click);
            // 
            // mainTopTwitter
            // 
            this.mainTopTwitter.FlatAppearance.BorderSize = 0;
            this.mainTopTwitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainTopTwitter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTopTwitter.ForeColor = System.Drawing.Color.White;
            this.mainTopTwitter.Image = ((System.Drawing.Image)(resources.GetObject("mainTopTwitter.Image")));
            this.mainTopTwitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainTopTwitter.Location = new System.Drawing.Point(719, 20);
            this.mainTopTwitter.Name = "mainTopTwitter";
            this.mainTopTwitter.Size = new System.Drawing.Size(36, 34);
            this.mainTopTwitter.TabIndex = 4;
            this.mainTopTwitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainTopTwitter.UseVisualStyleBackColor = true;
            this.mainTopTwitter.Click += new System.EventHandler(this.mainTopTwitter_Click);
            // 
            // mainTopFacebook
            // 
            this.mainTopFacebook.FlatAppearance.BorderSize = 0;
            this.mainTopFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainTopFacebook.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTopFacebook.ForeColor = System.Drawing.Color.White;
            this.mainTopFacebook.Image = ((System.Drawing.Image)(resources.GetObject("mainTopFacebook.Image")));
            this.mainTopFacebook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainTopFacebook.Location = new System.Drawing.Point(677, 20);
            this.mainTopFacebook.Name = "mainTopFacebook";
            this.mainTopFacebook.Size = new System.Drawing.Size(36, 34);
            this.mainTopFacebook.TabIndex = 4;
            this.mainTopFacebook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainTopFacebook.UseVisualStyleBackColor = true;
            this.mainTopFacebook.Click += new System.EventHandler(this.mainTopFacebook_Click);
            // 
            // settingsControlSecurity
            // 
            this.settingsControlSecurity.Location = new System.Drawing.Point(215, 149);
            this.settingsControlSecurity.Name = "settingsControlSecurity";
            this.settingsControlSecurity.Size = new System.Drawing.Size(817, 406);
            this.settingsControlSecurity.TabIndex = 11;
            // 
            // settingsControlAccount
            // 
            this.settingsControlAccount.Location = new System.Drawing.Point(209, 149);
            this.settingsControlAccount.Name = "settingsControlAccount";
            this.settingsControlAccount.Size = new System.Drawing.Size(817, 406);
            this.settingsControlAccount.TabIndex = 11;
            // 
            // mySecondCustmControl1
            // 
            this.mySecondCustmControl1.Location = new System.Drawing.Point(209, 157);
            this.mySecondCustmControl1.Name = "mySecondCustmControl1";
            this.mySecondCustmControl1.Size = new System.Drawing.Size(818, 406);
            this.mySecondCustmControl1.TabIndex = 6;
            this.mySecondCustmControl1.Load += new System.EventHandler(this.mySecondCustmControl1_Load);
            // 
            // firstCustomControl1
            // 
            this.firstCustomControl1.Location = new System.Drawing.Point(209, 157);
            this.firstCustomControl1.Name = "firstCustomControl1";
            this.firstCustomControl1.Size = new System.Drawing.Size(805, 423);
            this.firstCustomControl1.TabIndex = 5;
            this.firstCustomControl1.Load += new System.EventHandler(this.firstCustomControl1_Load);
            // 
            // adminTaskControl1
            // 
            this.adminTaskControl1.Location = new System.Drawing.Point(215, 149);
            this.adminTaskControl1.Name = "adminTaskControl1";
            this.adminTaskControl1.Size = new System.Drawing.Size(817, 406);
            this.adminTaskControl1.TabIndex = 12;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1055, 615);
            this.Controls.Add(this.adminTaskControl1);
            this.Controls.Add(this.settingsControlSecurity);
            this.Controls.Add(this.settingsControlAccount);
            this.Controls.Add(this.mySecondCustmControl1);
            this.Controls.Add(this.firstCustomControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mainTopExit);
            this.Controls.Add(this.mainTopNotification);
            this.Controls.Add(this.mainTopInstagram);
            this.Controls.Add(this.mainTopTwitter);
            this.Controls.Add(this.mainTopFacebook);
            this.Controls.Add(this.mainPanelTopLogo);
            this.Controls.Add(this.mainTopPanel);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanelSettingSubmenu.ResumeLayout(false);
            this.mainPanelTopLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button mainUsersButton;
        private System.Windows.Forms.Button mainHomeButton;
        private System.Windows.Forms.Panel mainTopPanel;
        private System.Windows.Forms.Panel mainPanelTopLogo;
        private System.Windows.Forms.PictureBox mainPictureLogo;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button mainHelpButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button mainTopFacebook;
        private System.Windows.Forms.Button mainTopTwitter;
        private System.Windows.Forms.Button mainTopInstagram;
        private System.Windows.Forms.Button mainTopNotification;
        private System.Windows.Forms.Button mainTopExit;
        private FirstCustomControl firstCustomControl1;
        private MySecondCustmControl mySecondCustmControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button mainSettingsMenuButton;
        private System.Windows.Forms.Button mainSongsButton;
        private System.Windows.Forms.Button mainAdminButton;
        private System.Windows.Forms.Panel mainPanelSettingSubmenu;
        private System.Windows.Forms.Button mainSubSettingsLogOutButton;
        private System.Windows.Forms.Button mainSubSettingSecurityButton;
        private System.Windows.Forms.Button mainSubSettingAccountButton;
        private SettingsControl settingsControlAccount;
        private SettingsControl2 settingsControlSecurity;
        private adminTaskControl adminTaskControl1;
    }
}

