using B20_Ex01_Eldar_313371833_Idan_313116543.BuilderPattern.BuilderEngineer;
using B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace B20_Ex01_Eldar_313371833_Idan_313116543
{
    public partial class GroupPopularityForm : Form
    {
        public SingletonFacade m_Facade = SingletonFacade.GetInstance();
        private Group m_Group;
        private List<string> m_PreferredGenders;
        private List<AgeRange> m_PreferredAges = new List<AgeRange>();
        private int m_MemberCount;

        public GroupPopularityForm(Engineer i_Engineer)
        {
            i_Engineer.makeGroup();
            m_Group = i_Engineer.GetGroupParams().Group;
            m_PreferredGenders = i_Engineer.GetGroupParams().Gender;
            m_PreferredAges.Add(i_Engineer.GetGroupParams().AgePreferences);
            m_MemberCount = m_Facade.GetNumberOfMembersInGroup(m_Group, m_PreferredGenders, m_PreferredAges);
            InitializeComponent();
            loadUIToForm();
        }

        private void loadUIToForm()
        {
            int lowestAge = m_PreferredAges[0].LowestAge;
            int highestAge = m_PreferredAges[0].HighestAge;
            foreach (AgeRange ageRange in m_PreferredAges)
            {
                if (highestAge > ageRange.HighestAge)
                {
                    highestAge = ageRange.HighestAge;
                }
                if (lowestAge < ageRange.LowestAge)
                {
                    lowestAge = ageRange.LowestAge;
                }
            }

            header.Text = string.Format("the number of members with the gender {0} and between the ages {1} - {2} in the group is:", string.Join(",", m_PreferredGenders), lowestAge, highestAge);
            memberCount.Text = string.Format("{0}", m_MemberCount);
        }
    }
}
