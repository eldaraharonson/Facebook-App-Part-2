using B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace B20_Ex01_Eldar_313371833_Idan_313116543
{
    public class GroupParams
    {
        private AgeRange m_AgePreferences = null;
        private List<string> m_Gender = null;
        private int m_Likes = 0;
        private bool m_IsPopular = false;
        private Group m_Group;

        public Group Group
        {
            get
            {
                return m_Group;
            }

            set
            {
                m_Group = value;
            }
        }

        public List<string> Gender
        {
            get
            {
                return m_Gender;
            }

            set
            {
                m_Gender = value;
            }
        }

        public AgeRange AgePreferences
        {
            get
            {
                return m_AgePreferences;
            }

            set
            {
                m_AgePreferences = value;
            }
        }

        public int Likes
        {
            get
            {
                return m_Likes;
            }

            set
            {
                Likes = value;
            }
        }
        public bool IsPopular
        {
            get
            {
                return m_IsPopular;
            }

            set
            {
                m_IsPopular = value;
            }
        }
    }
}
