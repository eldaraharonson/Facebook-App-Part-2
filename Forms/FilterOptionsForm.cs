using B20_Ex01_Eldar_313371833_Idan_313116543.BuilderPattern.BuilderEngineer;
using B20_Ex01_Eldar_313371833_Idan_313116543.FactoryPattern;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature.Forms
{
    public partial class FilterOptionsForm : Form
    {
        private User m_LoggedInUser;
        private WelcomeForm.FormName m_FormName;
        private List<AgeRange> m_PreferredAgeRanges;
        private List<string> m_PreferredGenders;
        private Group m_Group;
        private SingletonFacade m_Facade = SingletonFacade.GetInstance();
        private Engineer m_BuildEngineer;
        private BuilderFactory m_BuilderFactory = new BuilderFactory();

        public FilterOptionsForm(User i_LoggedInUser, Group i_Group, WelcomeForm.FormName i_FormName)
        {
            m_Group = i_Group;
            m_FormName = i_FormName;
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            switch (m_FormName)
            {
                case WelcomeForm.FormName.findStalker:
                    {
                        if (!hasChosenParameters())
                        {
                            return;
                        }

                        assignSelectedFilters();
                        FoundSoulmateForm foundSoulmateForm = new FoundSoulmateForm(m_LoggedInUser, m_PreferredGenders, m_PreferredAgeRanges);
                        this.Hide();
                        foundSoulmateForm.ShowDialog();
                        break;
                    }

                case WelcomeForm.FormName.groupPopularity:
                    {
                        if (!hasChosenParameters())
                        {
                            return;
                        }

                        assignSelectedFilters();
                        GroupPopularityForm groupPopularityForm = new GroupPopularityForm(m_BuildEngineer);
                        this.Hide();
                        groupPopularityForm.ShowDialog();
                        break;
                    }

                default:
                    break;
            }
        }

        private bool hasChosenParameters()
        {
            List<CheckedListBox> checkedListBoxes = new List<CheckedListBox>();
            checkedListBoxes.Add(preferredAgesCheckList);
            checkedListBoxes.Add(preferredGenderCheckList);
            bool isValid = true;
            if (!m_Facade.CheckBoxesValidation(checkedListBoxes))
            {
                MessageBox.Show("You must check one item from each checkbox list");
                isValid = false;
            }

            return isValid;
        }

        private void assignSelectedFilters()
        {
            m_PreferredAgeRanges = m_Facade.GetSelectedAgeRanges(preferredAgesCheckList);
            m_PreferredGenders = m_Facade.GetSelectedGenders(preferredGenderCheckList);
            //IGroupStatisticBuilder groupBuilderType = m_BuilderFactory.CreateBuilder(m_PreferredAgeRanges, m_PreferredGenders, m_Group.Members.Count);
            //m_BuildEngineer = new Engineer(groupBuilderType, m_Group.Members.Count, m_Group);
        }
    }
}
