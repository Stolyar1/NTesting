using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class VtEnr
    {
        public int Код { get; set; }
        public string Zona { get; set; }
        public string Drawing { get; set; }
        public string Sheet { get; set; }
        public string Rev { get; set; }
        public string Line { get; set; }
        public string WeldId { get; set; }
        public string Diam { get; set; }
        public string Tolsh { get; set; }
        public string Element1 { get; set; }
        public string Element2 { get; set; }
        public DateTime? DataWeld { get; set; }
        public string PwhtBeforeOrAfter { get; set; }
        public string Welder1Id { get; set; }
        public string Welder2Id { get; set; }
        public string Welder3Id { get; set; }
        public string Welder4Id { get; set; }
        public string WeldingProcess { get; set; }
        public string TypeOfWelds { get; set; }
        public string PipelineCategory { get; set; }
        public string TypeOfControlNdt { get; set; }
        public string NoNdt { get; set; }
        public string Remarks { get; set; }
        public string ReqestNo { get; set; }
        public DateTime? ReqestDate { get; set; }
        public DateTime? NdtDate { get; set; }
        public string ReportId { get; set; }
        public string DefectoskopistId { get; set; }
        public int? ActNo { get; set; }
        public DateTime? ActDate { get; set; }
        public string PrintSumma { get; set; }
        public DateTime? DataAddInBd { get; set; }
        public string Result { get; set; }
        public string Razbrakovka { get; set; }
        public DateTime? TimePrint { get; set; }
        public string Operator { get; set; }
        public string Поле35 { get; set; }
        public string Поле36 { get; set; }
        public string Поле37 { get; set; }
        public string Поле38 { get; set; }
        public string Поле39 { get; set; }
        public string FileName { get; set; }
        public string Поле41 { get; set; }
        public string WeldSumm { get; set; }
        public string Logger { get; set; }
    }
}
