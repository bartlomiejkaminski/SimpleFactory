using System;

namespace SimpleFactory
{
    interface IBalconyFactory
    {
        IBalcony CreateBalcony(TypeBalcony typeBalcony);
    }
}
