using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class PersonalPhones
    {
        public int Id { get; set; }
        public int? IdPersonal { get; set; }
        public string Phone { get; set; }
        public string Type { get; set; }
        public string Comment { get; set; }
    }
}
