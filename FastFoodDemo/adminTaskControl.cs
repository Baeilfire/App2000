using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class adminTaskControl : UserControl
    {
        public adminTaskControl()
        {
            InitializeComponent();
            addNewAdminControl1.Visible = false;
            editAdminControl1.Visible = false;
        }

        private void addNewAdminButton_Click(object sender, EventArgs e)
        {
            addNewAdminControl1.Visible = true;
            editAdminControl1.Visible = false;
        }

        private void editAdminButton_Click(object sender, EventArgs e)
        {
            editAdminControl1.Visible = true;
            addNewAdminControl1.Visible = false;
        }

        private void removeAdminButton_Click(object sender, EventArgs e)
        {

        }
    }
}
