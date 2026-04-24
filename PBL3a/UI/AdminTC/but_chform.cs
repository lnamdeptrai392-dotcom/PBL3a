using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3a.UI.AdminTC
{
    public class but_chform
    {
        public static Button currentButton;
        public static Form childform;

        // Them mau vao
        public static void ActivateButton(object sender)
        {
            if (sender != null && currentButton != (Button)sender)
            {
                DisableButton();
                currentButton = (Button)sender;
                currentButton.BackColor = Color.FromArgb(144, 188, 245);
            }
        }

        public static void Activate_DisableButton_fast(object sender)
        {
            if (sender != null)
            {
                currentButton = (Button)sender;
                currentButton.BackColor = Color.FromArgb(144, 188, 245);

                DisableButton();
            }
        }

        // Vo hieu hoa mau button khi khong chon
        public static void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(44, 78, 98);
            }
        }

        // Them giao dien con vao
        public static void OpenChildForm(Form child, object sender, Panel paDesktop)
        {
            if (childform != null)
            {
                childform.Close();
            }
            ActivateButton(sender);
            childform = child;
            child.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            paDesktop.Controls.Add(childform);
            paDesktop.Tag = child;
            child.BringToFront();
            child.Show();
        }

        public static void bt_MouseEnter(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.FromArgb(44, 78, 98);
        }

        public static void bt_MouseLeave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.FromArgb(44, 78, 98);
        }
    }
}
