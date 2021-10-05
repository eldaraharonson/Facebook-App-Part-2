using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace B20_Ex01_Eldar_313371833_Idan_313116543.Find_Stalker_Feature
{
    public class FoundSoulmateAndGroupPopularitySystem
    {
        public User FindFriendThatGaveMostLikes(User io_LoggedInUser, List<string> io_PreferredGenders, List<AgeRange> io_PreferredAges)
        {
            int maxNumberOfLikesByOneOppositeSexFriend = 0;
            User oppositeSexFriendWithMaxNumberOfLikes = new User();
            foreach (User friend in io_LoggedInUser.Friends)
            {
                if (isOfPreferredGender(friend, io_PreferredGenders) && isOfPreferredAge(friend, io_PreferredAges))
                {
                    int numberOfLikesByFriend = numberOfLikesFriendGaveUser(io_LoggedInUser, friend);
                    if (numberOfLikesByFriend > maxNumberOfLikesByOneOppositeSexFriend)
                    {
                        oppositeSexFriendWithMaxNumberOfLikes = friend;
                        maxNumberOfLikesByOneOppositeSexFriend = numberOfLikesByFriend;
                    }
                }
            }

            if (maxNumberOfLikesByOneOppositeSexFriend == 0)
            {
                oppositeSexFriendWithMaxNumberOfLikes = null;
            }

            return oppositeSexFriendWithMaxNumberOfLikes;
        }

        private static int numberOfLikesFriendGaveUser(User i_LoggedInUser, User io_Friend)
        {
            int numberOfLikes = 0;
            foreach (Post post in i_LoggedInUser.Posts)
            {
                if (post.LikedBy.Contains(io_Friend))
                {
                    numberOfLikes++;
                }
            }

            return numberOfLikes;
        }

        private static bool isOfPreferredGender(User i_Friend, List<string> i_PreferredGender)
        {
            bool isPreferredGender = false;
            foreach (string gender in i_PreferredGender)
            {
                if (string.Equals(i_Friend.Gender, gender))
                {
                    isPreferredGender = true;
                    break;
                }
            }

            return isPreferredGender;
        }

        private static bool isOfPreferredAge(User io_Friend, List<AgeRange> i_PreferredAges)
        {
            int friendAge = getAge(io_Friend);
            bool preferredAge = false;
            foreach (AgeRange ageRange in i_PreferredAges)
            {
                if (ageRange.isInAgeRange(friendAge))
                {
                    preferredAge = true;
                    break;
                }
            }

            return preferredAge;
        }

        private static int getAge(User i_User)
        {
            int.TryParse(i_User.Birthday.Substring(6), out int birthYear);
            int age = DateTime.Now.Year - birthYear;
            return age;
        }

        public int numberOfMembersInGroup(Group i_Group, List<string> io_PreferredGenders, List<AgeRange> io_PreferredAges)
        {
            int memberCount = 0;
            foreach (User member in i_Group.Members)
            {
                if (isOfPreferredGender(member, io_PreferredGenders) && isOfPreferredAge(member, io_PreferredAges))
                {
                    memberCount++;
                }
            }

            return memberCount;
        }
    }
}
