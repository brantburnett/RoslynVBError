using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynTestCSharp
{
    class ClassWithStaticField
    {

        public const decimal DecimalConstant = 375M;

        private static readonly Dictionary<string, float> DictionaryField = new Dictionary<string, float>()
        {
            {"String1", 1.0F},
            {"String2", 2.0F},
            {"String3", 3.0F}
        };

        public static Dictionary<string, float> Dictionary
        {
            get { return DictionaryField; }
        } 
    }
}
