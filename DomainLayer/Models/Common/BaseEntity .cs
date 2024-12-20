﻿namespace DomainLayer.Models.Common
{
    public class BaseEntity
    {
        public int Id
        {
            get;
            set;
        }
        public DateTime CreatedDate
        {
            get;
            set;
        }
        public DateTime ModifiedDate
        {
            get;
            set;
        }
        public bool IsActive
        {
            get;
            set;
        }
    }
}
