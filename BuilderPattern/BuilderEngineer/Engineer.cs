using FacebookWrapper.ObjectModel;

namespace B20_Ex01_Eldar_313371833_Idan_313116543.BuilderPattern.BuilderEngineer
{
    public class Engineer
    {
        private IGroupStatisticBuilder m_Builder;
        private int m_Likes;
        private Group m_Group;

        public Engineer(IGroupStatisticBuilder i_Builder, int i_Likes, Group i_Group)
        {
            m_Group = i_Group;
            m_Builder = i_Builder;
            m_Likes = i_Likes;
        }

        public GroupParams GetGroupParams()
        {
            return m_Builder.GetGroupParams();
        }

        public void makeGroup()
        {
            m_Builder.AgeBuilder();
            m_Builder.GenderBuilder();
            m_Builder.LikeBuilder(m_Likes);
            m_Builder.GroupBuilder(m_Group);
        }
    }
}
