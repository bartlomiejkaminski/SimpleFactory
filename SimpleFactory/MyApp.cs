using System;

namespace SimpleFactory
{
    class MyApp
    {
        private readonly IBalconyFactory _balconyFactory;

        public MyApp(IBalconyFactory balconyFactory)
        {
            _balconyFactory = balconyFactory;

            IBalcony balcony1 = _balconyFactory.CreateBalcony(TypeBalcony.Type1);
            balcony1.GetName();

            IBalcony balcony2 = _balconyFactory.CreateBalcony(TypeBalcony.Type2);
            balcony2.GetName();

            IBalcony balcony3 = _balconyFactory.CreateBalcony(TypeBalcony.Type3);
            balcony3.GetName();

            IBalcony balcony4 = _balconyFactory.CreateBalcony(TypeBalcony.Type4);
            balcony4.GetName();
        }
    }
}
