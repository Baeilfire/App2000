namespace FastFoodDemo
{
    partial class adminTaskControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminTaskControl));
            this.label1 = new System.Windows.Forms.Label();
            this.removeAdminButton = new System.Windows.Forms.Button();
            this.editAdminButton = new System.Windows.Forms.Button();
            this.addNewAdminButton = new System.Windows.Forms.Button();
            this.addNewAdminControl1 = new FastFoodDemo.AddNewAdminControl();
            this.editAdminControl1 = new FastFoodDemo.EditAdminControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(250, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Administrative Tasks";
            // 
            // removeAdminButton
            // 
            this.removeAdminButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.removeAdminButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAdminButton.Image = ((System.Drawing.Image)(resources.GetObject("removeAdminButton.Image")));
            this.removeAdminButton.Location = new System.Drawing.Point(530, 107);
            this.removeAdminButton.Name = "removeAdminButton";
            this.removeAdminButton.Size = new System.Drawing.Size(231, 194);
            this.removeAdminButton.TabIndex = 10;
            this.removeAdminButton.Text = "Remove Admin";
            this.removeAdminButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.removeAdminButton.UseVisualStyleBackColor = false;
            this.removeAdminButton.Click += new System.EventHandler(this.removeAdminButton_Click);
            // 
            // editAdminButton
            // 
            this.editAdminButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.editAdminButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAdminButton.Image = ((System.Drawing.Image)(resources.GetObject("editAdminButton.Image")));
            this.editAdminButton.Location = new System.Drawing.Point(293, 107);
            this.editAdminButton.Name = "editAdminButton";
            this.editAdminButton.Size = new System.Drawing.Size(231, 194);
            this.editAdminButton.TabIndex = 9;
            this.editAdminButton.Text = "Edit Admin";
            this.editAdminButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.editAdminButton.UseVisualStyleBackColor = false;
            this.editAdminButton.Click += new System.EventHandler(this.editAdminButton_Click);
            // 
            // addNewAdminButton
            // 
            this.addNewAdminButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addNewAdminButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewAdminButton.Image = ((System.Drawing.Image)(resources.GetObject("addNewAdminButton.Image")));
            this.addNewAdminButton.Location = new System.Drawing.Point(56, 107);
            this.addNewAdminButton.Name = "addNewAdminButton";
            this.addNewAdminButton.Size = new System.Drawing.Size(231, 194);
            this.addNewAdminButton.TabIndex = 8;
            this.addNewAdminButton.Text = "Add New Admin";
            this.addNewAdminButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addNewAdminButton.UseVisualStyleBackColor = false;
            this.addNewAdminButton.Click += new System.EventHandler(this.addNewAdminButton_Click);
            // 
            // addNewAdminControl1
            // 
            this.addNewAdminControl1.Location = new System.Drawing.Point(0, 0);
            this.addNewAdminControl1.Name = "addNewAdminControl1";
            this.addNewAdminControl1.Size = new System.Drawing.Size(817, 406);
            this.addNewAdminControl1.TabIndex = 11;
            // 
            // editAdminControl1
            // 
            this.editAdminControl1.Location = new System.Drawing.Point(3, 0);
            this.editAdminControl1.Name = "editAdminControl1";
            this.editAdminControl1.Size = new System.Drawing.Size(817, 406);
            this.editAdminControl1.TabIndex = 12;
            // 
            // adminTaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editAdminControl1);
            this.Controls.Add(this.addNewAdminControl1);
            this.Controls.Add(this.removeAdminButton);
            this.Controls.Add(this.editAdminButton);
            this.Controls.Add(this.addNewAdminButton);
            this.Controls.Add(this.label1);
            this.Name = "adminTaskControl";
            this.Size = new System.Drawing.Size(817, 406);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeAdminButton;
        private System.Windows.Forms.Button editAdminButton;
        private System.Windows.Forms.Button addNewAdminButton;
        private System.Windows.Forms.Label label1;
        private AddNewAdminControl addNewAdminControl1;
        private EditAdminControl editAdminControl1;
    }
}
