using B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace B20_Ex01_Eldar_313371833_Idan_313116543
{
    public class AdultMalePopularGroupBuilder : IGroupStatisticBuilder
    {
        private GroupParams m_GroupParams = new GroupParams();

        public void GroupBuilder(Group Group)
        {
            m_GroupParams.Group = Group;
        }
        public void AgeBuilder()
        {
            AgeRange ageRange = new AgeRange(36, 50);
            m_GroupParams.AgePreferences = ageRange;
        }

        public void GenderBuilder()
        {
            List<string> Gender = new List<string>();
            Gender.Add("Male");
            m_GroupParams.Gender = Gender;
        }

        public void LikeBuilder(int likes)
        {
            m_GroupParams.Likes = likes;
            m_GroupParams.IsPopular = true;
        }

        public GroupParams GetGroupParams()
        {
            return m_GroupParams;
        }
    }
}
