using System.Collections.Generic;
using System.Windows.Forms;

namespace B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature
{
    public class FilterOptionsSystem
    {
        public List<AgeRange> GetAgeRanges(CheckedListBox io_AgesCheckedListBox)
        {
            List<AgeRange> ageRanges = new List<AgeRange>();
            List<string> stringOfAgeRanges = GetCheckBoxListItems(io_AgesCheckedListBox);
            foreach (string ageRangeString in stringOfAgeRanges)
            {
                int.TryParse(ageRangeString.Substring(0, 2), out int lowestAge);
                int.TryParse(ageRangeString.Substring(5), out int highestAge);
                ageRanges.Add(new AgeRange(lowestAge, highestAge));
            }

            return ageRanges;
        }

        public List<string> GetGenders(CheckedListBox io_GendersCheckedListBox)
        {
            List<string> genders = GetCheckBoxListItems(io_GendersCheckedListBox);
            return genders;
        }

        //checks that for all filters at least one filter has been checked
        public bool CheckBoxesValidation(List<CheckedListBox> i_CheckedListBoxes)
        {
            bool allFiltersChecked = true;
            foreach (CheckedListBox checkedListBox in i_CheckedListBoxes)
            {
                if (checkedListBox.CheckedItems.Count != 1)
                {
                    allFiltersChecked = false;
                    break;
                }
            }

            return allFiltersChecked;
        }

        public List<string> GetCheckBoxListItems(CheckedListBox i_CheckedListBox)
        {
            List<string> checkedItems = new List<string>();
            foreach (string item in i_CheckedListBox.CheckedItems)
            {
                checkedItems.Add(item);
            }
            return checkedItems;
        }
    }
}
