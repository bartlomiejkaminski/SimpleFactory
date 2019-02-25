using System;

namespace SimpleFactory
{
    class BalconyFactory : IBalconyFactory
    {
        public IBalcony CreateBalcony(TypeBalcony typeBalcony)
        {
            switch (typeBalcony)
            {
                case TypeBalcony.Type1:
                    return new BalconyType1();
                case TypeBalcony.Type2:
                    return new BalconyType2();
                case TypeBalcony.Type3:
                    return new BalconyType3();
                case TypeBalcony.Type4:
                    return new BalconyType4();
                default:
                    throw new Exception($"There is no such type of balcony as {typeBalcony}");
            }
        }
    }
}