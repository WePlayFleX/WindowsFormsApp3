using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Student
    {
        

        public string name { get; set; }
        public string surName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

        public override string ToString()
        {
            return $"{name} {surName}";
        }
    }
}
