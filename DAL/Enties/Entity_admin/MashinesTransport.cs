using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class MashinesTransport
    {
        public int Id { get; set; }
        public string Имя { get; set; }
        public string СерийныйНомер { get; set; }
        public string Пользователь { get; set; }
        public string Откуда { get; set; }
        public string Куда { get; set; }
        public DateTime? ДатаПеремещения { get; set; }
        public int? ИдОсновнойТаблицы { get; set; }
        public string Ответственный { get; set; }
        public string Мвз { get; set; }
    }
}
