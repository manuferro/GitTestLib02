using System;
using TestLib01;

namespace GitTestLib02
{
    public class ClassTest02
    {

        public int TestVersion { get => 2; }
        public int test()
        {
            ClassTest01 test = new ClassTest01();
            return test.TestVersion;
        }
    }
}
