using B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature.Forms;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;
using static B20_Ex01_Eldar_313371833_Idan_313116543.WelcomeForm;

namespace B20_Ex01_Eldar_313371833_Idan_313116543
{
    public partial class ChooseGroupForm : Form
    {
        private User m_LoggedInUser;
        private FormName m_FormName;
        private Group m_Group;
        public ChooseGroupForm(User i_LoggedInUser, FormName i_FormName)
        {
            m_LoggedInUser = i_LoggedInUser;
            m_FormName = i_FormName;
            InitializeComponent();
            try
            {
                foreach (Group group in m_LoggedInUser.Groups)
                {
                    userGroups.Items.Add(group.Name);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to fetch user's groups information because facebook doesn't allow");
            }
        }

        private void userGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentItem = userGroups.SelectedItem.ToString();
            foreach (Group group in m_LoggedInUser.Groups)
            {
                if (group.Name == currentItem)
                {
                    m_Group = group;
                }
            }
        }

        private void checkGroupPopularity_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            FilterOptionsForm filterOptionsForm = new FilterOptionsForm(m_LoggedInUser, m_Group, FormName.groupPopularity);
            filterOptionsForm.ShowDialog();
        }
    }
}
