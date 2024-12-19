using DomainLayer.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Entities
{
    public class SubjectGpas : BaseEntity
    {

        public string SubjectName
        {
            get;
            set;
        }
        public float Gpa
        {
            get;
            set;
        }
        public string SubjectPassStatus
        {
            get;
            set;
        }
        public int StudentId
        {
            get;
            set;
        }
        public Student Students
        {
            get;
            set;
        }
    }
}
