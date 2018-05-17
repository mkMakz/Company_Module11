using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory.Modules
{
   
    public enum EducationForm { DayTime, Evening }

    public struct Student
    {
        private string FullName_;

        public string FullName
        {
            get
            {
                return FullName_;
            }
            set
            {
                FullName_ = value.Replace("<center><b><font size=7>", "").Replace("</font></b></center>", "").Replace("\n", "");
            }
        }
        public int Group { get; set; }
        public float AverageMark { get; set; }
        public int Income { get; set; }
        public EducationForm Form { get; set; }

    }
}
