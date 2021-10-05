using B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B20_Ex01_Eldar_313371833_Idan_313116543.FactoryPattern
{
    public class BuilderFactory
    {
        public IGroupStatisticBuilder CreateBuilder(List<AgeRange> i_AgePreferences, List<string> i_Gender, int i_Likes)
        {
            IGroupStatisticBuilder groupBuilder;
            if (i_AgePreferences[0].HighestAge == 25)
            {
                if (i_Gender[0] == "Male")
                {
                    if (i_Likes <= 100)
                    {
                        groupBuilder = new YoungBoysNotPopularGroupBuilder();
                    }
                    else
                    {
                        groupBuilder = new YoungBoysNotPopularGroupBuilder();
                    }
                }
                else
                {
                    if (i_Likes <= 100)
                    {
                        groupBuilder = new YoungGirlsGroupNotPopularBuilder();
                    }
                    else
                    {
                        groupBuilder = new YoungGirlsGroupPopularBuilder();
                    }
                }
            }
            else if (i_AgePreferences[0].LowestAge == 50)
            {
                if (i_Gender[0] == "Male")
                {
                    if (i_Likes <= 100)
                    {
                        groupBuilder = new OldWomenNotPopularGroupBuilder();
                    }
                    else
                    {
                        groupBuilder = new OldMenPopularGroupBuilder();
                    }
                }
                else
                {
                    if (i_Likes <= 100)
                    {
                        groupBuilder = new OldWomenNotPopularGroupBuilder();
                    }
                    else
                    {
                        groupBuilder = new OldWomenPopularGroupBuilder();
                    }
                }
            }
            else if (i_AgePreferences[0].LowestAge == 26)
            {
                if (i_Gender[0] == "Male")
                {
                    if (i_Likes <= 100)
                    {
                        groupBuilder = new YoungAdultMaleNotPopularGroupBuilder();
                    }
                    else
                    {
                        groupBuilder = new YoungAdultMalePopularGroupBuilder();
                    }
                }
                else
                {
                    if (i_Likes <= 100)
                    {
                        groupBuilder = new YoungAdultFemaleNotPopularGroupBuilder();
                    }
                    else
                    {
                        groupBuilder = new YoungAdultFemalePopularGroupBuilder();
                    }
                }
            }
            else
            {
                if (i_Gender[0] == "Male")
                {
                    if (i_Likes <= 100)
                    {
                        groupBuilder = new AdultMaleNotPopularGroupBuilder();
                    }
                    else
                    {
                        groupBuilder = new AdultMalePopularGroupBuilder();
                    }
                }
                else
                {
                    if (i_Likes <= 100)
                    {
                        groupBuilder = new AdultFemaleNotPopularGroupBuilder();
                    }
                    else
                    {
                        groupBuilder = new AdultFemalePopularGroupBuilder();
                    }
                }
            }

            return groupBuilder;
        }
    }
}
