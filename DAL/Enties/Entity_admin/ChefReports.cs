using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class ChefReports
    {
        public int Id { get; set; }
        public string Локация { get; set; }
        public string ВсегоПерсонала { get; set; }
        public string ВсегоДефектоскопистов { get; set; }
        public TimeSpan? TimeSart { get; set; }
        public TimeSpan? TimeEnd { get; set; }
        public string ВсегоОборудования { get; set; }
        public string ЗадействованноОборудования { get; set; }
        public int? ДоступноДляКонтроля { get; set; }
        public int? ВсегоПроконтролировано { get; set; }
        public int? ВсегоПоказано { get; set; }
        public int? ВсегоПоЗаявкам { get; set; }
        public string UserName { get; set; }
        public DateTime? ДатаОтчёта { get; set; }
        public DateTime? ДатаДобавления { get; set; }
        public string Ответственный { get; set; }
        public int? ReportId { get; set; }
        public string ObjectName { get; set; }
        public string Status { get; set; }
        public string JsonData { get; set; }
        public double? Затраты { get; set; }
        public double? Доходы { get; set; }
        public int? КолВоЗаключений { get; set; }
        public string КоментарийПоПерсоналу { get; set; }
        public string КоментарийПоОборудованию { get; set; }
        public string КоментарийПоВыполнению { get; set; }
        public string КоментарийПоМатериалам { get; set; }
        public string Logger { get; set; }
    }
}
