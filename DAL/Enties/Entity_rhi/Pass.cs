using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class Pass
    {
        public int Код { get; set; }
        public string Login { get; set; }
        public string Porol { get; set; }
        public int? AccessLevel { get; set; }
        public string CompName { get; set; }
        public string Tabls { get; set; }
        public string GroupAccess { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Read { get; set; }
        public string Write { get; set; }
        public string StartPage { get; set; }
        public string MessageAdmin { get; set; }
        public string Position { get; set; }
        public byte[] Setting { get; set; }
        public string DefGroup { get; set; }
        public DateTime? TimeInput { get; set; }
    }
}
