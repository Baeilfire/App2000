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
    public partial class EditAdminControl : UserControl
    {
        public EditAdminControl()
        {
            InitializeComponent();
            showUserInfoPanel.Visible = false;
            showUserInfoPanel.Visible = false;
            userNameLabelEdit.Visible = false;
            userNameLabelEdit.Visible = false;

        }

        private void submitUserIdButton_Click(object sender, EventArgs e)
        {
            if(showUserInfoPanel.Visible == false)
            {
                showPanelInfo(showUserInfoPanel);
            }
        }

        private void showPanelInfo(Panel showUserInfoPanel)
        {
            showUserInfoPanel.Visible = true;
        }

        private void hidePanelInfo()
        {
            showUserInfoPanel.Visible = false;
        }

        private void editUsernameButton_Click(object sender, EventArgs e)
        {
            if(editInfo1.Visible == false)
            {
                showEditInfo();
                showUsernameLabel();
            }
        }

        private void editEmailButton_Click(object sender, EventArgs e)
        {
            if (editInfo1.Visible == false)
            {
                showEditInfo();
                showEmailLabel();
            }
        }

        private void showEditInfo()
        {
            editInfo1.Visible = true;
        }

        private void hideEditInfo()
        {
            editInfo1.Visible = false;
        }

        private void showEmailLabel()
        {
            editEmaillabel.Visible = true;
        }

        private void hideEmailLabel()
        {
            editEmaillabel.Visible = false;
        }

        private void showUsernameLabel()
        {
            userNameLabelEdit.Visible = true;
        }

        private void hideUsernameLabel()
        {
            userNameLabelEdit.Visible = false;
        }

        private void editEmailButtonUser_Click(object sender, EventArgs e)
        {
            hideEditInfo();
            hideEmailLabel();
            hideUsernameLabel();
        }
    }
}
