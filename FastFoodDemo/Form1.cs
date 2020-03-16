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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customDesign();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }
        
        private void customDesign()
        {
            panelSettingSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSettingSubmenu.Visible == true)
                panelSettingSubmenu.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            mySecondCustmControl1.BringToFront();
        }
    
        private void button13_Click(object sender, EventArgs e)
        {
            Close();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            settingsControl31.BringToFront();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            showSubMenu(panelSettingSubmenu);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // egen kode for funksjon

            hideSubMenu();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            settingsControl1.BringToFront();

            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            settingsControl21.BringToFront();

            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSettingSubmenu);
        }

        private void buttonZoom()
        {
           
        }
    }
}
