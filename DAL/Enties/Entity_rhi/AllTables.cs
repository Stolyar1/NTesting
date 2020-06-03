using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class AllTables
    {
        public int Id { get; set; }
        public string TableId { get; set; }
        public string Ipserver { get; set; }
        public string Webpage { get; set; }
        public string Description { get; set; }
        public string MetodControl { get; set; }
        public string Customer { get; set; }
        public string Contract { get; set; }
        public string DatabaseId { get; set; }
        public string Comment { get; set; }
        public string Location { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string UnitName { get; set; }
        public string PriceUnit { get; set; }
        public string ContractTable { get; set; }
        public string LastReportId { get; set; }
        public int? EmailGroupId { get; set; }
        public string DatabaseName { get; set; }
        public string RepresentName { get; set; }
        public string RepresentIdent { get; set; }
        public string LabName { get; set; }
        public string Мвз { get; set; }
        public string PrintDocParametr { get; set; }
        public string Status { get; set; }
    }
}
