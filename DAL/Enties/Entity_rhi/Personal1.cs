using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class Personal1
    {
        public int Id { get; set; }
        public string Fio { get; set; }
        public DateTime? Bithday { get; set; }
        public string DefId { get; set; }
        public string Podrazdelenie { get; set; }
        public string Organization { get; set; }
        public string Position { get; set; }
        public string Adress { get; set; }
        public string Telephone { get; set; }
        public string EMail { get; set; }
        public string InstructPoTb { get; set; }
        public string MedOsmotrGram { get; set; }
        public string MedOsmotrNew { get; set; }
        public string NalichieObycheniyaPoDolgnosti { get; set; }
        public string Certification { get; set; }
        public string MetodyNk { get; set; }
        public string DopObychenie { get; set; }
        public string Scaners { get; set; }
        public string TransNeft { get; set; }
        public string MechIspitaniya { get; set; }
    }
}
