using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectTest.Model
{
    public class Person
    {
        [PersonCheck(CheckEmpty=true)]
        public string Name { get; set; }

        [PersonCheck(CheckRegex = true, RegexStr = "^[0-9]*[1-9][0-9]*$")]
        public string Num { get; set; }

        [PersonCheck(CheckMaxLength = true, MaxLength = 12)]
        public string Address { get; set; }
    }
}
