using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadFun
{
    class Test
    {
        public enum TestEnum
        {
            Eksempel1,
            Eksempel2,
            Eksempel3
        }

        public TestEnum MyEnum { get; set; }

        public Test(TestEnum myEnum)
        {
            MyEnum = myEnum;
        }
    }
}
