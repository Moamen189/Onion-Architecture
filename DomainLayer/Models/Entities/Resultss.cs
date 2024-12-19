using DomainLayer.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Entities
{
    public class Resultss : BaseEntity
    {

        public string? ResultStatus
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
