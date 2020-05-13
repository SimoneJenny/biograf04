using System;
using System.Collections.Generic;
using System.Text;

namespace UserForTest
{
    public class TestMOQ
    {
        public bool addTest()
        {
            Address obj = new Address();
            obj.validate();
            return true;
        }
    }
}
