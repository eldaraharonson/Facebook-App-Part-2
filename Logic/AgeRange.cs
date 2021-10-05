namespace B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature
{
    public class AgeRange
    {
        public int m_LowestAge;
        public int m_HighestAge;
        public int LowestAge
        {
            get
            {
                return m_LowestAge;
            }
        }

        public int HighestAge
        {
            get
            {
                return m_HighestAge;
            }
        }

        public AgeRange(int i_LowestAge, int i_HighestAge)
        {
            m_LowestAge = i_LowestAge;
            m_HighestAge = i_HighestAge;
        }

        public bool isInAgeRange(int i_age)
        {
            return m_LowestAge <= i_age && i_age <= m_HighestAge;
        }
    }
}
