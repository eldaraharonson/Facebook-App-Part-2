using FacebookWrapper.ObjectModel;

namespace B20_Ex01_Eldar_313371833_Idan_313116543
{
    public interface IGroupStatisticBuilder
    {
        void GenderBuilder();
        void AgeBuilder();
        void LikeBuilder(int Likes);
        void GroupBuilder(Group Group);
        GroupParams GetGroupParams();
    }
}
