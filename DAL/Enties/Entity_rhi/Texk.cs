using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class Texk
    {
        public int Код { get; set; }
        public double? DiamOt { get; set; }
        public double? DiamDo { get; set; }
        public string СнипВик { get; set; }
        public string ГостВик { get; set; }
        public string РдВик { get; set; }
        public string СнипРк { get; set; }
        public string ГостРк { get; set; }
        public string РдРк { get; set; }
        public string Сп70Вик { get; set; }
        public string Сп70Рк { get; set; }
        public string ГостP52630Рк { get; set; }
        public string ГостP52630Вик { get; set; }
        public string СниП30301Вик { get; set; }
        public string ГостУзк { get; set; }
        public string РдУзк { get; set; }
        public string СнипУзк { get; set; }
        public string ПэВик { get; set; }
        public string PeВик { get; set; }
    }
}
