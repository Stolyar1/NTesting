using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class MashineTable
    {
        public int Id { get; set; }
        public string MetodNk { get; set; }
        public string Name { get; set; }
        public string Наименование { get; set; }
        public string Number { get; set; }
        public object Fifid { get; set; }
        public string DataCheck { get; set; }
        public string CertName { get; set; }
        public string SertValidDate { get; set; }
        public string Sezlab { get; set; }
        public DateTime? DataAddIn { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public string PeronalFio { get; set; }
        public string JsonData { get; set; }
        public DateTime? ДатаПроизводства { get; set; }
        public string Группа { get; set; }
        public string Comments { get; set; }
        public string УчастокМвз { get; set; }
        public string Logger { get; set; }
        public string Количество { get; set; }
        public string ЕдИзмерения { get; set; }
        public string ПолноеНаименование { get; set; }
        public string Производитель { get; set; }
        public string СтранаПроизводства { get; set; }
        public DateTime? ДатаДобавления { get; set; }
    }
}
