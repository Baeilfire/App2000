using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
            customDesign();
            SidePanel.Height = mainHomeButton.Height;
            SidePanel.Top = mainHomeButton.Top;
            firstCustomControl1.BringToFront();
        }
        
        private void customDesign()
        {
            mainPanelSettingSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (mainPanelSettingSubmenu.Visible == true)
                mainPanelSettingSubmenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }       

        private void mainHomeButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = mainHomeButton.Height;
            SidePanel.Top = mainHomeButton.Top;
            firstCustomControl1.BringToFront();
        }

        private void mainUsersButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = mainUsersButton.Height;
            SidePanel.Top = mainUsersButton.Top;
            mySecondCustmControl1.BringToFront();
        }

        private void firstCustomControl1_Load(object sender, EventArgs e)
        {

        }

        private void mySecondCustmControl1_Load(object sender, EventArgs e)
        {

        }

        private void settingsControl31_Load(object sender, EventArgs e)
        {

        }

        private void mainTopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainAdminButton_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = mainAdminButton.Height;
            SidePanel.Top = mainAdminButton.Top;
            adminTaskControl1.BringToFront();
        }
        
        private void mainSongsButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = mainSongsButton.Height;
            SidePanel.Top = mainSongsButton.Top;
            showSubMenu(mainPanelSettingSubmenu);
        }

        private void mainSubSettingsLogOut_Click(object sender, EventArgs e)
        {
            // egen kode for funksjon

            hideSubMenu();
        }

        private void mainSubSettingAccountButton_Click_1(object sender, EventArgs e)
        {
            settingsControlAccount.BringToFront();

            hideSubMenu();
        }

        private void mainSubSettingSecurityButton_Click(object sender, EventArgs e)
        {
            settingsControlSecurity.BringToFront();

            hideSubMenu();
        }

        private void mainSettingsMenuButton_Click(object sender, EventArgs e)
        {
            showSubMenu(mainPanelSettingSubmenu);
        }

        private void mainSubSettingsLogOutButton_Click(object sender, EventArgs e)
        {

        }

        private void mainHelpButton_Click(object sender, EventArgs e)
        {

        }

        private void mainTopFacebook_Click(object sender, EventArgs e)
        {

        }

        private void mainTopTwitter_Click(object sender, EventArgs e)
        {

        }
        private void mainTopInstagram_Click(object sender, EventArgs e)
        {

        }

        private void mainTopNotification_Click(object sender, EventArgs e)
        {

        }
        private void mainTopExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
