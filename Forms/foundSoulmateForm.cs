using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature.Forms
{
    public partial class FoundSoulmateForm : Form
    {
        public SingletonFacade m_Facade = SingletonFacade.GetInstance();
        private User m_Soulmate;
        private User m_LoggedInUser;
        private List<string> m_PreferredGenders;
        private List<AgeRange> m_PreferredAges;

        public FoundSoulmateForm(User i_LoggedInUser, List<string> i_PreferredGenders, List<AgeRange> i_PreferredAges)
        {
            m_LoggedInUser = i_LoggedInUser;
            m_PreferredGenders = i_PreferredGenders;
            m_PreferredAges = i_PreferredAges;
            m_Soulmate = m_Facade.GetFriendThatGaveMostLikes(m_LoggedInUser, m_PreferredGenders, m_PreferredAges);
            InitializeComponent();
            loadUItoForm();
        }

        private void loadUItoForm()
        {
            // Since the app can't access the user's friends I put the user as the soulmate
            if (m_Soulmate == null)
            {
                m_Soulmate = m_LoggedInUser;
            }

            soulmateProfilePicture.ImageLocation = m_Soulmate.PictureNormalURL;
            soulmateNameLabel.Text = string.Format("{0} has given you the most likes!!", m_Soulmate.Name);
        }
    }
}
