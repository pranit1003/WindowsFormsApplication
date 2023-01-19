using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication
{
    [Serializable]
  public  class Student
    {
        public string StuName    { get; set; }
        public int StuRollNo     { get; set; }
        public int StuPercentage { get; set; }
    }
}
