using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class PersonalAddres
    {
        public int Id { get; set; }
        public int? IdPersonal { get; set; }
        public string Addres { get; set; }
        public string AddresType { get; set; }
        public string Comment { get; set; }
    }
}
