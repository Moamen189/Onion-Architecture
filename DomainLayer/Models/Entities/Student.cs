using DomainLayer.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Entities
{
    public class Student : BaseEntity
    {

        public string? Name
        {
            get;
            set;
        }
        public string? Address
        {
            get;
            set;
        }
        public string? Emial
        {
            get;
            set;
        }
        public string? City
        {
            get;
            set;
        }
        public string? State
        {
            get;
            set;
        }
        public string? Country
        {
            get;
            set;
        }
        public int? Age
        {
            get;
            set;
        }
        public DateTime? BirthDate
        {
            get;
            set;
        }
    }
}
