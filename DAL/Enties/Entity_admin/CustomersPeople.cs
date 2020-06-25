using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class CustomersPeople
    {
        public int Id { get; set; }
        public string Заказчик { get; set; }
        public string Фио { get; set; }
        public string Удостоверение { get; set; }
        public DateTime? ДействительноОт { get; set; }
        public DateTime? ДействительноДо { get; set; }
        public string Должность { get; set; }
        public string ДолжностьEn { get; set; }
        public string Телефон { get; set; }
        public string Почта { get; set; }
        public string DataBaseName { get; set; }
        public string Logger { get; set; }
    }
}
