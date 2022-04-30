using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxProject
{
    class TestClass
    {
        public enum TestEnum
        {
            Eksempel1,
            Eksempel2,
            Eksempel3
        }

        public TestEnum MyEnum { get; set; }

        public TestClass(TestEnum myEnum)
        {
            MyEnum = myEnum;
        }
    }
}
