using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class Weater
    {
        public int Id { get; set; }
        public string JsonSourse { get; set; }
        public string Location { get; set; }
        public DateTime? Date { get; set; }
        public string Temp { get; set; }
        public string Pressure { get; set; }
        public string Humidity { get; set; }
        public string TempMin { get; set; }
        public string TempMax { get; set; }
        public DateTime? Dataaddinbd { get; set; }
        public string LocationId { get; set; }
        public string Logger { get; set; }
        public string JsonMy { get; set; }
        public string Locations { get; set; }
    }
}
