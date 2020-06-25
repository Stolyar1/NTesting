using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Context.dbContext
{
    public partial class u0554110_adminContext : DbContext
    {
        public u0554110_adminContext()
        {
        }

        public u0554110_adminContext(DbContextOptions<u0554110_adminContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActTransfer> ActTransfer { get; set; }
        public virtual DbSet<ChefReports> ChefReports { get; set; }
        public virtual DbSet<Chuvstvitelnost> Chuvstvitelnost { get; set; }
        public virtual DbSet<CustomUsers> CustomUsers { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<CustomersPeople> CustomersPeople { get; set; }
        public virtual DbSet<Distributions> Distributions { get; set; }
        public virtual DbSet<FilmSizeParametrs> FilmSizeParametrs { get; set; }
        public virtual DbSet<FromOneSmaterial> FromOneSmaterial { get; set; }
        public virtual DbSet<Labs> Labs { get; set; }
        public virtual DbSet<Locactions> Locactions { get; set; }
        public virtual DbSet<LocationMvz> LocationMvz { get; set; }
        public virtual DbSet<MashCertficate> MashCertficate { get; set; }
        public virtual DbSet<MashRemonts> MashRemonts { get; set; }
        public virtual DbSet<MashineTable> MashineTable { get; set; }
        public virtual DbSet<MashinesCheckList> MashinesCheckList { get; set; }
        public virtual DbSet<MashinesComplects> MashinesComplects { get; set; }
        public virtual DbSet<MashinesTransport> MashinesTransport { get; set; }
        public virtual DbSet<MessageWeb> MessageWeb { get; set; }
        public virtual DbSet<NotificationTelegram> NotificationTelegram { get; set; }
        public virtual DbSet<PeopelMoneyParam> PeopelMoneyParam { get; set; }
        public virtual DbSet<PersonalTransport> PersonalTransport { get; set; }
        public virtual DbSet<ReportsMailFromCustomer> ReportsMailFromCustomer { get; set; }
        public virtual DbSet<RequestTable> RequestTable { get; set; }
        public virtual DbSet<ReshootDeleted> ReshootDeleted { get; set; }
        public virtual DbSet<ReshootRt> ReshootRt { get; set; }
        public virtual DbSet<RolePermissions> RolePermissions { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Sizeasme> Sizeasme { get; set; }
        public virtual DbSet<StObraz> StObraz { get; set; }
        public virtual DbSet<Steels> Steels { get; set; }
        public virtual DbSet<TableActionList> TableActionList { get; set; }
        public virtual DbSet<TableMobileChekin> TableMobileChekin { get; set; }
        public virtual DbSet<TableSms> TableSms { get; set; }
        public virtual DbSet<UsersCallBack> UsersCallBack { get; set; }
        public virtual DbSet<UsersRolle> UsersRolle { get; set; }
        public virtual DbSet<UtPep> UtPep { get; set; }
        public virtual DbSet<UtSop> UtSop { get; set; }
        public virtual DbSet<Weater> Weater { get; set; }
        public virtual DbSet<YandexEmailRefresh> YandexEmailRefresh { get; set; }
        public virtual DbSet<_1cTableWorkers> _1cTableWorkers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source=31.31.196.61;initial catalog=u0554110_admin;integrated security=False;persist security info=False;user id=u0554110_smslWeb;password=3B40C41F-7D20-4B21-9D6A-61987F144CA9;trustservercertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "u0554110_smslWeb");

            modelBuilder.Entity<ActTransfer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Act_Transfer", "u0554110_romi99");

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.БазаДанных)
                    .HasColumnName("База данных")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ДатаДобавления)
                    .HasColumnName("Дата добавления")
                    .HasColumnType("date");

                entity.Property(e => e.Заказчик).HasMaxLength(300);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.КоличествоЭлементов).HasColumnName("Количество элементов");

                entity.Property(e => e.Лаборатория).HasMaxLength(300);

                entity.Property(e => e.ЛогинОператора)
                    .HasColumnName("Логин оператора")
                    .HasMaxLength(50);

                entity.Property(e => e.НомерАкта).HasColumnName("Номер акта");

                entity.Property(e => e.НомерДоговора)
                    .HasColumnName("Номер договора")
                    .HasMaxLength(300);

                entity.Property(e => e.ПредставительЗаказчика)
                    .HasColumnName("Представитель заказчика")
                    .HasMaxLength(200);

                entity.Property(e => e.ПредставительЛаборатории)
                    .HasColumnName("Представитель лаборатории")
                    .HasMaxLength(200);

                entity.Property(e => e.СсылкаНаФайл)
                    .HasColumnName("Ссылка на файл")
                    .HasMaxLength(50);

                entity.Property(e => e.СтоимостьПоДоговору)
                    .HasColumnName("Стоимость по договору")
                    .HasMaxLength(50);

                entity.Property(e => e.Субподрядчик).HasMaxLength(300);

                entity.Property(e => e.Таблица).HasMaxLength(50);
            });

            modelBuilder.Entity<ChefReports>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Chef_Reports", "u0554110_romi99");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.JsonData).HasColumnName("Json_Data");

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.ObjectName).HasMaxLength(250);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ВсегоДефектоскопистов)
                    .HasColumnName("Всего дефектоскопистов")
                    .HasMaxLength(250);

                entity.Property(e => e.ВсегоОборудования)
                    .HasColumnName("Всего оборудования")
                    .HasMaxLength(250);

                entity.Property(e => e.ВсегоПерсонала)
                    .HasColumnName("Всего персонала")
                    .HasMaxLength(250);

                entity.Property(e => e.ВсегоПоЗаявкам).HasColumnName("Всего по заявкам");

                entity.Property(e => e.ВсегоПоказано).HasColumnName("Всего показано");

                entity.Property(e => e.ВсегоПроконтролировано).HasColumnName("Всего проконтролировано");

                entity.Property(e => e.ДатаДобавления)
                    .HasColumnName("Дата добавления")
                    .HasColumnType("date");

                entity.Property(e => e.ДатаОтчёта)
                    .HasColumnName("Дата отчёта")
                    .HasColumnType("datetime");

                entity.Property(e => e.ДоступноДляКонтроля).HasColumnName("Доступно для контроля");

                entity.Property(e => e.ЗадействованноОборудования)
                    .HasColumnName("Задействованно оборудования")
                    .HasMaxLength(50);

                entity.Property(e => e.КолВоЗаключений).HasColumnName("Кол во заключений");

                entity.Property(e => e.КоментарийПоВыполнению)
                    .HasColumnName("Коментарий по выполнению")
                    .HasMaxLength(1000);

                entity.Property(e => e.КоментарийПоМатериалам)
                    .HasColumnName("Коментарий по материалам")
                    .HasMaxLength(1000);

                entity.Property(e => e.КоментарийПоОборудованию)
                    .HasColumnName("Коментарий по оборудованию")
                    .HasMaxLength(1000);

                entity.Property(e => e.КоментарийПоПерсоналу)
                    .HasColumnName("Коментарий по персоналу")
                    .HasMaxLength(1000);

                entity.Property(e => e.Локация).HasMaxLength(250);

                entity.Property(e => e.Ответственный)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Chuvstvitelnost>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Chuvstvitelnost", "dbo");

                entity.Property(e => e.Do).HasMaxLength(50);

                entity.Property(e => e.Klass1).HasMaxLength(50);

                entity.Property(e => e.Klass2).HasMaxLength(50);

                entity.Property(e => e.Klass3).HasMaxLength(50);

                entity.Property(e => e.Ot).HasMaxLength(50);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CustomUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustomUsers", "dbo");

                entity.Property(e => e.Adress).HasMaxLength(255);

                entity.Property(e => e.Bithday).HasColumnType("date");

                entity.Property(e => e.DataAdd).HasColumnType("datetime");

                entity.Property(e => e.DefId)
                    .HasColumnName("Def_id")
                    .HasMaxLength(255);

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasColumnName("E_mail")
                    .HasMaxLength(255);

                entity.Property(e => e.Fio)
                    .IsRequired()
                    .HasColumnName("FIO")
                    .HasMaxLength(255);

                entity.Property(e => e.GenPass)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.GroupAccess).HasMaxLength(500);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MessageAdmin)
                    .HasColumnName("messageAdmin")
                    .HasMaxLength(500);

                entity.Property(e => e.Organization).HasMaxLength(255);

                entity.Property(e => e.Podrazdelenie).HasMaxLength(255);

                entity.Property(e => e.Position).HasMaxLength(255);

                entity.Property(e => e.PropertyJson).HasColumnName("PropertyJSON");

                entity.Property(e => e.StartPage).HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(255);

                entity.Property(e => e.ДатаУвольнения)
                    .HasColumnName("Дата увольнения")
                    .HasColumnType("date");

                entity.Property(e => e.Инн)
                    .HasColumnName("ИНН")
                    .HasMaxLength(255);

                entity.Property(e => e.Комментарий).HasMaxLength(1000);

                entity.Property(e => e.МетодРаботы)
                    .HasColumnName("Метод работы")
                    .HasMaxLength(100);

                entity.Property(e => e.Пол).HasMaxLength(7);

                entity.Property(e => e.Снилс)
                    .HasColumnName("СНИЛС")
                    .HasMaxLength(255);

                entity.Property(e => e.СтатусРаботника)
                    .HasColumnName("Статус работника")
                    .HasMaxLength(255);

                entity.Property(e => e.Участок).HasMaxLength(200);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customers", "u0554110_romi99");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MapOffice).HasMaxLength(250);

                entity.Property(e => e.NameEn).HasMaxLength(150);

                entity.Property(e => e.NameRu).HasMaxLength(150);
            });

            modelBuilder.Entity<CustomersPeople>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customers_People", "u0554110_romi99");

                entity.Property(e => e.DataBaseName).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.ДействительноДо)
                    .HasColumnName("Действительно до")
                    .HasColumnType("date");

                entity.Property(e => e.ДействительноОт)
                    .HasColumnName("Действительно от")
                    .HasColumnType("date");

                entity.Property(e => e.Должность).HasMaxLength(200);

                entity.Property(e => e.ДолжностьEn)
                    .HasColumnName("ДолжностьEN")
                    .HasMaxLength(250);

                entity.Property(e => e.Заказчик).HasMaxLength(500);

                entity.Property(e => e.Почта).HasMaxLength(200);

                entity.Property(e => e.Телефон).HasMaxLength(200);

                entity.Property(e => e.Удостоверение).HasMaxLength(50);

                entity.Property(e => e.Фио)
                    .HasColumnName("ФИО")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Distributions>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Distributions", "u0554110_romi99");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnName("mail")
                    .HasMaxLength(50);

                entity.Property(e => e.ДниРождения).HasColumnName("Дни рождения");

                entity.Property(e => e.ИдПерсонал).HasColumnName("Ид персонал");
            });

            modelBuilder.Entity<FilmSizeParametrs>(entity =>
            {
                entity.ToTable("FilmSizeParametrs", "u0554110_romi99");

                entity.Property(e => e.ExpCount).HasColumnName("Exp_count");

                entity.Property(e => e.SizeControl).HasColumnName("SIzeControl");

                entity.Property(e => e.ДлинаОкружности).HasColumnName("Длина_окружности");

                entity.Property(e => e.ФактДиаметр).HasColumnName("Факт_диаметр");
            });

            modelBuilder.Entity<FromOneSmaterial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FromOneSMaterial", "u0554110_romi99");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.JsonData).HasMaxLength(1000);

                entity.Property(e => e.ScladId).HasMaxLength(50);

                entity.Property(e => e.АртикулПроизводителя)
                    .HasColumnName("Артикул производителя")
                    .HasMaxLength(250);

                entity.Property(e => e.ДатаСинхронизации)
                    .HasColumnName("Дата синхронизации")
                    .HasColumnType("datetime");

                entity.Property(e => e.ЕдИзм)
                    .HasColumnName("Ед изм")
                    .HasMaxLength(50);

                entity.Property(e => e.ЗаводскойНомер)
                    .HasColumnName("Заводской номер")
                    .HasMaxLength(50);

                entity.Property(e => e.Ид1с)
                    .HasColumnName("ИД 1С")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.ИнвНомер)
                    .HasColumnName("Инв Номер")
                    .HasMaxLength(50);

                entity.Property(e => e.Количество)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.НаименованиеДляПечати)
                    .HasColumnName("Наименование для печати")
                    .HasMaxLength(350);

                entity.Property(e => e.РабочееНаименование)
                    .HasColumnName("Рабочее наименование")
                    .HasMaxLength(200);

                entity.Property(e => e.Склад).HasMaxLength(50);

                entity.Property(e => e.ТекущийСтатус)
                    .HasColumnName("Текущий статус")
                    .HasMaxLength(150);

                entity.Property(e => e.ФактНаСкладе).HasColumnName("Факт на складе");
            });

            modelBuilder.Entity<Labs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Labs", "u0554110_romi99");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdentCard).HasMaxLength(500);

                entity.Property(e => e.IdentDateDo).HasColumnType("date");

                entity.Property(e => e.IdentDateOt)
                    .HasColumnName("identDateOt")
                    .HasColumnType("date");

                entity.Property(e => e.NameEn)
                    .HasColumnName("NameEN")
                    .HasMaxLength(500);

                entity.Property(e => e.NameRu)
                    .HasColumnName("NameRU")
                    .HasMaxLength(500);

                entity.Property(e => e.NameShort).HasMaxLength(50);

                entity.Property(e => e.ИдОдинС)
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Locactions>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Locactions", "u0554110_romi99");

                entity.Property(e => e.DataBaseName).HasMaxLength(50);

                entity.Property(e => e.HashId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.WeatherId)
                    .HasColumnName("weatherId")
                    .HasMaxLength(50);

                entity.Property(e => e.WeatherName)
                    .HasColumnName("weatherName")
                    .HasMaxLength(50);

                entity.Property(e => e.ИдОдинС)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.ЛокацияИмя).HasMaxLength(500);

                entity.Property(e => e.Описание).HasMaxLength(500);
            });

            modelBuilder.Entity<LocationMvz>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LocationMVZ", "u0554110_romi99");

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.Hach)
                    .HasColumnName("hach")
                    .HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasMaxLength(250);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.Person).HasMaxLength(50);

                entity.Property(e => e.SmalName).HasMaxLength(150);
            });

            modelBuilder.Entity<MashCertficate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MashCertficate", "u0554110_romi99");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Выдано).HasColumnType("date");

                entity.Property(e => e.ДатаДобавления)
                    .HasColumnName("Дата добавления")
                    .HasColumnType("datetime");

                entity.Property(e => e.Действительно).HasColumnType("date");

                entity.Property(e => e.ИдОборудования).HasColumnName("Ид оборудования");

                entity.Property(e => e.Коментарий).HasMaxLength(100);

                entity.Property(e => e.Номер).HasMaxLength(50);

                entity.Property(e => e.Организация).HasMaxLength(500);

                entity.Property(e => e.УчастокМвз)
                    .HasColumnName("Участок МВЗ")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<MashRemonts>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MashRemonts", "u0554110_romi99");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.АктаВыполненныхРабот)
                    .HasColumnName("№ акта выполненных работ")
                    .HasMaxLength(50);

                entity.Property(e => e.ДатаАктаВыполненныхРабот)
                    .HasColumnName("Дата акта выполненных работ")
                    .HasColumnType("date");

                entity.Property(e => e.ДатаВыставленногоСчета)
                    .HasColumnName("Дата выставленного счета")
                    .HasColumnType("date");

                entity.Property(e => e.ДатаДобавления)
                    .HasColumnName("Дата добавления")
                    .HasColumnType("datetime");

                entity.Property(e => e.ДатаЗавершения)
                    .HasColumnName("Дата завершения")
                    .HasColumnType("date");

                entity.Property(e => e.ДатаРемонта)
                    .HasColumnName("Дата ремонта")
                    .HasColumnType("date");

                entity.Property(e => e.ИдОборудования).HasColumnName("Ид оборудования");

                entity.Property(e => e.Организация).HasMaxLength(500);

                entity.Property(e => e.ПричинаРемонта)
                    .HasColumnName("Причина ремонта")
                    .HasMaxLength(4000);

                entity.Property(e => e.СчетаНаОплату)
                    .HasColumnName("№ счета на оплату")
                    .HasMaxLength(50);

                entity.Property(e => e.УчастокМвз)
                    .HasColumnName("Участок МВЗ")
                    .HasMaxLength(250);

                entity.Property(e => e.ФиоОтправителя)
                    .HasColumnName("ФИО отправителя")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MashineTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MashineTable", "dbo");

                entity.Property(e => e.CertName).HasMaxLength(255);

                entity.Property(e => e.DataAddIn).HasColumnType("date");

                entity.Property(e => e.DataCheck).HasMaxLength(50);

                entity.Property(e => e.Fifid)
                    .HasColumnName("FIFid")
                    .HasColumnType("sql_variant");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Location).HasMaxLength(500);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.MetodNk)
                    .HasColumnName("MetodNK")
                    .HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Number).HasMaxLength(50);

                entity.Property(e => e.PeronalFio)
                    .HasColumnName("PeronalFIO")
                    .HasMaxLength(100);

                entity.Property(e => e.SertValidDate).HasMaxLength(50);

                entity.Property(e => e.Sezlab)
                    .HasColumnName("SEZLab")
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Группа).HasMaxLength(50);

                entity.Property(e => e.ДатаДобавления)
                    .HasColumnName("Дата добавления")
                    .HasColumnType("date");

                entity.Property(e => e.ДатаПроизводства)
                    .HasColumnName("Дата производства")
                    .HasColumnType("date");

                entity.Property(e => e.ЕдИзмерения)
                    .HasColumnName("Ед измерения")
                    .HasMaxLength(50);

                entity.Property(e => e.Количество).HasMaxLength(10);

                entity.Property(e => e.Наименование).HasMaxLength(300);

                entity.Property(e => e.ПолноеНаименование)
                    .HasColumnName("Полное наименование")
                    .HasMaxLength(500);

                entity.Property(e => e.Производитель).HasMaxLength(500);

                entity.Property(e => e.СтранаПроизводства)
                    .HasColumnName("Страна производства")
                    .HasMaxLength(50);

                entity.Property(e => e.УчастокМвз)
                    .HasColumnName("Участок МВЗ")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MashinesCheckList>(entity =>
            {
                entity.ToTable("MashinesCheckList", "u0554110_romi99");

                entity.Property(e => e.CheckType).HasMaxLength(50);

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.DataAdd).HasColumnType("datetime");

                entity.Property(e => e.JsonData).HasMaxLength(1000);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<MashinesComplects>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MashinesComplects", "u0554110_romi99");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.ЗаводскойНомер)
                    .HasColumnName("Заводской номер")
                    .HasMaxLength(200);

                entity.Property(e => e.ИдКомплекта).HasColumnName("Ид комплекта");

                entity.Property(e => e.ИнвНомер)
                    .HasColumnName("Инв номер")
                    .HasMaxLength(50);

                entity.Property(e => e.Коментарий).HasMaxLength(500);

                entity.Property(e => e.Наименование).HasMaxLength(200);

                entity.Property(e => e.Статус).HasMaxLength(200);
            });

            modelBuilder.Entity<MashinesTransport>(entity =>
            {
                entity.ToTable("MashinesTransport", "u0554110_romi99");

                entity.Property(e => e.ДатаПеремещения)
                    .HasColumnName("Дата перемещения")
                    .HasColumnType("datetime");

                entity.Property(e => e.ИдОсновнойТаблицы).HasColumnName("Ид основной таблицы");

                entity.Property(e => e.Имя).HasMaxLength(100);

                entity.Property(e => e.Куда).HasMaxLength(100);

                entity.Property(e => e.Мвз)
                    .HasColumnName("МВЗ")
                    .HasMaxLength(150);

                entity.Property(e => e.Ответственный).HasMaxLength(150);

                entity.Property(e => e.Откуда).HasMaxLength(100);

                entity.Property(e => e.Пользователь).HasMaxLength(50);

                entity.Property(e => e.СерийныйНомер)
                    .HasColumnName("Серийный номер")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MessageWeb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("messageWeb", "dbo");

                entity.Property(e => e.Author)
                    .HasColumnName("author")
                    .HasMaxLength(100);

                entity.Property(e => e.GroupAccess)
                    .HasColumnName("groupAccess")
                    .HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasMaxLength(50);

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(1000);

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NotificationTelegram>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NotificationTelegram", "u0554110_romi99");

                entity.Property(e => e.Aup).HasColumnName("AUP");

                entity.Property(e => e.ChatId).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.OtherGroup).HasMaxLength(50);

                entity.Property(e => e.TimeAdd)
                    .HasColumnName("timeAdd")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<PeopelMoneyParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Peopel_Money_Param", "u0554110_romi99");

                entity.Property(e => e.AllSumm).HasColumnName("allSumm");

                entity.Property(e => e.F8FilmKoof).HasColumnName("F8_Film_Koof");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Inch).HasColumnName("inch");

                entity.Property(e => e.ProyavshchikOutKoof).HasColumnName("Proyavshchik_Out_Koof");

                entity.Property(e => e.Summ).HasColumnName("summ");

                entity.Property(e => e.VrezkaKoof).HasColumnName("Vrezka_Koof");
            });

            modelBuilder.Entity<PersonalTransport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PersonalTransport", "u0554110_romi99");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.Дата).HasColumnType("date");

                entity.Property(e => e.ИдПерсонал).HasColumnName("Ид Персонал");

                entity.Property(e => e.Коментарий).HasMaxLength(500);

                entity.Property(e => e.Куда).HasMaxLength(200);

                entity.Property(e => e.Откуда).HasMaxLength(200);

                entity.Property(e => e.Почта).HasMaxLength(50);

                entity.Property(e => e.Фио)
                    .HasColumnName("ФИО")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ReportsMailFromCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ReportsMailFromCustomer", "u0554110_romi99");

                entity.Property(e => e.AttachPath)
                    .HasColumnName("attachPath")
                    .HasMaxLength(500);

                entity.Property(e => e.ClientPc)
                    .HasColumnName("ClientPC")
                    .HasMaxLength(1050);

                entity.Property(e => e.Customer).HasMaxLength(50);

                entity.Property(e => e.DataBaseName).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MailHtmlData).HasColumnName("mailHtmlData");

                entity.Property(e => e.Operator).HasMaxLength(50);

                entity.Property(e => e.SenderHost)
                    .HasColumnName("senderHost")
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(250);

                entity.Property(e => e.TableName).HasMaxLength(50);

                entity.Property(e => e.Theme).HasMaxLength(250);

                entity.Property(e => e.TimeAdd)
                    .HasColumnName("timeAdd")
                    .HasColumnType("datetime");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RequestTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RequestTable", "u0554110_romi99");

                entity.Property(e => e.DataBaseName).HasMaxLength(150);

                entity.Property(e => e.Guid).HasMaxLength(50);

                entity.Property(e => e.HashFile).HasMaxLength(500);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Operator).HasMaxLength(150);

                entity.Property(e => e.ReqestName).HasMaxLength(250);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(150);

                entity.Property(e => e.TableName).HasMaxLength(150);

                entity.Property(e => e.TimeEndServer).HasColumnType("datetime");

                entity.Property(e => e.TimeStartServer).HasColumnType("datetime");

                entity.Property(e => e.НовыеЗаписи).HasColumnName("Новые записи");

                entity.Property(e => e.ОбновлённыеЗаписи).HasColumnName("Обновлённые записи");

                entity.Property(e => e.Процедура).HasMaxLength(150);
            });

            modelBuilder.Entity<ReshootDeleted>(entity =>
            {
                entity.ToTable("RESHOOT_Deleted", "u0554110_romi99");

                entity.Property(e => e.AllSumm).HasMaxLength(100);

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.FilmSize).HasMaxLength(100);

                entity.Property(e => e.FilmType).HasMaxLength(50);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.TimeLastChange)
                    .HasColumnName("time_last_change")
                    .HasColumnType("datetime");

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.АктаПередачи).HasColumnName("№ Акта передачи");

                entity.Property(e => e.ДатаАктаПередачи)
                    .HasColumnName("Дата акта передачи")
                    .HasColumnType("date");

                entity.Property(e => e.ДатаДобавленияВБд)
                    .HasColumnName("Дата добавления в БД")
                    .HasColumnType("datetime");

                entity.Property(e => e.ДатаДобавленияЗаявки)
                    .HasColumnName("Дата добавления заявки")
                    .HasColumnType("datetime");

                entity.Property(e => e.ДатаПроведенияКонтроля)
                    .HasColumnName("Дата проведения контроля")
                    .HasColumnType("date");

                entity.Property(e => e.Заказчик).HasMaxLength(300);

                entity.Property(e => e.Заключения)
                    .HasColumnName("№ Заключения")
                    .HasMaxLength(200);

                entity.Property(e => e.Заявки)
                    .HasColumnName("№ заявки")
                    .HasMaxLength(150);

                entity.Property(e => e.ИдТаблицы).HasColumnName("Ид Таблицы");

                entity.Property(e => e.КлеймаДефОв)
                    .HasColumnName("Клейма деф-ов")
                    .HasMaxLength(200);

                entity.Property(e => e.Коментарий).HasMaxLength(500);

                entity.Property(e => e.КоробкиХранения)
                    .HasColumnName("№ Коробки хранения")
                    .HasMaxLength(100);

                entity.Property(e => e.Линия).HasMaxLength(100);

                entity.Property(e => e.ЛогинОператора)
                    .HasColumnName("Логин оператора")
                    .HasMaxLength(100);

                entity.Property(e => e.Локация).HasMaxLength(50);

                entity.Property(e => e.НомерДоговора)
                    .HasColumnName("Номер договора")
                    .HasMaxLength(50);

                entity.Property(e => e.Причина).HasMaxLength(100);

                entity.Property(e => e.ПричинаУдаления)
                    .HasColumnName("Причина удаления")
                    .HasMaxLength(1000);

                entity.Property(e => e.Результат).HasMaxLength(50);

                entity.Property(e => e.СвСоединения)
                    .HasColumnName("№ Св. соединения")
                    .HasMaxLength(50);

                entity.Property(e => e.Таблица).HasMaxLength(100);

                entity.Property(e => e.ФактДиаметр)
                    .HasColumnName("Факт диаметр")
                    .HasMaxLength(20);

                entity.Property(e => e.ФактТолщина)
                    .HasColumnName("Факт толщина")
                    .HasMaxLength(20);

                entity.Property(e => e.ФактическаяДлинаКонтроля).HasColumnName("Фактическая длина контроля");

                entity.Property(e => e.Чертёж).HasMaxLength(100);
            });

            modelBuilder.Entity<ReshootRt>(entity =>
            {
                entity.HasKey(e => e.Код)
                    .HasName("PK__RESHOOT___AE76132E100D4D02");

                entity.ToTable("RESHOOT_RT", "u0554110_romi99");

                entity.Property(e => e.AllSumm).HasMaxLength(300);

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.FilmSize).HasMaxLength(100);

                entity.Property(e => e.FilmType).HasMaxLength(50);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.TimeLastChange)
                    .HasColumnName("time_last_change")
                    .HasColumnType("datetime");

                entity.Property(e => e.WeldSumm).HasMaxLength(300);

                entity.Property(e => e.АктаПередачи).HasColumnName("№ Акта передачи");

                entity.Property(e => e.ДатаАктаПередачи)
                    .HasColumnName("Дата акта передачи")
                    .HasColumnType("date");

                entity.Property(e => e.ДатаДобавленияВБд)
                    .HasColumnName("Дата добавления в БД")
                    .HasColumnType("datetime");

                entity.Property(e => e.ДатаДобавленияЗаявки)
                    .HasColumnName("Дата добавления заявки")
                    .HasColumnType("datetime");

                entity.Property(e => e.ДатаПроведенияКонтроля)
                    .HasColumnName("Дата проведения контроля")
                    .HasColumnType("date");

                entity.Property(e => e.Заказчик).HasMaxLength(300);

                entity.Property(e => e.Заключения)
                    .HasColumnName("№ Заключения")
                    .HasMaxLength(200);

                entity.Property(e => e.Заявки)
                    .HasColumnName("№ заявки")
                    .HasMaxLength(150);

                entity.Property(e => e.ИдТаблицы).HasColumnName("Ид Таблицы");

                entity.Property(e => e.КлеймаДефОв)
                    .HasColumnName("Клейма деф-ов")
                    .HasMaxLength(200);

                entity.Property(e => e.Коментарий).HasMaxLength(500);

                entity.Property(e => e.КоробкиХранения)
                    .HasColumnName("№ Коробки хранения")
                    .HasMaxLength(100);

                entity.Property(e => e.Линия).HasMaxLength(100);

                entity.Property(e => e.ЛогинОператора)
                    .HasColumnName("Логин оператора")
                    .HasMaxLength(100);

                entity.Property(e => e.Локация).HasMaxLength(50);

                entity.Property(e => e.НомерДоговора)
                    .HasColumnName("Номер договора")
                    .HasMaxLength(50);

                entity.Property(e => e.Причина).HasMaxLength(300);

                entity.Property(e => e.Результат).HasMaxLength(50);

                entity.Property(e => e.СвСоединения)
                    .HasColumnName("№ Св. соединения")
                    .HasMaxLength(50);

                entity.Property(e => e.Таблица).HasMaxLength(1000);

                entity.Property(e => e.ФактДиаметр)
                    .HasColumnName("Факт диаметр")
                    .HasMaxLength(20);

                entity.Property(e => e.ФактТолщина)
                    .HasColumnName("Факт толщина")
                    .HasMaxLength(20);

                entity.Property(e => e.ФактическаяДлинаКонтроля).HasColumnName("Фактическая длина контроля");

                entity.Property(e => e.Чертёж).HasMaxLength(100);
            });

            modelBuilder.Entity<RolePermissions>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PermissionId).HasColumnName("Permission_Id");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sizeasme>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SIZEASME", "dbo");

                entity.Property(e => e.DiamIn).HasColumnName("Diam_in");

                entity.Property(e => e.DiamOff).HasColumnName("Diam_Off");

                entity.Property(e => e.NominalSize)
                    .HasColumnName("Nominal_Size")
                    .HasMaxLength(255);

                entity.Property(e => e.Sch10).HasColumnName("SCH10");

                entity.Property(e => e.Sch100).HasColumnName("SCH100");

                entity.Property(e => e.Sch120).HasColumnName("SCH120");

                entity.Property(e => e.Sch140).HasColumnName("SCH140");

                entity.Property(e => e.Sch160).HasColumnName("SCH160");

                entity.Property(e => e.Sch20).HasColumnName("SCH20");

                entity.Property(e => e.Sch30).HasColumnName("SCH30");

                entity.Property(e => e.Sch40).HasColumnName("SCH40");

                entity.Property(e => e.Sch60).HasColumnName("SCH60");

                entity.Property(e => e.Sch80).HasColumnName("SCH80");

                entity.Property(e => e.Std).HasColumnName("STD");

                entity.Property(e => e.Xs).HasColumnName("XS");

                entity.Property(e => e.Xxs).HasColumnName("XXS");

                entity.Property(e => e._0562).HasColumnName("0,562");

                entity.Property(e => e._0625).HasColumnName("0,625");

                entity.Property(e => e._0688).HasColumnName("0,688");

                entity.Property(e => e._0812).HasColumnName("0,812");

                entity.Property(e => e._0844).HasColumnName("0,844");

                entity.Property(e => e._0938).HasColumnName("0,938");

                entity.Property(e => e._1000).HasColumnName("1,000");

                entity.Property(e => e._10s).HasColumnName("10S");

                entity.Property(e => e._40s).HasColumnName("40S");

                entity.Property(e => e._5s).HasColumnName("5S");

                entity.Property(e => e._80s).HasColumnName("80S");
            });

            modelBuilder.Entity<StObraz>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StObraz", "u0554110_romi99");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MetodNk)
                    .HasColumnName("MetodNK")
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Nomer).HasMaxLength(50);

                entity.Property(e => e.SertData).HasColumnType("date");

                entity.Property(e => e.SertNomer).HasMaxLength(50);

                entity.Property(e => e.SertValidData).HasColumnType("date");
            });

            modelBuilder.Entity<Steels>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Steels", "u0554110_romi99");

                entity.Property(e => e.C)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Cr)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Cu)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ElementName).HasMaxLength(50);

                entity.Property(e => e.ElementRu).HasMaxLength(50);

                entity.Property(e => e.Hbdo)
                    .HasColumnName("HBdo")
                    .HasMaxLength(50);

                entity.Property(e => e.Hbot)
                    .HasColumnName("HBot")
                    .HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Mn)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Mo)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Ni)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ObjectLocation).HasMaxLength(50);

                entity.Property(e => e.Si)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SteelName).HasMaxLength(50);

                entity.Property(e => e.Ti)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.V)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TableActionList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TableActionList", "u0554110_romi99");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.DataAdd).HasColumnType("date");

                entity.Property(e => e.DatabaseName).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Partition).HasMaxLength(150);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(150);

                entity.Property(e => e.ИмяСписка)
                    .HasColumnName("Имя списка")
                    .HasMaxLength(350);

                entity.Property(e => e.Таблица).HasMaxLength(150);
            });

            modelBuilder.Entity<TableMobileChekin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TableMobileChekin", "u0554110_romi99");

                entity.Property(e => e.Action).HasMaxLength(250);

                entity.Property(e => e.ActionId).HasMaxLength(50);

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.DataAdd).HasColumnType("datetime");

                entity.Property(e => e.DataBaseName).HasMaxLength(150);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MobileGeolocation).HasMaxLength(250);

                entity.Property(e => e.TableName).HasMaxLength(150);

                entity.Property(e => e.UserName).HasMaxLength(150);
            });

            modelBuilder.Entity<TableSms>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TableSMS", "u0554110_romi99");

                entity.Property(e => e.DataAdd)
                    .HasColumnName("dataAdd")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50);

                entity.Property(e => e.ResponseId)
                    .HasColumnName("responseId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsetext)
                    .HasColumnName("responsetext")
                    .HasMaxLength(150);

                entity.Property(e => e.SendMessage)
                    .HasColumnName("sendMessage")
                    .HasMaxLength(500);

                entity.Property(e => e.SenderUsername)
                    .HasColumnName("senderUsername")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.Property(e => e.ToSendUsername)
                    .HasColumnName("toSendUsername")
                    .HasMaxLength(50);

                entity.Property(e => e.СтатусДоставки)
                    .HasColumnName("Статус доставки")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<UsersCallBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UsersCallBack", "u0554110_romi99");

                entity.Property(e => e.DataAdd).HasColumnType("datetime");

                entity.Property(e => e.FromUserName).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Message).HasMaxLength(300);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Theme).HasMaxLength(150);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<UsersRolle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UsersRolle", "u0554110_romi99");

                entity.Property(e => e.HashId)
                    .HasColumnName("HashID")
                    .HasMaxLength(250);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.Группа).HasMaxLength(50);

                entity.Property(e => e.ИмяРоли)
                    .HasColumnName("Имя роли")
                    .HasMaxLength(250);

                entity.Property(e => e.МинУровень).HasColumnName("Мин уровень");

                entity.Property(e => e.Ответственность).HasMaxLength(500);
            });

            modelBuilder.Entity<UtPep>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UT_PEP", "u0554110_romi99");

                entity.Property(e => e.Freq).HasMaxLength(50);

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdMash).HasColumnName("id_mash");

                entity.Property(e => e.Logger)
                    .HasColumnName("logger")
                    .HasMaxLength(500);

                entity.Property(e => e.Sert).HasMaxLength(50);

                entity.Property(e => e.SertValidDate).HasColumnType("date");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Ugol).HasMaxLength(50);
            });

            modelBuilder.Entity<UtSop>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UT_SOP", "u0554110_romi99");

                entity.Property(e => e.Form)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdMash).HasColumnName("id_mash");

                entity.Property(e => e.Logger)
                    .HasColumnName("logger")
                    .HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nomer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sert).HasMaxLength(50);

                entity.Property(e => e.SertValidDate).HasColumnType("date");

                entity.Property(e => e.Size)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Srej).HasMaxLength(50);
            });

            modelBuilder.Entity<Weater>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Weater", "u0554110_romi99");

                entity.Property(e => e.Dataaddinbd)
                    .HasColumnName("dataaddinbd")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Humidity)
                    .HasColumnName("humidity")
                    .HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.JsonMy).HasColumnName("jsonMy");

                entity.Property(e => e.JsonSourse).HasColumnName("json_sourse");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(50);

                entity.Property(e => e.LocationId)
                    .HasColumnName("location_id")
                    .HasMaxLength(50);

                entity.Property(e => e.Locations).HasMaxLength(50);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.Pressure)
                    .HasColumnName("pressure")
                    .HasMaxLength(50);

                entity.Property(e => e.Temp)
                    .HasColumnName("temp")
                    .HasMaxLength(50);

                entity.Property(e => e.TempMax)
                    .HasColumnName("temp_max")
                    .HasMaxLength(50);

                entity.Property(e => e.TempMin)
                    .HasColumnName("temp_min")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<YandexEmailRefresh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("YandexEmailRefresh", "u0554110_romi99");

                entity.Property(e => e.DataAdd)
                    .HasColumnName("dataAdd")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(250);

                entity.Property(e => e.ResponseText).HasColumnName("responseText");

                entity.Property(e => e.UsernameSender)
                    .HasColumnName("usernameSender")
                    .HasMaxLength(50);

                entity.Property(e => e.UsernameToSend)
                    .HasColumnName("usernameToSend")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<_1cTableWorkers>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("1C_tableWorkers", "u0554110_romi99");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.АдресПроживания).HasColumnName("Адрес проживания");

                entity.Property(e => e.АдресПрописка).HasColumnName("Адрес прописка");

                entity.Property(e => e.ВидПаспорта).HasColumnName("Вид паспорта");

                entity.Property(e => e.ВидТрудовогоДоговора).HasColumnName("Вид трудового договора");

                entity.Property(e => e.ВоинскаяГодность).HasColumnName("Воинская годность");

                entity.Property(e => e.ВоинскаяОбязанность).HasColumnName("Воинская обязанность");

                entity.Property(e => e.ВоинскийСостав).HasColumnName("Воинский состав");

                entity.Property(e => e.ВоинскийУчет).HasColumnName("Воинский учет");

                entity.Property(e => e.ВоинскоеЗвание).HasColumnName("Воинское звание");

                entity.Property(e => e.Вус).HasColumnName("ВУС");

                entity.Property(e => e.ДатаВыдачи)
                    .HasColumnName("Дата выдачи")
                    .HasColumnType("date");

                entity.Property(e => e.ДатаОкончанияТрудовогоДоговора)
                    .HasColumnName("Дата окончания трудового договора")
                    .HasColumnType("date");

                entity.Property(e => e.ДатаПоследнегоОбновления)
                    .HasColumnName("Дата последнего обновления")
                    .HasColumnType("datetime");

                entity.Property(e => e.ДатаРождения)
                    .HasColumnName("Дата рождения")
                    .HasColumnType("date");

                entity.Property(e => e.ДатаТрудовогоДоговора)
                    .HasColumnName("Дата трудового договора")
                    .HasColumnType("date");

                entity.Property(e => e.КемВыдан).HasColumnName("Кем выдан");

                entity.Property(e => e.КодПодразделения).HasColumnName("Код подразделения");

                entity.Property(e => e.МестоРождения).HasColumnName("Место рождения");

                entity.Property(e => e.НомерПаспорта).HasColumnName("Номер паспорта");

                entity.Property(e => e.НомерТрудовогоДоговора).HasColumnName("Номер трудового договора");

                entity.Property(e => e.СерияПаспорта).HasColumnName("Серия паспорта");

                entity.Property(e => e.Фио).HasColumnName("ФИО");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
