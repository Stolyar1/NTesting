using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class CustomUsers
    {
        public int Id { get; set; }
        public string Fio { get; set; }
        public DateTime? Bithday { get; set; }
        public string Пол { get; set; }
        public string Adress { get; set; }
        public string Telephone { get; set; }
        public string EMail { get; set; }
        public string DefId { get; set; }
        public string Organization { get; set; }
        public string Position { get; set; }
        public string Участок { get; set; }
        public string Podrazdelenie { get; set; }
        public string СтатусРаботника { get; set; }
        public string Инн { get; set; }
        public string Снилс { get; set; }
        public string GenPass { get; set; }
        public int? AccessLevel { get; set; }
        public string AcessTables { get; set; }
        public string PropertyJson { get; set; }
        public string StartPage { get; set; }
        public string GroupAccess { get; set; }
        public string MessageAdmin { get; set; }
        public string МетодРаботы { get; set; }
        public string Роли { get; set; }
        public long? YandexId { get; set; }
        public DateTime? DataAdd { get; set; }
        public DateTime? ДатаУвольнения { get; set; }
        public string Комментарий { get; set; }
    }
}
