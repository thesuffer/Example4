using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class TempBoss
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string LastNameRu { get; set; }
        public string FirstNameRu { get; set; }
        public string MiddleNameRu { get; set; }
        public string Wwid { get; set; }
        public string BusinessPhone { get; set; }
        public string BusinessMobile { get; set; }
        public string PositionName { get; set; }
        public string Positionnameru { get; set; }
        public string Employeetype { get; set; }
        public string NetworkAccount { get; set; }
    }
}
