namespace FastFoodDemo
{
    partial class EditAdminControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.dataGridViewUserId = new System.Windows.Forms.DataGridView();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.submitUserIdButton = new System.Windows.Forms.Button();
            this.showUserInfoPanel = new System.Windows.Forms.Panel();
            this.editInfo1 = new System.Windows.Forms.Panel();
            this.editEmailButtonUser = new System.Windows.Forms.Button();
            this.editEmaillabel = new System.Windows.Forms.Label();
            this.newInfoTextBox = new System.Windows.Forms.TextBox();
            this.editEmailButton = new System.Windows.Forms.Button();
            this.editUsernameButton = new System.Windows.Forms.Button();
            this.emailDataGrid = new System.Windows.Forms.DataGridView();
            this.usernameDataGrid = new System.Windows.Forms.DataGridView();
            this.UserIdDataGrid = new System.Windows.Forms.DataGridView();
            this.selectedUserIdLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.userNameLabelEdit = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserId)).BeginInit();
            this.showUserInfoPanel.SuspendLayout();
            this.editInfo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIdDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.title.Location = new System.Drawing.Point(316, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(167, 33);
            this.title.TabIndex = 9;
            this.title.Text = "Edit Admins";
            // 
            // dataGridViewUserId
            // 
            this.dataGridViewUserId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserId.Location = new System.Drawing.Point(48, 69);
            this.dataGridViewUserId.Name = "dataGridViewUserId";
            this.dataGridViewUserId.Size = new System.Drawing.Size(108, 271);
            this.dataGridViewUserId.TabIndex = 10;
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLabel.Location = new System.Drawing.Point(69, 44);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(66, 22);
            this.userIdLabel.TabIndex = 11;
            this.userIdLabel.Text = "UserID";
            // 
            // submitUserIdButton
            // 
            this.submitUserIdButton.Location = new System.Drawing.Point(50, 346);
            this.submitUserIdButton.Name = "submitUserIdButton";
            this.submitUserIdButton.Size = new System.Drawing.Size(102, 30);
            this.submitUserIdButton.TabIndex = 13;
            this.submitUserIdButton.Text = "Submit";
            this.submitUserIdButton.UseVisualStyleBackColor = true;
            this.submitUserIdButton.Click += new System.EventHandler(this.submitUserIdButton_Click);
            // 
            // showUserInfoPanel
            // 
            this.showUserInfoPanel.Controls.Add(this.editInfo1);
            this.showUserInfoPanel.Controls.Add(this.editEmailButton);
            this.showUserInfoPanel.Controls.Add(this.editUsernameButton);
            this.showUserInfoPanel.Controls.Add(this.emailDataGrid);
            this.showUserInfoPanel.Controls.Add(this.usernameDataGrid);
            this.showUserInfoPanel.Controls.Add(this.UserIdDataGrid);
            this.showUserInfoPanel.Controls.Add(this.selectedUserIdLabel);
            this.showUserInfoPanel.Controls.Add(this.emailLabel);
            this.showUserInfoPanel.Controls.Add(this.usernameLabel);
            this.showUserInfoPanel.Location = new System.Drawing.Point(196, 69);
            this.showUserInfoPanel.Name = "showUserInfoPanel";
            this.showUserInfoPanel.Size = new System.Drawing.Size(563, 307);
            this.showUserInfoPanel.TabIndex = 14;
            // 
            // editInfo1
            // 
            this.editInfo1.Controls.Add(this.userNameLabelEdit);
            this.editInfo1.Controls.Add(this.editEmailButtonUser);
            this.editInfo1.Controls.Add(this.editEmaillabel);
            this.editInfo1.Controls.Add(this.newInfoTextBox);
            this.editInfo1.Location = new System.Drawing.Point(51, 204);
            this.editInfo1.Name = "editInfo1";
            this.editInfo1.Size = new System.Drawing.Size(497, 100);
            this.editInfo1.TabIndex = 34;
            // 
            // editEmailButtonUser
            // 
            this.editEmailButtonUser.Location = new System.Drawing.Point(317, 67);
            this.editEmailButtonUser.Name = "editEmailButtonUser";
            this.editEmailButtonUser.Size = new System.Drawing.Size(102, 30);
            this.editEmailButtonUser.TabIndex = 16;
            this.editEmailButtonUser.Text = "Submit";
            this.editEmailButtonUser.UseVisualStyleBackColor = true;
            this.editEmailButtonUser.Click += new System.EventHandler(this.editEmailButtonUser_Click);
            // 
            // editEmaillabel
            // 
            this.editEmaillabel.AutoSize = true;
            this.editEmaillabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.editEmaillabel.Location = new System.Drawing.Point(40, 47);
            this.editEmaillabel.Name = "editEmaillabel";
            this.editEmaillabel.Size = new System.Drawing.Size(54, 20);
            this.editEmaillabel.TabIndex = 34;
            this.editEmaillabel.Text = "Email: ";
            // 
            // newInfoTextBox
            // 
            this.newInfoTextBox.Location = new System.Drawing.Point(128, 47);
            this.newInfoTextBox.Name = "newInfoTextBox";
            this.newInfoTextBox.Size = new System.Drawing.Size(142, 20);
            this.newInfoTextBox.TabIndex = 25;
            // 
            // editEmailButton
            // 
            this.editEmailButton.Location = new System.Drawing.Point(430, 158);
            this.editEmailButton.Name = "editEmailButton";
            this.editEmailButton.Size = new System.Drawing.Size(75, 23);
            this.editEmailButton.TabIndex = 33;
            this.editEmailButton.Text = "Edit";
            this.editEmailButton.UseVisualStyleBackColor = true;
            this.editEmailButton.Click += new System.EventHandler(this.editEmailButton_Click);
            // 
            // editUsernameButton
            // 
            this.editUsernameButton.Location = new System.Drawing.Point(430, 104);
            this.editUsernameButton.Name = "editUsernameButton";
            this.editUsernameButton.Size = new System.Drawing.Size(75, 23);
            this.editUsernameButton.TabIndex = 32;
            this.editUsernameButton.Text = "Edit";
            this.editUsernameButton.UseVisualStyleBackColor = true;
            this.editUsernameButton.Click += new System.EventHandler(this.editUsernameButton_Click);
            // 
            // emailDataGrid
            // 
            this.emailDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emailDataGrid.Location = new System.Drawing.Point(179, 150);
            this.emailDataGrid.Name = "emailDataGrid";
            this.emailDataGrid.Size = new System.Drawing.Size(230, 33);
            this.emailDataGrid.TabIndex = 31;
            // 
            // usernameDataGrid
            // 
            this.usernameDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usernameDataGrid.Location = new System.Drawing.Point(179, 98);
            this.usernameDataGrid.Name = "usernameDataGrid";
            this.usernameDataGrid.Size = new System.Drawing.Size(230, 33);
            this.usernameDataGrid.TabIndex = 30;
            // 
            // UserIdDataGrid
            // 
            this.UserIdDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserIdDataGrid.Location = new System.Drawing.Point(179, 43);
            this.UserIdDataGrid.Name = "UserIdDataGrid";
            this.UserIdDataGrid.Size = new System.Drawing.Size(230, 33);
            this.UserIdDataGrid.TabIndex = 29;
            // 
            // selectedUserIdLabel
            // 
            this.selectedUserIdLabel.AutoSize = true;
            this.selectedUserIdLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedUserIdLabel.Location = new System.Drawing.Point(82, 49);
            this.selectedUserIdLabel.Name = "selectedUserIdLabel";
            this.selectedUserIdLabel.Size = new System.Drawing.Size(65, 20);
            this.selectedUserIdLabel.TabIndex = 28;
            this.selectedUserIdLabel.Text = "UserID: ";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.emailLabel.Location = new System.Drawing.Point(91, 158);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(54, 20);
            this.emailLabel.TabIndex = 27;
            this.emailLabel.Text = "Email: ";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.usernameLabel.Location = new System.Drawing.Point(57, 104);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(91, 20);
            this.usernameLabel.TabIndex = 26;
            this.usernameLabel.Text = "Username: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(684, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // userNameLabelEdit
            // 
            this.userNameLabelEdit.AutoSize = true;
            this.userNameLabelEdit.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.userNameLabelEdit.Location = new System.Drawing.Point(3, 45);
            this.userNameLabelEdit.Name = "userNameLabelEdit";
            this.userNameLabelEdit.Size = new System.Drawing.Size(91, 20);
            this.userNameLabelEdit.TabIndex = 35;
            this.userNameLabelEdit.Text = "Username: ";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(3, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // EditAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showUserInfoPanel);
            this.Controls.Add(this.submitUserIdButton);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.dataGridViewUserId);
            this.Controls.Add(this.title);
            this.Name = "EditAdminControl";
            this.Size = new System.Drawing.Size(817, 406);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserId)).EndInit();
            this.showUserInfoPanel.ResumeLayout(false);
            this.showUserInfoPanel.PerformLayout();
            this.editInfo1.ResumeLayout(false);
            this.editInfo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIdDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView dataGridViewUserId;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Button submitUserIdButton;
        private System.Windows.Forms.Panel showUserInfoPanel;
        private System.Windows.Forms.Label editEmaillabel;
        private System.Windows.Forms.Button editEmailButton;
        private System.Windows.Forms.Button editUsernameButton;
        private System.Windows.Forms.DataGridView emailDataGrid;
        private System.Windows.Forms.DataGridView usernameDataGrid;
        private System.Windows.Forms.DataGridView UserIdDataGrid;
        private System.Windows.Forms.Label selectedUserIdLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox newInfoTextBox;
        private System.Windows.Forms.Panel editInfo1;
        private System.Windows.Forms.Button editEmailButtonUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label userNameLabelEdit;
        private System.Windows.Forms.Button backButton;
    }
}
