using B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace B20_Ex01_Eldar_313371833_Idan_313116543
{
    public partial class WelcomeForm : Form
    {
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;
       
        public WelcomeForm(LoginResult i_LoginResult)
        {
            InitializeComponent();
            m_LoginResult = i_LoginResult;
            m_LoggedInUser = i_LoginResult.LoggedInUser;
            DisplayWelcomeMessage();
        }

        public enum FormName
        {
            groupPopularity = 0,
            findStalker = 1
        }

        public void DisplayWelcomeMessage()
        {
            this.Text = string.Format("Logged in as {0} {1}", m_LoggedInUser.FirstName, m_LoggedInUser.LastName);
            userProfilePicture.ImageLocation = m_LoggedInUser.PictureNormalURL;
        }

        private void findStalkerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FilterOptionsForm filterOptionsForm = new FilterOptionsForm(m_LoggedInUser, null, FormName.findStalker);
            filterOptionsForm.ShowDialog();
        }

        private void groupPopularityButtom_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseGroupForm filterOptionsForm = new ChooseGroupForm(m_LoggedInUser, FormName.groupPopularity);
            filterOptionsForm.ShowDialog();
        }

        private void Button_GroupFetch_Click(object sender, EventArgs e)
        {
            groupBindingSource.DataSource = m_LoggedInUser.Groups;
        }
    }
}
