using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Context.dbContext
{
    public partial class u0554110_rhiContext : DbContext
    {
        //public u0554110_rhiContext()
        //{
        //}

        public u0554110_rhiContext(DbContextOptions<u0554110_rhiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActTransferPdf> ActTransferPdf { get; set; }
        public virtual DbSet<AllTables> AllTables { get; set; }
        public virtual DbSet<Certificate> Certificate { get; set; }
        public virtual DbSet<CertificateDestructiveControl> CertificateDestructiveControl { get; set; }
        public virtual DbSet<CertificateElectroSecurity> CertificateElectroSecurity { get; set; }
        public virtual DbSet<CertificateOt> CertificateOt { get; set; }
        public virtual DbSet<CertificatePeopleEb> CertificatePeopleEb { get; set; }
        public virtual DbSet<CertificatePeopleOneS> CertificatePeopleOneS { get; set; }
        public virtual DbSet<CertificatePeopleOt> CertificatePeopleOt { get; set; }
        public virtual DbSet<CertificatePeoplePb> CertificatePeoplePb { get; set; }
        public virtual DbSet<CertificatePeoplePbproto> CertificatePeoplePbproto { get; set; }
        public virtual DbSet<CertificatePeoplePtm> CertificatePeoplePtm { get; set; }
        public virtual DbSet<CertificatePeopleRb> CertificatePeopleRb { get; set; }
        public virtual DbSet<CertificatePeopleVst> CertificatePeopleVst { get; set; }
        public virtual DbSet<CertificatePeopleVu> CertificatePeopleVu { get; set; }
        public virtual DbSet<CertificatePtm> CertificatePtm { get; set; }
        public virtual DbSet<CertificateRb> CertificateRb { get; set; }
        public virtual DbSet<CertificateVysota> CertificateVysota { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Def> Def { get; set; }
        public virtual DbSet<Diploma> Diploma { get; set; }
        public virtual DbSet<Ds> Ds { get; set; }
        public virtual DbSet<EmploymentСontract> EmploymentСontract { get; set; }
        public virtual DbSet<HtRhiAg> HtRhiAg { get; set; }
        public virtual DbSet<HtYAg> HtYAg { get; set; }
        public virtual DbSet<Id> Id { get; set; }
        public virtual DbSet<MatOtvetstvennost> MatOtvetstvennost { get; set; }
        public virtual DbSet<MedicalExamination> MedicalExamination { get; set; }
        public virtual DbSet<MilitaryDocuments> MilitaryDocuments { get; set; }
        public virtual DbSet<NtdTable> NtdTable { get; set; }
        public virtual DbSet<ObjectsTable> ObjectsTable { get; set; }
        public virtual DbSet<OrderAppointment> OrderAppointment { get; set; }
        public virtual DbSet<OrderDismissal> OrderDismissal { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }
        public virtual DbSet<Pasports> Pasports { get; set; }
        public virtual DbSet<Pass> Pass { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }
        public virtual DbSet<Personal1> Personal1 { get; set; }
        public virtual DbSet<Personal2> Personal2 { get; set; }
        public virtual DbSet<PersonalAddres> PersonalAddres { get; set; }
        public virtual DbSet<PersonalPhones> PersonalPhones { get; set; }
        public virtual DbSet<PmiRhiAg> PmiRhiAg { get; set; }
        public virtual DbSet<PmiTable> PmiTable { get; set; }
        public virtual DbSet<Podrazdelenie> Podrazdelenie { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<PtControlObr> PtControlObr { get; set; }
        public virtual DbSet<PtKmmMkT> PtKmmMkT { get; set; }
        public virtual DbSet<PtPsMk> PtPsMk { get; set; }
        public virtual DbSet<PtRhiAg> PtRhiAg { get; set; }
        public virtual DbSet<PtRhiMk> PtRhiMk { get; set; }
        public virtual DbSet<PtRhiOzx> PtRhiOzx { get; set; }
        public virtual DbSet<PtRsp> PtRsp { get; set; }
        public virtual DbSet<PtSmuMk> PtSmuMk { get; set; }
        public virtual DbSet<PtSsr> PtSsr { get; set; }
        public virtual DbSet<PtYTank> PtYTank { get; set; }
        public virtual DbSet<RtAl> RtAl { get; set; }
        public virtual DbSet<RtEmm> RtEmm { get; set; }
        public virtual DbSet<RtEnr> RtEnr { get; set; }
        public virtual DbSet<RtEraK> RtEraK { get; set; }
        public virtual DbSet<RtIns> RtIns { get; set; }
        public virtual DbSet<RtKmmAg> RtKmmAg { get; set; }
        public virtual DbSet<RtMnt> RtMnt { get; set; }
        public virtual DbSet<RtMzAg> RtMzAg { get; set; }
        public virtual DbSet<RtOzxAg> RtOzxAg { get; set; }
        public virtual DbSet<RtPsAg> RtPsAg { get; set; }
        public virtual DbSet<RtRhiAg> RtRhiAg { get; set; }
        public virtual DbSet<RtRhiUg> RtRhiUg { get; set; }
        public virtual DbSet<RtRsp> RtRsp { get; set; }
        public virtual DbSet<RtSmm> RtSmm { get; set; }
        public virtual DbSet<RtSmu> RtSmu { get; set; }
        public virtual DbSet<RtSsr> RtSsr { get; set; }
        public virtual DbSet<RtTestRomi99> RtTestRomi99 { get; set; }
        public virtual DbSet<RtUwtUg> RtUwtUg { get; set; }
        public virtual DbSet<RtYAg> RtYAg { get; set; }
        public virtual DbSet<RtYLp> RtYLp { get; set; }
        public virtual DbSet<RtYTank> RtYTank { get; set; }
        public virtual DbSet<RtYUg> RtYUg { get; set; }
        public virtual DbSet<Texk> Texk { get; set; }
        public virtual DbSet<UtParam> UtParam { get; set; }
        public virtual DbSet<UtParam1> UtParam1 { get; set; }
        public virtual DbSet<UtPs> UtPs { get; set; }
        public virtual DbSet<UtRhiAg> UtRhiAg { get; set; }
        public virtual DbSet<UtRhiOzx> UtRhiOzx { get; set; }
        public virtual DbSet<UtSsr> UtSsr { get; set; }
        public virtual DbSet<UtYAg> UtYAg { get; set; }
        public virtual DbSet<UtYTank> UtYTank { get; set; }
        public virtual DbSet<VtAl> VtAl { get; set; }
        public virtual DbSet<VtAp> VtAp { get; set; }
        public virtual DbSet<VtEmm> VtEmm { get; set; }
        public virtual DbSet<VtEnr> VtEnr { get; set; }
        public virtual DbSet<VtEraK> VtEraK { get; set; }
        public virtual DbSet<VtIns> VtIns { get; set; }
        public virtual DbSet<VtKmmAg> VtKmmAg { get; set; }
        public virtual DbSet<VtKmmMkT> VtKmmMkT { get; set; }
        public virtual DbSet<VtMnt> VtMnt { get; set; }
        public virtual DbSet<VtMzAg> VtMzAg { get; set; }
        public virtual DbSet<VtPsAg> VtPsAg { get; set; }
        public virtual DbSet<VtPsMk> VtPsMk { get; set; }
        public virtual DbSet<VtRhiAg> VtRhiAg { get; set; }
        public virtual DbSet<VtRhiMk> VtRhiMk { get; set; }
        public virtual DbSet<VtRhiMkL> VtRhiMkL { get; set; }
        public virtual DbSet<VtRhiOzx> VtRhiOzx { get; set; }
        public virtual DbSet<VtRhiPe> VtRhiPe { get; set; }
        public virtual DbSet<VtRhiPs> VtRhiPs { get; set; }
        public virtual DbSet<VtRhiUg> VtRhiUg { get; set; }
        public virtual DbSet<VtRsp> VtRsp { get; set; }
        public virtual DbSet<VtSmm> VtSmm { get; set; }
        public virtual DbSet<VtSmu> VtSmu { get; set; }
        public virtual DbSet<VtSmuMk> VtSmuMk { get; set; }
        public virtual DbSet<VtSsr> VtSsr { get; set; }
        public virtual DbSet<VtUwtUg> VtUwtUg { get; set; }
        public virtual DbSet<VtYAg> VtYAg { get; set; }
        public virtual DbSet<VtYLp> VtYLp { get; set; }
        public virtual DbSet<VtYPe> VtYPe { get; set; }
        public virtual DbSet<VtYUg> VtYUg { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source=31.31.196.61;initial catalog=u0554110_rhi;integrated security=False;persist security info=False;user id=u0554110_smslWeb;password=3B40C41F-7D20-4B21-9D6A-61987F144CA9;trustservercertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "u0554110_smslWeb");

            modelBuilder.Entity<ActTransferPdf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActTransferPdf", "u0554110_romi99");

                entity.Property(e => e.Comment).HasMaxLength(1000);

                entity.Property(e => e.DataTimeAdd).HasColumnType("datetime");

                entity.Property(e => e.FullActName).HasMaxLength(1000);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Logger)
                    .HasColumnName("logger")
                    .HasMaxLength(1000);

                entity.Property(e => e.PathName).HasMaxLength(1000);

                entity.Property(e => e.TableName).HasMaxLength(150);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<AllTables>(entity =>
            {
                entity.ToTable("allTables", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(1000);

                entity.Property(e => e.Contract).HasMaxLength(300);

                entity.Property(e => e.ContractTable)
                    .HasColumnName("contractTable")
                    .HasMaxLength(100);

                entity.Property(e => e.Customer).HasMaxLength(250);

                entity.Property(e => e.DatabaseId)
                    .HasColumnName("databaseId")
                    .HasMaxLength(250);

                entity.Property(e => e.DatabaseName).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250);

                entity.Property(e => e.Inn)
                    .HasColumnName("inn")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Ipserver)
                    .HasColumnName("ipserver")
                    .HasMaxLength(250);

                entity.Property(e => e.Kpp)
                    .HasColumnName("kpp")
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.LabName).HasMaxLength(100);

                entity.Property(e => e.LastReportId)
                    .HasColumnName("LastReportID")
                    .HasMaxLength(100);

                entity.Property(e => e.Location).HasMaxLength(250);

                entity.Property(e => e.MetodControl)
                    .HasColumnName("metodControl")
                    .HasMaxLength(250);

                entity.Property(e => e.PriceUnit)
                    .HasColumnName("price_unit")
                    .HasMaxLength(50);

                entity.Property(e => e.PrintDocParametr).HasMaxLength(250);

                entity.Property(e => e.RepresentIdent)
                    .HasColumnName("Represent_IDent")
                    .HasMaxLength(50);

                entity.Property(e => e.RepresentName)
                    .HasColumnName("Represent_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.TableId).HasMaxLength(100);

                entity.Property(e => e.UnitName)
                    .HasColumnName("unit_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Webpage)
                    .HasColumnName("webpage")
                    .HasMaxLength(250);

                entity.Property(e => e.Мвз)
                    .HasColumnName("МВЗ")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Certificate>(entity =>
            {
                entity.HasKey(e => e.IdУдостоверение);

                entity.ToTable("Certificate", "dbo");

                entity.Property(e => e.IdУдостоверение).HasColumnName("ID Удостоверение");

                entity.Property(e => e.CertificatOneSid).HasColumnName("CertificatOneSID");

                entity.Property(e => e.Folder).HasMaxLength(150);

                entity.Property(e => e.IdПерсонал).HasColumnName("ID Персонал");

                entity.Property(e => e.Logger).HasMaxLength(500);

                entity.Property(e => e.Выдача).HasColumnType("date");

                entity.Property(e => e.ДатаИмпорта)
                    .HasColumnName("Дата импорта")
                    .HasColumnType("datetime");

                entity.Property(e => e.Коментарий).HasMaxLength(255);

                entity.Property(e => e.НомерУдостоверения)
                    .HasColumnName("Номер удостоверения")
                    .HasMaxLength(255);

                entity.Property(e => e.Окончание).HasColumnType("date");

                entity.Property(e => e.Организация).HasMaxLength(255);

                entity.Property(e => e.Тип).HasMaxLength(255);
            });

            modelBuilder.Entity<CertificateDestructiveControl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CertificateDestructiveControl", "dbo");

                entity.Property(e => e.IdПерсонал).HasColumnName("ID Персонал");

                entity.Property(e => e.IdУдостоверение)
                    .HasColumnName("ID Удостоверение")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ВнутренееНаименование)
                    .HasColumnName("Внутренее наименование")
                    .HasMaxLength(255);

                entity.Property(e => e.Выдача).HasColumnType("date");

                entity.Property(e => e.НомерУдостоверения)
                    .HasColumnName("Номер удостоверения")
                    .HasMaxLength(255);

                entity.Property(e => e.Окончание).HasColumnType("date");

                entity.Property(e => e.Организация).HasMaxLength(255);

                entity.Property(e => e.Тип).HasMaxLength(255);
            });

            modelBuilder.Entity<CertificateElectroSecurity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CertificateElectroSecurity", "dbo");

                entity.Property(e => e.IdПерсонал).HasColumnName("ID Персонал");

                entity.Property(e => e.IdУдостоверение)
                    .HasColumnName("ID Удостоверение")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Выдача).HasColumnType("date");

                entity.Property(e => e.Группа).HasMaxLength(255);

                entity.Property(e => e.ДатаПротокола)
                    .HasColumnName("Дата протокола")
                    .HasColumnType("date");

                entity.Property(e => e.Коментарий).HasMaxLength(255);

                entity.Property(e => e.НаименованиеУчебногоЦентра)
                    .HasColumnName("Наименование учебного центра")
                    .HasMaxLength(255);

                entity.Property(e => e.НомерПротокола)
                    .HasColumnName("Номер протокола")
                    .HasMaxLength(255);

                entity.Property(e => e.НомерУдостоверения)
                    .HasColumnName("Номер удостоверения")
                    .HasMaxLength(255);

                entity.Property(e => e.Окончание).HasColumnType("date");

                entity.Property(e => e.Организация).HasMaxLength(255);

                entity.Property(e => e.Тип).HasMaxLength(255);
            });

            modelBuilder.Entity<CertificateOt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CertificateOT", "dbo");

                entity.Property(e => e.IdПерсонал).HasColumnName("ID Персонал");

                entity.Property(e => e.IdУдостоверение)
                    .HasColumnName("ID Удостоверение")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Выдача).HasColumnType("date");

                entity.Property(e => e.ДатаПротокола)
                    .HasColumnName("Дата протокола")
                    .HasColumnType("date");

                entity.Property(e => e.КоличествоЧасов)
                    .HasColumnName("Количество часов")
                    .HasMaxLength(255);

                entity.Property(e => e.Коментарий).HasMaxLength(255);

                entity.Property(e => e.НаименованиеУчебногоЦентра)
                    .HasColumnName("Наименование учебного центра")
                    .HasMaxLength(255);

                entity.Property(e => e.НомерПротокола)
                    .HasColumnName("Номер протокола")
                    .HasMaxLength(255);

                entity.Property(e => e.НомерУдостоверения)
                    .HasColumnName("Номер удостоверения")
                    .HasMaxLength(255);

                entity.Property(e => e.Окончание).HasColumnType("date");

                entity.Property(e => e.Организация).HasMaxLength(255);

                entity.Property(e => e.Тип).HasMaxLength(255);
            });

            modelBuilder.Entity<CertificatePeopleEb>(entity =>
            {
                entity.ToTable("CertificatePeopleEB", "u0554110_romi99");

                entity.Property(e => e.DataAdd).HasColumnType("datetime");

                entity.Property(e => e.IdPersonal).HasColumnName("Id Personal");

                entity.Property(e => e.Logger)
                    .HasColumnName("logger")
                    .HasMaxLength(150);

                entity.Property(e => e.АтестационныйЦентр).HasMaxLength(250);

                entity.Property(e => e.ГруппаБезопасности).HasMaxLength(50);

                entity.Property(e => e.ДатаВыдачи).HasColumnType("date");

                entity.Property(e => e.ДатаОкончания).HasColumnType("date");

                entity.Property(e => e.Должность).HasMaxLength(150);

                entity.Property(e => e.КлассНапряжения).HasMaxLength(50);

                entity.Property(e => e.НомерСертификата)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Организация).HasMaxLength(150);

                entity.Property(e => e.ОрганизацияИнн)
                    .HasColumnName("ОрганизацияИНН")
                    .HasMaxLength(150);

                entity.Property(e => e.Сотрудник).HasMaxLength(150);
            });

            modelBuilder.Entity<CertificatePeopleOneS>(entity =>
            {
                entity.ToTable("CertificatePeopleOneS", "u0554110_romi99");

                entity.Property(e => e.CertNomer)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(250);

                entity.Property(e => e.PersonalId).HasColumnName("PersonalID");

                entity.Property(e => e.АттестационныйЦентр).HasMaxLength(350);

                entity.Property(e => e.ДатаВыдачи).HasColumnType("date");

                entity.Property(e => e.Фио)
                    .HasColumnName("ФИО")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<CertificatePeopleOt>(entity =>
            {
                entity.ToTable("CertificatePeopleOT", "u0554110_romi99");

                entity.Property(e => e.DataAdd).HasColumnType("datetime");

                entity.Property(e => e.IdPersonal).HasColumnName("Id Personal");

                entity.Property(e => e.Logger)
                    .HasColumnName("logger")
                    .HasMaxLength(150);

                entity.Property(e => e.АтестационныйЦентр).HasMaxLength(250);

                entity.Property(e => e.ДатаВыдачи).HasColumnType("date");

                entity.Property(e => e.ДатаОкончания).HasColumnType("date");

                entity.Property(e => e.Должность).HasMaxLength(150);

                entity.Property(e => e.КоличествоЧасовОбучения).HasMaxLength(50);

                entity.Property(e => e.НомерСертификата)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Организация).HasMaxLength(150);

                entity.Property(e => e.ОрганизацияИнн)
                    .HasColumnName("ОрганизацияИНН")
                    .HasMaxLength(150);

                entity.Property(e => e.Сотрудник).HasMaxLength(150);
            });

            modelBuilder.Entity<CertificatePeoplePb>(entity =>
            {
                entity.ToTable("CertificatePeoplePB", "u0554110_romi99");

                entity.Property(e => e.CertNomer)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(250);

                entity.Property(e => e.Logger)
                    .HasColumnName("logger")
                    .HasMaxLength(250);

                entity.Property(e => e.PersonalId).HasColumnName("PersonalID");

                entity.Property(e => e.АттестационныйЦентр).HasMaxLength(250);

                entity.Property(e => e.ДатаВыдачи).HasColumnType("date");

                entity.Property(e => e.ДатаОкончания).HasColumnType("date");

                entity.Property(e => e.ОбъектыКонтроля).HasMaxLength(1000);

                entity.Property(e => e.Фио)
                    .HasColumnName("ФИО")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<CertificatePeoplePbproto>(entity =>
            {
                entity.ToTable("CertificatePeoplePBproto", "u0554110_romi99");

                entity.Property(e => e.DataAdd).HasColumnType("datetime");

                entity.Property(e => e.IdPersonal).HasColumnName("Id Personal");

                entity.Property(e => e.Logger)
                    .HasColumnName("logger")
                    .HasMaxLength(150);

                entity.Property(e => e.АтестационныйЦентр).HasMaxLength(250);

                entity.Property(e => e.ГруппаДопуска).HasMaxLength(50);

                entity.Property(e => e.ДатаВыдачи).HasColumnType("date");

                entity.Property(e => e.ДатаОкончания).HasColumnType("date");

                entity.Property(e => e.Должность).HasMaxLength(150);

                entity.Property(e => e.НомерСертификата)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Организация).HasMaxLength(250);

                entity.Property(e => e.ОрганизацияИнн)
                    .HasColumnName("ОрганизацияИНН")
                    .HasMaxLength(150);

                entity.Property(e => e.Сотрудник).HasMaxLength(150);
            });

            modelBuilder.Entity<CertificatePeoplePtm>(entity =>
            {
                entity.ToTable("CertificatePeoplePTM", "u0554110_romi99");

                entity.Property(e => e.DataAdd).HasColumnType("datetime");

                entity.Property(e => e.IdPersonal).HasColumnName("Id Personal");

                entity.Property(e => e.Logger)
                    .HasColumnName("logger")
                    .HasMaxLength(150);

                entity.Property(e => e.АтестационныйЦентр).HasMaxLength(250);

                entity.Property(e => e.ДатаВыдачи).HasColumnType("date");

                entity.Property(e => e.ДатаОкончания).HasColumnType("date");

                entity.Property(e => e.Должность).HasMaxLength(150);

                entity.Property(e => e.КоличествоЧасовОбучения).HasMaxLength(50);

                entity.Property(e => e.НомерСертификата)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Организация).HasMaxLength(150);

                entity.Property(e => e.ОрганизацияИнн)
                    .HasColumnName("ОрганизацияИНН")
                    .HasMaxLength(150);

                entity.Property(e => e.Сотрудник).HasMaxLength(150);
            });

            modelBuilder.Entity<CertificatePeopleRb>(entity =>
            {
                entity.ToTable("CertificatePeopleRB", "u0554110_romi99");

                entity.Property(e => e.DataAdd).HasColumnType("datetime");

                entity.Property(e => e.IdPersonal).HasColumnName("Id Personal");

                entity.Property(e => e.Logger)
                    .HasColumnName("logger")
                    .HasMaxLength(150);

                entity.Property(e => e.АтестационныйЦентр).HasMaxLength(250);

                entity.Property(e => e.ДатаВыдачи).HasColumnType("date");

                entity.Property(e => e.ДатаОкончания).HasColumnType("date");

                entity.Property(e => e.Должность).HasMaxLength(150);

                entity.Property(e => e.КоличествоЧасовОбучения).HasMaxLength(50);

                entity.Property(e => e.НомерСертификата)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Организация).HasMaxLength(150);

                entity.Property(e => e.ОрганизацияИнн)
                    .HasColumnName("ОрганизацияИНН")
                    .HasMaxLength(150);

                entity.Property(e => e.Сотрудник).HasMaxLength(150);
            });

            modelBuilder.Entity<CertificatePeopleVst>(entity =>
            {
                entity.ToTable("CertificatePeopleVST", "u0554110_romi99");

                entity.Property(e => e.DataAdd).HasColumnType("datetime");

                entity.Property(e => e.IdPersonal).HasColumnName("Id Personal");

                entity.Property(e => e.Logger)
                    .HasColumnName("logger")
                    .HasMaxLength(150);

                entity.Property(e => e.АтестационныйЦентр).HasMaxLength(250);

                entity.Property(e => e.ГруппаДопуска).HasMaxLength(50);

                entity.Property(e => e.ДатаВыдачи).HasColumnType("date");

                entity.Property(e => e.ДатаОкончания).HasColumnType("date");

                entity.Property(e => e.Должность).HasMaxLength(150);

                entity.Property(e => e.НомерСертификата)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Организация).HasMaxLength(250);

                entity.Property(e => e.ОрганизацияИнн)
                    .HasColumnName("ОрганизацияИНН")
                    .HasMaxLength(150);

                entity.Property(e => e.Сотрудник).HasMaxLength(150);
            });

            modelBuilder.Entity<CertificatePeopleVu>(entity =>
            {
                entity.ToTable("CertificatePeopleVU", "u0554110_romi99");

                entity.Property(e => e.Comment).HasMaxLength(250);

                entity.Property(e => e.DataAdd).HasColumnType("datetime");

                entity.Property(e => e.IdPersonal).HasColumnName("Id Personal");

                entity.Property(e => e.Json).HasMaxLength(1000);

                entity.Property(e => e.Logger)
                    .HasColumnName("logger")
                    .HasMaxLength(250);

                entity.Property(e => e.ДатаВыдачи).HasColumnType("date");

                entity.Property(e => e.ДатаОкончания).HasColumnType("date");

                entity.Property(e => e.Категории)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.НомерСертификата)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CertificatePtm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CertificatePTM", "dbo");

                entity.Property(e => e.IdПерсонал).HasColumnName("ID Персонал");

                entity.Property(e => e.IdУдостоверение)
                    .HasColumnName("ID Удостоверение")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Выдача).HasColumnType("date");

                entity.Property(e => e.ДатаПротокола)
                    .HasColumnName("Дата протокола")
                    .HasColumnType("date");

                entity.Property(e => e.Коментарий).HasMaxLength(255);

                entity.Property(e => e.НаименованиеУчебногоЦентра)
                    .HasColumnName("Наименование учебного центра")
                    .HasMaxLength(255);

                entity.Property(e => e.НомерПротокола)
                    .HasColumnName("Номер протокола")
                    .HasMaxLength(255);

                entity.Property(e => e.НомерУдостоверения)
                    .HasColumnName("Номер удостоверения")
                    .HasMaxLength(255);

                entity.Property(e => e.Окончание).HasColumnType("date");

                entity.Property(e => e.Организация).HasMaxLength(255);

                entity.Property(e => e.Тип).HasMaxLength(255);
            });

            modelBuilder.Entity<CertificateRb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CertificateRB", "dbo");

                entity.Property(e => e.IdПерсонал).HasColumnName("ID Персонал");

                entity.Property(e => e.IdУдостоверение)
                    .HasColumnName("ID Удостоверение")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Выдача).HasColumnType("date");

                entity.Property(e => e.ДатаПротокола)
                    .HasColumnName("Дата протокола")
                    .HasColumnType("date");

                entity.Property(e => e.Коментарий).HasMaxLength(255);

                entity.Property(e => e.НаименованиеУчебногоЦентра)
                    .HasColumnName("Наименование учебного центра")
                    .HasMaxLength(255);

                entity.Property(e => e.НомерПротокола)
                    .HasColumnName("Номер протокола")
                    .HasMaxLength(255);

                entity.Property(e => e.НомерУдостоверения)
                    .HasColumnName("Номер удостоверения")
                    .HasMaxLength(255);

                entity.Property(e => e.Окончание).HasColumnType("date");

                entity.Property(e => e.Организация).HasMaxLength(255);

                entity.Property(e => e.Тип).HasMaxLength(255);
            });

            modelBuilder.Entity<CertificateVysota>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CertificateVysota", "dbo");

                entity.Property(e => e.IdПерсонал).HasColumnName("ID Персонал");

                entity.Property(e => e.IdУдостоверение)
                    .HasColumnName("ID Удостоверение")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Выдача).HasColumnType("date");

                entity.Property(e => e.Группа).HasMaxLength(255);

                entity.Property(e => e.ДатаПротокола)
                    .HasColumnName("Дата протокола")
                    .HasColumnType("date");

                entity.Property(e => e.Коментарий).HasMaxLength(255);

                entity.Property(e => e.НаименованиеУчебногоЦентра)
                    .HasColumnName("Наименование учебного центра")
                    .HasMaxLength(255);

                entity.Property(e => e.НомерПротокола)
                    .HasColumnName("Номер протокола")
                    .HasMaxLength(255);

                entity.Property(e => e.НомерУдостоверения)
                    .HasColumnName("Номер удостоверения")
                    .HasMaxLength(255);

                entity.Property(e => e.Окончание).HasColumnType("date");

                entity.Property(e => e.Организация).HasMaxLength(255);

                entity.Property(e => e.Тип).HasMaxLength(255);
            });

            modelBuilder.Entity<Clients>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Clients", "dbo");

                entity.Property(e => e.BlanksName).HasMaxLength(200);

                entity.Property(e => e.CompanyName).HasMaxLength(600);

                entity.Property(e => e.ContractName).HasMaxLength(600);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Def>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Def", "dbo");

                entity.Property(e => e.DataIdentity).HasMaxLength(200);

                entity.Property(e => e.IdentityCard).HasMaxLength(200);

                entity.Property(e => e.LongName)
                    .HasColumnName("longName")
                    .HasMaxLength(200);

                entity.Property(e => e.SmallName)
                    .HasColumnName("smallName")
                    .HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Diploma>(entity =>
            {
                entity.HasKey(e => e.IdДиплом);

                entity.ToTable("Diploma", "dbo");

                entity.Property(e => e.IdДиплом).HasColumnName("ID Диплом");

                entity.Property(e => e.IdПерсонал).HasColumnName("ID Персонал");

                entity.Property(e => e.Выдан).HasColumnType("date");
            });

            modelBuilder.Entity<Ds>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DS", "dbo");

                entity.Property(e => e.DocId)
                    .HasColumnName("Doc_Id")
                    .HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле1).HasColumnType("sql_variant");

                entity.Property(e => e.Поле10).HasMaxLength(200);

                entity.Property(e => e.Поле11).HasMaxLength(200);

                entity.Property(e => e.Поле12).HasMaxLength(200);

                entity.Property(e => e.Поле13).HasMaxLength(200);

                entity.Property(e => e.Поле2).HasColumnType("sql_variant");

                entity.Property(e => e.Поле3).HasMaxLength(200);

                entity.Property(e => e.Поле4).HasMaxLength(200);

                entity.Property(e => e.Поле5).HasMaxLength(255);

                entity.Property(e => e.Поле6).HasMaxLength(255);

                entity.Property(e => e.Поле7).HasMaxLength(255);

                entity.Property(e => e.Поле8).HasMaxLength(255);

                entity.Property(e => e.Поле9).HasMaxLength(200);
            });

            modelBuilder.Entity<EmploymentСontract>(entity =>
            {
                entity.HasKey(e => e.IdДоговор);

                entity.ToTable("EmploymentСontract", "dbo");

                entity.Property(e => e.IdДоговор).HasColumnName("ID Договор");

                entity.Property(e => e.IdПерсонал).HasColumnName("ID Персонал");

                entity.Property(e => e.ДатаЗаключения)
                    .HasColumnName("Дата заключения")
                    .HasColumnType("date");

                entity.Property(e => e.ДатаОкончания)
                    .HasColumnName("Дата окончания")
                    .HasColumnType("date");

                entity.Property(e => e.Должность).HasMaxLength(500);

                entity.Property(e => e.Номер).HasMaxLength(50);

                entity.Property(e => e.Организация).HasMaxLength(500);

                entity.Property(e => e.Статус).HasMaxLength(50);

                entity.Property(e => e.ТипДоговора)
                    .HasColumnName("Тип договора")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HtRhiAg>(entity =>
            {
                entity.HasKey(e => e.Код)
                    .HasName("PK__HT_RHI_A__AE76132EDF533AA6");

                entity.ToTable("HT_RHI_AG", "u0554110_romi99");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(300);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<HtYAg>(entity =>
            {
                entity.HasKey(e => e.Код)
                    .HasName("PK__HT_Y_AG__AE76132EEFD087CE");

                entity.ToTable("HT_Y_AG", "u0554110_romi99");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(300);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<Id>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("id", "u0554110_romi99");

                entity.Property(e => e.Adress).HasMaxLength(255);

                entity.Property(e => e.Bithday).HasColumnType("date");

                entity.Property(e => e.CertificationEkologBez)
                    .HasColumnName("Certification_Ekolog_Bez")
                    .HasMaxLength(255);

                entity.Property(e => e.CertificationElBez)
                    .HasColumnName("Certification_El_Bez")
                    .HasMaxLength(255);

                entity.Property(e => e.CertificationOt)
                    .HasColumnName("Certification_OT")
                    .HasMaxLength(255);

                entity.Property(e => e.CertificationPb)
                    .HasColumnName("Certification_PB")
                    .HasMaxLength(255);

                entity.Property(e => e.CertificationPervPom)
                    .HasColumnName("Certification_Perv_Pom")
                    .HasMaxLength(255);

                entity.Property(e => e.CertificationPtm)
                    .HasColumnName("Certification_PTM")
                    .HasMaxLength(255);

                entity.Property(e => e.CertificationRb)
                    .HasColumnName("Certification_RB")
                    .HasMaxLength(255);

                entity.Property(e => e.CertificationRtn)
                    .HasColumnName("Certification_RTN")
                    .HasMaxLength(255);

                entity.Property(e => e.CertificationVisota)
                    .HasColumnName("Certification_Visota")
                    .HasMaxLength(255);

                entity.Property(e => e.DefId)
                    .HasColumnName("Def_id")
                    .HasMaxLength(255);

                entity.Property(e => e.DopObychenie)
                    .HasColumnName("Dop_obychenie")
                    .HasMaxLength(255);

                entity.Property(e => e.EMail)
                    .HasColumnName("E_mail")
                    .HasMaxLength(255);

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(255);

                entity.Property(e => e.GenPass).HasMaxLength(255);

                entity.Property(e => e.Id1)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MechIspitaniya)
                    .HasColumnName("Mech_Ispitaniya")
                    .HasMaxLength(255);

                entity.Property(e => e.MedOsmotr)
                    .HasColumnName("Med_Osmotr")
                    .HasMaxLength(255);

                entity.Property(e => e.MetodyAe)
                    .HasColumnName("Metody_AE")
                    .HasMaxLength(255);

                entity.Property(e => e.MetodyEk)
                    .HasColumnName("Metody_EK")
                    .HasMaxLength(255);

                entity.Property(e => e.MetodyMk)
                    .HasColumnName("Metody_MK")
                    .HasMaxLength(255);

                entity.Property(e => e.MetodyOk)
                    .HasColumnName("Metody_OK")
                    .HasMaxLength(255);

                entity.Property(e => e.MetodyOther)
                    .HasColumnName("Metody_Other")
                    .HasMaxLength(255);

                entity.Property(e => e.MetodyPvk)
                    .HasColumnName("Metody_PVK")
                    .HasMaxLength(255);

                entity.Property(e => e.MetodyPvt)
                    .HasColumnName("Metody_PVT")
                    .HasMaxLength(255);

                entity.Property(e => e.MetodyRk)
                    .HasColumnName("Metody_RK")
                    .HasMaxLength(255);

                entity.Property(e => e.MetodyTk)
                    .HasColumnName("Metody_TK")
                    .HasMaxLength(255);

                entity.Property(e => e.MetodyUzk)
                    .HasColumnName("Metody_UZK")
                    .HasMaxLength(255);

                entity.Property(e => e.MetodyVik)
                    .HasColumnName("Metody_VIK")
                    .HasMaxLength(255);

                entity.Property(e => e.Organization).HasMaxLength(255);

                entity.Property(e => e.Podrazdelenie).HasMaxLength(255);

                entity.Property(e => e.Position).HasMaxLength(255);

                entity.Property(e => e.Scaners).HasMaxLength(255);

                entity.Property(e => e.Telephone).HasMaxLength(255);

                entity.Property(e => e.TransNeft).HasMaxLength(255);
            });

            modelBuilder.Entity<MatOtvetstvennost>(entity =>
            {
                entity.HasKey(e => e.IdМатОтветственность);

                entity.ToTable("MatOtvetstvennost", "dbo");

                entity.Property(e => e.IdМатОтветственность).HasColumnName("ID МатОтветственность");

                entity.Property(e => e.IdПерсонал).HasColumnName("ID Персонал");

                entity.Property(e => e.Дата).HasColumnType("date");

                entity.Property(e => e.Номер).HasMaxLength(255);

                entity.Property(e => e.Организация).HasMaxLength(500);
            });

            modelBuilder.Entity<MedicalExamination>(entity =>
            {
                entity.HasKey(e => e.IdМО);

                entity.ToTable("Medical_Examination", "dbo");

                entity.Property(e => e.IdМО).HasColumnName("ID М/О");

                entity.Property(e => e.IdПерсонал).HasColumnName("ID Персонал");

                entity.Property(e => e.ВредныеФакторы)
                    .HasColumnName("Вредные факторы")
                    .HasMaxLength(255);

                entity.Property(e => e.Город).HasMaxLength(255);

                entity.Property(e => e.ДатаПрохождения)
                    .HasColumnName("Дата прохождения")
                    .HasColumnType("date");

                entity.Property(e => e.ДатаСледующегоПрохождения)
                    .HasColumnName("Дата следующего прохождения")
                    .HasColumnType("date");

                entity.Property(e => e.Коментарий).HasMaxLength(255);

                entity.Property(e => e.Организация).HasMaxLength(255);
            });

            modelBuilder.Entity<MilitaryDocuments>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MilitaryDocuments", "dbo");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdПерсонал).HasColumnName("ID Персонал");

                entity.Property(e => e.Дата).HasColumnType("date");

                entity.Property(e => e.Номер).HasMaxLength(500);

                entity.Property(e => e.ТипДокумента)
                    .HasColumnName("Тип документа")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<NtdTable>(entity =>
            {
                entity.ToTable("ntd_table", "u0554110_romi99");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GropTk)
                    .HasColumnName("GropTK")
                    .HasMaxLength(100);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(50);

                entity.Property(e => e.Logger)
                    .HasColumnName("logger")
                    .HasMaxLength(1000);

                entity.Property(e => e.Name).HasMaxLength(500);
            });

            modelBuilder.Entity<ObjectsTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("objects_table", "u0554110_romi99");

                entity.Property(e => e.AllTableId).HasColumnName("allTable_Id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Location).HasMaxLength(500);

                entity.Property(e => e.Logger).HasColumnName("logger");
            });

            modelBuilder.Entity<OrderAppointment>(entity =>
            {
                entity.HasKey(e => e.IdПриказ);

                entity.ToTable("OrderAppointment", "dbo");

                entity.Property(e => e.IdПриказ).HasColumnName("ID Приказ");

                entity.Property(e => e.IdПерсонал).HasColumnName("ID Персонал");

                entity.Property(e => e.Дата).HasColumnType("date");

                entity.Property(e => e.Номер).HasMaxLength(100);

                entity.Property(e => e.НомерДоговора)
                    .HasColumnName("Номер договора")
                    .HasMaxLength(100);

                entity.Property(e => e.Организация).HasMaxLength(500);

                entity.Property(e => e.Тип).HasMaxLength(150);
            });

            modelBuilder.Entity<OrderDismissal>(entity =>
            {
                entity.HasKey(e => e.IdПриказ);

                entity.ToTable("OrderDismissal", "dbo");

                entity.Property(e => e.IdПриказ).HasColumnName("ID приказ");

                entity.Property(e => e.IdДоговор).HasColumnName("ID Договор");

                entity.Property(e => e.IdПерсонал).HasColumnName("ID Персонал");

                entity.Property(e => e.ДатаУвольнения)
                    .HasColumnName("Дата увольнения")
                    .HasColumnType("date");

                entity.Property(e => e.Должность).HasMaxLength(500);

                entity.Property(e => e.НомерДоговора)
                    .HasColumnName("Номер договора")
                    .HasMaxLength(50);

                entity.Property(e => e.НомерПриказа)
                    .HasColumnName("Номер приказа")
                    .HasMaxLength(50);

                entity.Property(e => e.Организация).HasMaxLength(500);

                entity.Property(e => e.Статус).HasMaxLength(50);
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.HasKey(e => e.IdОрганизация);

                entity.ToTable("Organization", "dbo");

                entity.Property(e => e.IdОрганизация).HasColumnName("ID Организация");

                entity.Property(e => e.Организация).HasMaxLength(255);

                entity.Property(e => e.ПубличноеНаименование)
                    .HasColumnName("Публичное наименование")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Pasports>(entity =>
            {
                entity.HasKey(e => e.IdПаспорт);

                entity.ToTable("Pasports", "dbo");

                entity.Property(e => e.IdПаспорт).HasColumnName("ID Паспорт");

                entity.Property(e => e.IdПерсонал).HasColumnName("ID Персонал");

                entity.Property(e => e.ДатаВыдачи)
                    .HasColumnName("Дата выдачи")
                    .HasColumnType("date");

                entity.Property(e => e.КемВыдан)
                    .HasColumnName("Кем выдан")
                    .HasMaxLength(255);

                entity.Property(e => e.КодПодразделения)
                    .HasColumnName("Код подразделения")
                    .HasMaxLength(255);

                entity.Property(e => e.МестоРождения)
                    .HasColumnName("Место рождения")
                    .HasMaxLength(255);

                entity.Property(e => e.Прописка).HasMaxLength(255);

                entity.Property(e => e.Серия)
                    .HasColumnName("Серия №")
                    .HasMaxLength(255);

                entity.Property(e => e.ТипПаспорта)
                    .HasColumnName("Тип паспорта")
                    .HasMaxLength(20);

                entity.Property(e => e.ФактическийАдрес)
                    .HasColumnName("Фактический адрес")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Pass>(entity =>
            {
                entity.HasKey(e => e.Код);

                entity.ToTable("Pass", "dbo");

                entity.Property(e => e.AccessLevel).HasColumnName("Access_level");

                entity.Property(e => e.CompName).HasMaxLength(255);

                entity.Property(e => e.Company).HasMaxLength(300);

                entity.Property(e => e.DefGroup).HasMaxLength(150);

                entity.Property(e => e.Email).HasMaxLength(300);

                entity.Property(e => e.Login).HasMaxLength(255);

                entity.Property(e => e.MessageAdmin).HasColumnName("messageAdmin");

                entity.Property(e => e.Porol).HasMaxLength(255);

                entity.Property(e => e.Position).HasMaxLength(150);

                entity.Property(e => e.Read).HasMaxLength(50);

                entity.Property(e => e.StartPage).HasMaxLength(300);

                entity.Property(e => e.TimeInput)
                    .HasColumnName("time_input")
                    .HasColumnType("datetime");

                entity.Property(e => e.Write).HasMaxLength(50);
            });

            modelBuilder.Entity<People>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("People", "dbo");

                entity.Property(e => e.DateDo).HasColumnType("date");

                entity.Property(e => e.IdentyId)
                    .HasColumnName("Identy_id")
                    .HasMaxLength(200);

                entity.Property(e => e.LongName).HasMaxLength(200);

                entity.Property(e => e.MetodControl).HasMaxLength(100);

                entity.Property(e => e.ObjectControl).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.ToTable("Personal", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adress).HasMaxLength(255);

                entity.Property(e => e.Bithday).HasColumnType("date");

                entity.Property(e => e.CoefficientZp)
                    .HasColumnName("Coefficient_ZP")
                    .HasMaxLength(255);

                entity.Property(e => e.DataAdd).HasColumnType("datetime");

                entity.Property(e => e.DataEndingWorck)
                    .HasColumnName("Data_EndingWorck")
                    .HasColumnType("date");

                entity.Property(e => e.DataSatrtingWorck)
                    .HasColumnName("Data_SatrtingWorck")
                    .HasColumnType("date");

                entity.Property(e => e.DefId)
                    .HasColumnName("Def_id")
                    .HasMaxLength(255);

                entity.Property(e => e.EMail)
                    .HasColumnName("E_mail")
                    .HasMaxLength(255);

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupAccess).HasMaxLength(500);

                entity.Property(e => e.Id1c)
                    .HasColumnName("id 1C")
                    .HasMaxLength(255);

                entity.Property(e => e.MessageAdmin)
                    .HasColumnName("messageAdmin")
                    .HasMaxLength(500);

                entity.Property(e => e.Organization).HasMaxLength(255);

                entity.Property(e => e.Podrazdelenie).HasMaxLength(255);

                entity.Property(e => e.Position).HasMaxLength(255);

                entity.Property(e => e.Property).HasColumnName("property");

                entity.Property(e => e.PropertyJson).HasColumnName("PropertyJSON");

                entity.Property(e => e.StartPage)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Userstats')");

                entity.Property(e => e.StatusWorck).HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(255);

                entity.Property(e => e.TimeInput)
                    .HasColumnName("time_input")
                    .HasColumnType("datetime");

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

                entity.Property(e => e.СтатусРедактирования).HasColumnName("Статус редактирования");

                entity.Property(e => e.ТарифнаяСтавка).HasColumnName("Тарифная ставка");

                entity.Property(e => e.Участок).HasMaxLength(200);
            });

            modelBuilder.Entity<Personal1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Personal1", "dbo");

                entity.Property(e => e.Adress).HasMaxLength(255);

                entity.Property(e => e.Bithday).HasColumnType("date");

                entity.Property(e => e.Certification).HasMaxLength(255);

                entity.Property(e => e.DefId)
                    .HasColumnName("Def_id")
                    .HasMaxLength(255);

                entity.Property(e => e.DopObychenie)
                    .HasColumnName("Dop_obychenie")
                    .HasMaxLength(255);

                entity.Property(e => e.EMail)
                    .HasColumnName("E_mail")
                    .HasMaxLength(255);

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InstructPoTb)
                    .HasColumnName("Instruct_po_TB")
                    .HasMaxLength(255);

                entity.Property(e => e.MechIspitaniya)
                    .HasColumnName("Mech_Ispitaniya")
                    .HasMaxLength(255);

                entity.Property(e => e.MedOsmotrGram)
                    .HasColumnName("Med_osmotr_gram")
                    .HasMaxLength(255);

                entity.Property(e => e.MedOsmotrNew)
                    .HasColumnName("Med_osmotr_new")
                    .HasMaxLength(255);

                entity.Property(e => e.MetodyNk)
                    .HasColumnName("Metody_NK")
                    .HasMaxLength(255);

                entity.Property(e => e.NalichieObycheniyaPoDolgnosti)
                    .HasColumnName("Nalichie_obycheniya_po_dolgnosti")
                    .HasMaxLength(255);

                entity.Property(e => e.Organization).HasMaxLength(255);

                entity.Property(e => e.Podrazdelenie).HasMaxLength(255);

                entity.Property(e => e.Position).HasMaxLength(255);

                entity.Property(e => e.Scaners).HasMaxLength(255);

                entity.Property(e => e.Telephone).HasMaxLength(255);

                entity.Property(e => e.TransNeft).HasMaxLength(255);
            });

            modelBuilder.Entity<Personal2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Personal2", "dbo");

                entity.Property(e => e.Adress).HasMaxLength(255);

                entity.Property(e => e.Bithday).HasColumnType("date");

                entity.Property(e => e.CoefficientZp)
                    .HasColumnName("Coefficient_ZP")
                    .HasMaxLength(255);

                entity.Property(e => e.DataAdd).HasColumnType("datetime");

                entity.Property(e => e.DataEndingWorck)
                    .HasColumnName("Data_EndingWorck")
                    .HasColumnType("date");

                entity.Property(e => e.DataSatrtingWorck)
                    .HasColumnName("Data_SatrtingWorck")
                    .HasColumnType("date");

                entity.Property(e => e.DefId)
                    .HasColumnName("Def_id")
                    .HasMaxLength(255);

                entity.Property(e => e.EMail)
                    .HasColumnName("E_mail")
                    .HasMaxLength(255);

                entity.Property(e => e.Fio)
                    .HasColumnName("FIO")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupAccess).HasMaxLength(500);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Id1c)
                    .HasColumnName("id 1C")
                    .HasMaxLength(255);

                entity.Property(e => e.MessageAdmin)
                    .HasColumnName("messageAdmin")
                    .HasMaxLength(500);

                entity.Property(e => e.Organization).HasMaxLength(255);

                entity.Property(e => e.Podrazdelenie).HasMaxLength(255);

                entity.Property(e => e.Position).HasMaxLength(255);

                entity.Property(e => e.PropertyJson).HasColumnName("PropertyJSON");

                entity.Property(e => e.StartPage).HasMaxLength(50);

                entity.Property(e => e.StatusWorck).HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(255);

                entity.Property(e => e.TimeInput)
                    .HasColumnName("time_input")
                    .HasColumnType("datetime");

                entity.Property(e => e.Инн)
                    .HasColumnName("ИНН")
                    .HasMaxLength(255);

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

                entity.Property(e => e.СтатусРедактирования).HasColumnName("Статус редактирования");

                entity.Property(e => e.ТарифнаяСтавка).HasColumnName("Тарифная ставка");

                entity.Property(e => e.Участок).HasMaxLength(200);
            });

            modelBuilder.Entity<PersonalAddres>(entity =>
            {
                entity.ToTable("PersonalAddres", "u0554110_romi99");

                entity.Property(e => e.Addres).HasMaxLength(350);

                entity.Property(e => e.AddresType).HasMaxLength(50);

                entity.Property(e => e.Comment).HasMaxLength(350);

                entity.Property(e => e.IdPersonal).HasColumnName("Id Personal");
            });

            modelBuilder.Entity<PersonalPhones>(entity =>
            {
                entity.ToTable("PersonalPhones", "u0554110_romi99");

                entity.Property(e => e.Comment).HasMaxLength(150);

                entity.Property(e => e.IdPersonal).HasColumnName("Id Personal");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<PmiRhiAg>(entity =>
            {
                entity.HasKey(e => e.Код)
                    .HasName("PK__PMI_RHI___AE76132E3BB6956F");

                entity.ToTable("PMI_RHI_AG", "u0554110_romi99");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Electrod).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.Mat1).HasMaxLength(200);

                entity.Property(e => e.Mat2).HasMaxLength(200);

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldPr).HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(300);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<PmiTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PMI_Table", "dbo");

                entity.Property(e => e.Cr).HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.Mn).HasMaxLength(255);

                entity.Property(e => e.Mo).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Nb).HasMaxLength(255);

                entity.Property(e => e.Ni).HasMaxLength(255);

                entity.Property(e => e.Si).HasMaxLength(255);
            });

            modelBuilder.Entity<Podrazdelenie>(entity =>
            {
                entity.HasKey(e => e.IdПодразделение);

                entity.ToTable("Podrazdelenie", "dbo");

                entity.Property(e => e.IdПодразделение).HasColumnName("ID Подразделение");

                entity.Property(e => e.Подразделение).HasMaxLength(255);
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.ToTable("Position", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdОрганизация)
                    .HasColumnName("ID Организация")
                    .HasMaxLength(500);

                entity.Property(e => e.Должность).HasMaxLength(500);
            });

            modelBuilder.Entity<PtControlObr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pt_control_obr", "u0554110_romi99");

                entity.Property(e => e.DopuskDate).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Logger)
                    .HasColumnName("logger")
                    .HasMaxLength(500);

                entity.Property(e => e.MetodNk)
                    .HasColumnName("Metod_NK")
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.SertName)
                    .HasColumnName("Sert_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.ValidDate).HasMaxLength(50);
            });

            modelBuilder.Entity<PtKmmMkT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PT_KMM_MK_T", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(800);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(800);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId).HasColumnName("WeldID");

                entity.Property(e => e.WeldSumm).HasMaxLength(300);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<PtPsMk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PT_PS_MK", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(800);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(800);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId).HasColumnName("WeldID");

                entity.Property(e => e.WeldSumm).HasMaxLength(300);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<PtRhiAg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PT_RHI_AG", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(300);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<PtRhiMk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PT_RHI_MK", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(300);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<PtRhiOzx>(entity =>
            {
                entity.HasKey(e => e.Код)
                    .HasName("PK__PT_RHI_O__AE76132EAEB65E5B");

                entity.ToTable("PT_RHI_OZX", "u0554110_romi99");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<PtRsp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PT_RSP", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(100);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(300);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<PtSmuMk>(entity =>
            {
                entity.HasKey(e => e.Код)
                    .HasName("PK__PT_SMU_M__AE76132EE55A91D1");

                entity.ToTable("PT_SMU_MK", "u0554110_romi99");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<PtSsr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PT_SSR", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(300);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<PtYTank>(entity =>
            {
                entity.HasKey(e => e.Код)
                    .HasName("PK__PT_Y_TN__AE76132EC6FA0E5D");

                entity.ToTable("PT_Y_TANK", "u0554110_romi99");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(500);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(600);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(500);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(800);

                entity.Property(e => e.WeldSumm).HasMaxLength(300);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<RtAl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RT_AL", "dbo");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.Chuvstvitelnost).HasMaxLength(255);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company_Name")
                    .HasMaxLength(1000);

                entity.Property(e => e.DataAct).HasMaxLength(255);

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasMaxLength(200);

                entity.Property(e => e.DefId)
                    .HasColumnName("def_id")
                    .HasMaxLength(255);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Diam).HasMaxLength(50);

                entity.Property(e => e.Drawing).HasMaxLength(255);

                entity.Property(e => e.Element1).HasMaxLength(255);

                entity.Property(e => e.Element2).HasMaxLength(255);

                entity.Property(e => e.FilmSize).HasMaxLength(255);

                entity.Property(e => e.FilmType).HasMaxLength(300);

                entity.Property(e => e.KolSnimkov).HasColumnName("Kol_snimkov");

                entity.Property(e => e.KoordinatiRemonta)
                    .HasColumnName("Koordinati_Remonta")
                    .HasMaxLength(1000);

                entity.Property(e => e.Korobka).HasMaxLength(255);

                entity.Property(e => e.Line).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.NomerKontrUch)
                    .HasColumnName("Nomer_kontr_uch")
                    .HasMaxLength(255);

                entity.Property(e => e.Operator).HasMaxLength(255);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(255);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.RadiogramNo)
                    .HasColumnName("Radiogram_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Result).HasMaxLength(255);

                entity.Property(e => e.Rev).HasMaxLength(50);

                entity.Property(e => e.Sheet).HasMaxLength(50);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(50);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(50);

                entity.Property(e => e.WeldSumm).HasMaxLength(300);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(255);

                entity.Property(e => e.Zona).HasMaxLength(50);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле33).HasMaxLength(255);

                entity.Property(e => e.Поле34).HasMaxLength(255);
            });

            modelBuilder.Entity<RtEmm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RT_EMM", "dbo");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.Chuvstvitelnost).HasMaxLength(200);

                entity.Property(e => e.DataAct).HasColumnType("date");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefId)
                    .HasColumnName("def_id")
                    .HasMaxLength(200);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.FilmSize).HasMaxLength(200);

                entity.Property(e => e.FilmType).HasMaxLength(200);

                entity.Property(e => e.KolSnimkov).HasColumnName("Kol_snimkov");

                entity.Property(e => e.KoordinatiRemonta)
                    .HasColumnName("Koordinati_Remonta")
                    .HasMaxLength(1000);

                entity.Property(e => e.Korobka).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.NomerKontrUch)
                    .HasColumnName("Nomer_kontr_uch")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.RadiogramNo)
                    .HasColumnName("Radiogram_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(300);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Xray).HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле33).HasMaxLength(200);

                entity.Property(e => e.Поле34).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(1000);
            });

            modelBuilder.Entity<RtEnr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RT_ENR", "dbo");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.Chuvstvitelnost).HasMaxLength(200);

                entity.Property(e => e.DataAct).HasColumnType("date");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefId)
                    .HasColumnName("def_id")
                    .HasMaxLength(200);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FilmSize).HasMaxLength(200);

                entity.Property(e => e.FilmType).HasMaxLength(200);

                entity.Property(e => e.KolSnimkov).HasColumnName("Kol_snimkov");

                entity.Property(e => e.KoordinatiRemonta)
                    .HasColumnName("Koordinati_Remonta")
                    .HasMaxLength(1000);

                entity.Property(e => e.Korobka).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.NomerKontrUch)
                    .HasColumnName("Nomer_kontr_uch")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.RadiogramNo)
                    .HasColumnName("Radiogram_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(50);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Xray).HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле33).HasMaxLength(200);

                entity.Property(e => e.Поле34).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(1000);
            });

            modelBuilder.Entity<RtEraK>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RT_ERA_K", "dbo");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.Chuvstvitelnost).HasMaxLength(200);

                entity.Property(e => e.DataAct).HasColumnType("date");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefId)
                    .HasColumnName("def_id")
                    .HasMaxLength(200);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.FilmSize).HasMaxLength(200);

                entity.Property(e => e.FilmType).HasMaxLength(200);

                entity.Property(e => e.KolSnimkov).HasColumnName("Kol_snimkov");

                entity.Property(e => e.KoordinatiRemonta)
                    .HasColumnName("Koordinati_Remonta")
                    .HasMaxLength(1000);

                entity.Property(e => e.Korobka).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.NomerKontrUch)
                    .HasColumnName("Nomer_kontr_uch")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.RadiogramNo)
                    .HasColumnName("Radiogram_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(50);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Xray).HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле33).HasMaxLength(200);

                entity.Property(e => e.Поле34).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(1000);
            });

            modelBuilder.Entity<RtIns>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RT_INS", "dbo");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.Chuvstvitelnost).HasMaxLength(200);

                entity.Property(e => e.DataAct).HasColumnType("date");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefId)
                    .HasColumnName("def_id")
                    .HasMaxLength(200);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FilmSize).HasMaxLength(200);

                entity.Property(e => e.FilmType).HasMaxLength(200);

                entity.Property(e => e.KolSnimkov).HasColumnName("Kol_snimkov");

                entity.Property(e => e.KoordinatiRemonta)
                    .HasColumnName("Koordinati_Remonta")
                    .HasMaxLength(1000);

                entity.Property(e => e.Korobka).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.NomerKontrUch)
                    .HasColumnName("Nomer_kontr_uch")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.RadiogramNo)
                    .HasColumnName("Radiogram_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Xray).HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле33).HasMaxLength(200);

                entity.Property(e => e.Поле34).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(1000);
            });

            modelBuilder.Entity<RtKmmAg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RT_KMM_AG", "dbo");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.Chuvstvitelnost).HasMaxLength(255);

                entity.Property(e => e.DataAct).HasMaxLength(255);

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefId)
                    .HasColumnName("def_id")
                    .HasMaxLength(255);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Diam).HasColumnType("sql_variant");

                entity.Property(e => e.Drawing).HasMaxLength(255);

                entity.Property(e => e.Element1).HasMaxLength(255);

                entity.Property(e => e.Element2).HasMaxLength(255);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.FilmSize).HasMaxLength(255);

                entity.Property(e => e.FilmType).HasMaxLength(250);

                entity.Property(e => e.KolSnimkov).HasColumnName("Kol_snimkov");

                entity.Property(e => e.KoordinatiRemonta)
                    .HasColumnName("Koordinati_Remonta")
                    .HasMaxLength(255);

                entity.Property(e => e.Korobka).HasMaxLength(255);

                entity.Property(e => e.Line).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.NomerKontrUch)
                    .HasColumnName("Nomer_kontr_uch")
                    .HasMaxLength(255);

                entity.Property(e => e.Operator).HasMaxLength(255);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(255);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(255);

                entity.Property(e => e.RadiogramNo)
                    .HasColumnName("Radiogram_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Razbrakovka).HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Result).HasMaxLength(255);

                entity.Property(e => e.Rev).HasMaxLength(255);

                entity.Property(e => e.Sheet).HasMaxLength(255);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasColumnType("sql_variant");

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(255);

                entity.Property(e => e.Xray).HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(255);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле33).HasMaxLength(255);

                entity.Property(e => e.Поле34).HasMaxLength(255);

                entity.Property(e => e.Поле36).HasMaxLength(255);
            });

            modelBuilder.Entity<RtMnt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RT_MNT", "dbo");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.Chuvstvitelnost).HasMaxLength(200);

                entity.Property(e => e.DataAct).HasColumnType("date");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefId)
                    .HasColumnName("def_id")
                    .HasMaxLength(200);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FilmSize).HasMaxLength(200);

                entity.Property(e => e.FilmType).HasMaxLength(200);

                entity.Property(e => e.KolSnimkov).HasColumnName("Kol_snimkov");

                entity.Property(e => e.KoordinatiRemonta)
                    .HasColumnName("Koordinati_Remonta")
                    .HasMaxLength(1000);

                entity.Property(e => e.Korobka).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.NomerKontrUch)
                    .HasColumnName("Nomer_kontr_uch")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.RadiogramNo)
                    .HasColumnName("Radiogram_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Xray).HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле33).HasMaxLength(200);

                entity.Property(e => e.Поле34).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(1000);
            });

            modelBuilder.Entity<RtMzAg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RT_MZ_AG", "dbo");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.Chuvstvitelnost).HasMaxLength(255);

                entity.Property(e => e.DataAct).HasMaxLength(255);

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasMaxLength(255);

                entity.Property(e => e.DefId)
                    .HasColumnName("def_id")
                    .HasMaxLength(255);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Diam).HasColumnType("sql_variant");

                entity.Property(e => e.Drawing).HasMaxLength(255);

                entity.Property(e => e.Element1).HasMaxLength(255);

                entity.Property(e => e.Element2).HasMaxLength(255);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.FilmSize).HasMaxLength(255);

                entity.Property(e => e.FilmType).HasMaxLength(250);

                entity.Property(e => e.KolSnimkov).HasColumnName("Kol_snimkov");

                entity.Property(e => e.KoordinatiRemonta)
                    .HasColumnName("Koordinati_Remonta")
                    .HasMaxLength(255);

                entity.Property(e => e.Korobka).HasMaxLength(255);

                entity.Property(e => e.Line).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.NomerKontrUch)
                    .HasColumnName("Nomer_kontr_uch")
                    .HasMaxLength(255);

                entity.Property(e => e.Operator).HasMaxLength(255);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(255);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(255);

                entity.Property(e => e.RadiogramNo)
                    .HasColumnName("Radiogram_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Razbrakovka).HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Result).HasMaxLength(255);

                entity.Property(e => e.Rev).HasMaxLength(255);

                entity.Property(e => e.Sheet).HasMaxLength(255);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasColumnType("sql_variant");

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(50);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(255);

                entity.Property(e => e.Xray).HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(255);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле33).HasMaxLength(255);

                entity.Property(e => e.Поле34).HasMaxLength(255);

                entity.Property(e => e.Поле36).HasMaxLength(255);
            });

            modelBuilder.Entity<RtOzxAg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RT_OZX_AG", "dbo");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.Chuvstvitelnost).HasMaxLength(200);

                entity.Property(e => e.DataAct).HasColumnType("date");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefId)
                    .HasColumnName("def_id")
                    .HasMaxLength(200);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FilmSize).HasMaxLength(200);

                entity.Property(e => e.FilmType).HasMaxLength(200);

                entity.Property(e => e.KolSnimkov).HasColumnName("Kol_snimkov");

                entity.Property(e => e.KoordinatiRemonta)
                    .HasColumnName("Koordinati_Remonta")
                    .HasMaxLength(1000);

                entity.Property(e => e.Korobka).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.NomerKontrUch)
                    .HasColumnName("Nomer_kontr_uch")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.RadiogramNo)
                    .HasColumnName("Radiogram_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Xray).HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле33).HasMaxLength(200);

                entity.Property(e => e.Поле34).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(1000);
            });

            modelBuilder.Entity<RtPsAg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RT_PS_AG", "dbo");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.Chuvstvitelnost).HasMaxLength(255);

                entity.Property(e => e.DataAct).HasMaxLength(255);

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefId)
                    .HasColumnName("def_id")
                    .HasMaxLength(255);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Diam).HasColumnType("sql_variant");

                entity.Property(e => e.Drawing).HasMaxLength(255);

                entity.Property(e => e.Element1).HasMaxLength(255);

                entity.Property(e => e.Element2).HasMaxLength(255);

                entity.Property(e => e.FilmSize).HasMaxLength(255);

                entity.Property(e => e.FilmType).HasMaxLength(250);

                entity.Property(e => e.KolSnimkov).HasColumnName("Kol_snimkov");

                entity.Property(e => e.KoordinatiRemonta)
                    .HasColumnName("Koordinati_Remonta")
                    .HasMaxLength(255);

                entity.Property(e => e.Korobka).HasMaxLength(255);

                entity.Property(e => e.Line).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.NomerKontrUch)
                    .HasColumnName("Nomer_kontr_uch")
                    .HasMaxLength(255);

                entity.Property(e => e.Operator).HasMaxLength(255);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(255);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(255);

                entity.Property(e => e.RadiogramNo)
                    .HasColumnName("Radiogram_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Razbrakovka).HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Result).HasMaxLength(255);

                entity.Property(e => e.Rev).HasMaxLength(255);

                entity.Property(e => e.Sheet).HasMaxLength(255);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasColumnType("sql_variant");

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(50);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(255);

                entity.Property(e => e.Xray).HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(255);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле33).HasMaxLength(255);

                entity.Property(e => e.Поле34).HasMaxLength(255);

                entity.Property(e => e.Поле36).HasMaxLength(255);
            });

            modelBuilder.Entity<RtRhiAg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RT_RHI_AG", "dbo");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.Chuvstvitelnost).HasMaxLength(50);

                entity.Property(e => e.DataAct).HasColumnType("date");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefId)
                    .HasColumnName("def_id")
                    .HasMaxLength(100);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.Diam).HasColumnType("sql_variant");

                entity.Property(e => e.Drawing).HasMaxLength(50);

                entity.Property(e => e.Element1).HasMaxLength(30);

                entity.Property(e => e.Element2).HasMaxLength(30);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.FilmSize).HasMaxLength(255);

                entity.Property(e => e.FilmType).HasMaxLength(500);

                entity.Property(e => e.KolSnimkov).HasColumnName("Kol_snimkov");

                entity.Property(e => e.KoordinatiRemonta)
                    .HasColumnName("Koordinati_Remonta")
                    .HasMaxLength(255);

                entity.Property(e => e.Korobka).HasMaxLength(255);

                entity.Property(e => e.Line).HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(30);

                entity.Property(e => e.NomerKontrUch)
                    .HasColumnName("Nomer_kontr_uch")
                    .HasMaxLength(100);

                entity.Property(e => e.Operator).HasMaxLength(100);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(30);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(150);

                entity.Property(e => e.RadiogramNo)
                    .HasColumnName("Radiogram_No")
                    .HasMaxLength(100);

                entity.Property(e => e.Razbrakovka).HasMaxLength(500);

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(100);

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasColumnType("sql_variant");

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(30);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(30);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(20);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(30);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(30);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(30);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(30);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(30);

                entity.Property(e => e.Xray).HasMaxLength(150);

                entity.Property(e => e.Zona).HasMaxLength(20);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле33).HasMaxLength(50);

                entity.Property(e => e.Поле34).HasMaxLength(1000);

                entity.Property(e => e.Поле36).HasMaxLength(50);
            });

            modelBuilder.Entity<RtRhiUg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RT_RHI_UG", "dbo");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.Chuvstvitelnost).HasMaxLength(50);

                entity.Property(e => e.DataAct).HasColumnType("date");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefId)
                    .HasColumnName("def_id")
                    .HasMaxLength(255);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Diam).HasColumnType("sql_variant");

                entity.Property(e => e.Drawing).HasMaxLength(255);

                entity.Property(e => e.Element1).HasMaxLength(255);

                entity.Property(e => e.Element2).HasMaxLength(255);

                entity.Property(e => e.FilmSize).HasMaxLength(255);

                entity.Property(e => e.FilmType).HasMaxLength(300);

                entity.Property(e => e.KolSnimkov).HasColumnName("Kol_snimkov");

                entity.Property(e => e.KoordinatiRemonta)
                    .HasColumnName("Koordinati_Remonta")
                    .HasMaxLength(500);

                entity.Property(e => e.Korobka).HasMaxLength(255);

                entity.Property(e => e.Line).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(50);

                entity.Property(e => e.NomerKontrUch)
                    .HasColumnName("Nomer_kontr_uch")
                    .HasMaxLength(50);

                entity.Property(e => e.Operator).HasMaxLength(100);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(255);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(150);

                entity.Property(e => e.RadiogramNo)
                    .HasColumnName("Radiogram_No")
                    .HasMaxLength(50);

                entity.Property(e => e.Razbrakovka).HasMaxLength(500);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(100);

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasMaxLength(255);

                entity.Property(e => e.Tolsh).HasColumnType("sql_variant");

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(50);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(255);

                entity.Property(e => e.Xray).HasMaxLength(150);

                entity.Property(e => e.Zona).HasMaxLength(50);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле33).HasMaxLength(50);

                entity.Property(e => e.Поле34).HasMaxLength(255);

                entity.Property(e => e.Поле36).HasMaxLength(255);
            });

            modelBuilder.Entity<RtRsp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RT_RSP", "dbo");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.Chuvstvitelnost).HasMaxLength(200);

                entity.Property(e => e.DataAct).HasColumnType("date");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefId)
                    .HasColumnName("def_id")
                    .HasMaxLength(200);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FilmSize).HasMaxLength(200);

                entity.Property(e => e.FilmType).HasMaxLength(200);

                entity.Property(e => e.KolSnimkov).HasColumnName("Kol_snimkov");

                entity.Property(e => e.KoordinatiRemonta)
                    .HasColumnName("Koordinati_Remonta")
                    .HasMaxLength(1000);

                entity.Property(e => e.Korobka).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.NomerKontrUch)
                    .HasColumnName("Nomer_kontr_uch")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.RadiogramNo)
                    .HasColumnName("Radiogram_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Xray).HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле33).HasMaxLength(200);

                entity.Property(e => e.Поле34).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(1000);
            });

            modelBuilder.Entity<RtSmm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RT_SMM", "dbo");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.Chuvstvitelnost).HasMaxLength(200);

                entity.Property(e => e.DataAct).HasColumnType("date");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefId)
                    .HasColumnName("def_id")
                    .HasMaxLength(200);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FilmSize).HasMaxLength(200);

                entity.Property(e => e.FilmType).HasMaxLength(200);

                entity.Property(e => e.KolSnimkov).HasColumnName("Kol_snimkov");

                entity.Property(e => e.KoordinatiRemonta)
                    .HasColumnName("Koordinati_Remonta")
                    .HasMaxLength(1000);

                entity.Property(e => e.Korobka).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.NomerKontrUch)
                    .HasColumnName("Nomer_kontr_uch")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.RadiogramNo)
                    .HasColumnName("Radiogram_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Xray).HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле33).HasMaxLength(200);

                entity.Property(e => e.Поле34).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(1000);
            });

            modelBuilder.Entity<RtSmu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RT_SMU", "dbo");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.Chuvstvitelnost).HasMaxLength(255);

                entity.Property(e => e.DataAct).HasColumnType("date");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasMaxLength(50);

                entity.Property(e => e.DefId)
                    .HasColumnName("def_id")
                    .HasMaxLength(255);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Diam).HasMaxLength(255);

                entity.Property(e => e.Drawing).HasMaxLength(255);

                entity.Property(e => e.Element1).HasMaxLength(255);

                entity.Property(e => e.Element2).HasMaxLength(255);

                entity.Property(e => e.FilmSize).HasMaxLength(255);

                entity.Property(e => e.FilmType).HasMaxLength(255);

                entity.Property(e => e.KolSnimkov).HasColumnName("Kol_snimkov");

                entity.Property(e => e.KoordinatiRemonta)
                    .HasColumnName("Koordinati_Remonta")
                    .HasMaxLength(255);

                entity.Property(e => e.Korobka).HasMaxLength(255);

                entity.Property(e => e.Line).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.NomerKontrUch)
                    .HasColumnName("Nomer_kontr_uch")
                    .HasMaxLength(255);

                entity.Property(e => e.Operator).HasMaxLength(255);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(255);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(255);

                entity.Property(e => e.RadiogramNo)
                    .HasColumnName("Radiogram_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Razbrakovka).HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Result).HasMaxLength(255);

                entity.Property(e => e.Sheet).HasMaxLength(150);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(255);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(255);

                entity.Property(e => e.Xray).HasMaxLength(255);

                entity.Property(e => e.Zona).HasMaxLength(255);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле33).HasMaxLength(255);

                entity.Property(e => e.Поле34).HasMaxLength(255);

                entity.Property(e => e.Поле36).HasMaxLength(255);
            });

            modelBuilder.Entity<RtSsr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RT_SSR", "dbo");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.Chuvstvitelnost).HasMaxLength(200);

                entity.Property(e => e.DataAct).HasColumnType("date");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefId)
                    .HasColumnName("def_id")
                    .HasMaxLength(200);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FilmSize).HasMaxLength(200);

                entity.Property(e => e.FilmType).HasMaxLength(200);

                entity.Property(e => e.KolSnimkov).HasColumnName("Kol_snimkov");

                entity.Property(e => e.KoordinatiRemonta)
                    .HasColumnName("Koordinati_Remonta")
                    .HasMaxLength(1000);

                entity.Property(e => e.Korobka).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.NomerKontrUch)
                    .HasColumnName("Nomer_kontr_uch")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.RadiogramNo)
                    .HasColumnName("Radiogram_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Xray).HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле33).HasMaxLength(200);

                entity.Property(e => e.Поле34).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(1000);
            });

            modelBuilder.Entity<RtTestRomi99>(entity =>
            {
                entity.HasKey(e => e.Код)
                    .HasName("PK__RT_TEST___AE76132E73E52AFC");

                entity.ToTable("RT_TEST_ROMI99", "u0554110_romi99");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.AllSumm).HasMaxLength(50);

                entity.Property(e => e.Chuvstvitelnost).HasMaxLength(200);

                entity.Property(e => e.DataAct).HasColumnType("date");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefId)
                    .HasColumnName("def_id")
                    .HasMaxLength(200);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FilmSize).HasMaxLength(200);

                entity.Property(e => e.FilmType).HasMaxLength(200);

                entity.Property(e => e.KolSnimkov).HasColumnName("Kol_snimkov");

                entity.Property(e => e.KoordinatiRemonta)
                    .HasColumnName("Koordinati_Remonta")
                    .HasMaxLength(1000);

                entity.Property(e => e.Korobka).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.NomerKontrUch)
                    .HasColumnName("Nomer_kontr_uch")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.RadiogramNo)
                    .HasColumnName("Radiogram_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(300);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Xray).HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Поле33).HasMaxLength(200);

                entity.Property(e => e.Поле34).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(1000);
            });

            modelBuilder.Entity<RtUwtUg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RT_UWT_UG", "dbo");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.Chuvstvitelnost).HasMaxLength(255);

                entity.Property(e => e.DataAct).HasColumnType("date");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefId)
                    .HasColumnName("def_id")
                    .HasMaxLength(255);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Diam).HasMaxLength(255);

                entity.Property(e => e.Drawing).HasMaxLength(255);

                entity.Property(e => e.Element1).HasMaxLength(255);

                entity.Property(e => e.Element2).HasMaxLength(255);

                entity.Property(e => e.FilmSize).HasMaxLength(300);

                entity.Property(e => e.FilmType).HasMaxLength(300);

                entity.Property(e => e.KolSnimkov).HasColumnName("Kol_snimkov");

                entity.Property(e => e.KoordinatiRemonta)
                    .HasColumnName("Koordinati_Remonta")
                    .HasMaxLength(255);

                entity.Property(e => e.Korobka).HasMaxLength(255);

                entity.Property(e => e.Line).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.NomerKontrUch)
                    .HasColumnName("Nomer_kontr_uch")
                    .HasMaxLength(255);

                entity.Property(e => e.Operator).HasMaxLength(255);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(255);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(255);

                entity.Property(e => e.RadiogramNo)
                    .HasColumnName("Radiogram_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Razbrakovka).HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Result).HasMaxLength(255);

                entity.Property(e => e.Rev).HasMaxLength(50);

                entity.Property(e => e.Sheet).HasMaxLength(50);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasMaxLength(255);

                entity.Property(e => e.Tolsh).HasMaxLength(255);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(255);

                entity.Property(e => e.Zona).HasMaxLength(255);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле33).HasMaxLength(255);

                entity.Property(e => e.Поле34).HasMaxLength(255);

                entity.Property(e => e.Поле36).HasMaxLength(255);
            });

            modelBuilder.Entity<RtYAg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RT_Y_AG", "dbo");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.Chuvstvitelnost).HasMaxLength(255);

                entity.Property(e => e.DataAct).HasMaxLength(255);

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasMaxLength(300);

                entity.Property(e => e.DefId)
                    .HasColumnName("def_id")
                    .HasMaxLength(255);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Diam).HasColumnType("sql_variant");

                entity.Property(e => e.Drawing).HasMaxLength(255);

                entity.Property(e => e.Element1).HasMaxLength(255);

                entity.Property(e => e.Element2).HasMaxLength(255);

                entity.Property(e => e.FilmSize).HasMaxLength(255);

                entity.Property(e => e.FilmType).HasMaxLength(255);

                entity.Property(e => e.KolSnimkov).HasColumnName("Kol_snimkov");

                entity.Property(e => e.KoordinatiRemonta).HasColumnName("Koordinati_Remonta");

                entity.Property(e => e.Korobka).HasMaxLength(255);

                entity.Property(e => e.Line).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.NomerKontrUch)
                    .HasColumnName("Nomer_kontr_uch")
                    .HasMaxLength(255);

                entity.Property(e => e.Operator).HasMaxLength(255);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(255);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(50);

                entity.Property(e => e.RadiogramNo)
                    .HasColumnName("Radiogram_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Result).HasMaxLength(255);

                entity.Property(e => e.Rev).HasMaxLength(50);

                entity.Property(e => e.Sheet).HasMaxLength(50);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasColumnType("sql_variant");

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(255);

                entity.Property(e => e.Zona).HasMaxLength(255);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле33).HasMaxLength(255);

                entity.Property(e => e.Поле34).HasMaxLength(255);

                entity.Property(e => e.Поле36).HasMaxLength(255);
            });

            modelBuilder.Entity<RtYLp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RT_Y_LP", "dbo");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.Chuvstvitelnost).HasMaxLength(200);

                entity.Property(e => e.DataAct).HasColumnType("date");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefId)
                    .HasColumnName("def_id")
                    .HasMaxLength(200);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FilmSize).HasMaxLength(200);

                entity.Property(e => e.FilmType).HasMaxLength(200);

                entity.Property(e => e.KolSnimkov).HasColumnName("Kol_snimkov");

                entity.Property(e => e.KoordinatiRemonta)
                    .HasColumnName("Koordinati_Remonta")
                    .HasMaxLength(1000);

                entity.Property(e => e.Korobka).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.NomerKontrUch)
                    .HasColumnName("Nomer_kontr_uch")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.RadiogramNo)
                    .HasColumnName("Radiogram_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Xray).HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле33).HasMaxLength(200);

                entity.Property(e => e.Поле34).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(1000);
            });

            modelBuilder.Entity<RtYTank>(entity =>
            {
                entity.HasKey(e => e.Код)
                    .HasName("PK__RT_Y_TAN__AE76132ED1ED97A7");

                entity.ToTable("RT_Y_TANK", "u0554110_romi99");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.Chuvstvitelnost).HasMaxLength(200);

                entity.Property(e => e.DataAct).HasColumnType("date");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefId)
                    .HasColumnName("def_id")
                    .HasMaxLength(200);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.FilmSize).HasMaxLength(200);

                entity.Property(e => e.FilmType).HasMaxLength(200);

                entity.Property(e => e.KolSnimkov).HasColumnName("Kol_snimkov");

                entity.Property(e => e.KoordinatiRemonta)
                    .HasColumnName("Koordinati_Remonta")
                    .HasMaxLength(100);

                entity.Property(e => e.Korobka).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.NomerKontrUch)
                    .HasColumnName("Nomer_kontr_uch")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.RadiogramNo)
                    .HasColumnName("Radiogram_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(300);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Xray).HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Поле33).HasMaxLength(200);

                entity.Property(e => e.Поле34).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(1000);
            });

            modelBuilder.Entity<RtYUg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RT_Y_UG", "dbo");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.Chuvstvitelnost).HasMaxLength(255);

                entity.Property(e => e.DataAct).HasColumnType("date");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasMaxLength(300);

                entity.Property(e => e.DefId)
                    .HasColumnName("def_id")
                    .HasMaxLength(255);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Diam).HasColumnType("sql_variant");

                entity.Property(e => e.Drawing).HasMaxLength(255);

                entity.Property(e => e.Element1).HasMaxLength(255);

                entity.Property(e => e.Element2).HasMaxLength(255);

                entity.Property(e => e.FilmSize).HasMaxLength(255);

                entity.Property(e => e.FilmType).HasMaxLength(255);

                entity.Property(e => e.KolSnimkov).HasColumnName("Kol_snimkov");

                entity.Property(e => e.KoordinatiRemonta).HasColumnName("Koordinati_Remonta");

                entity.Property(e => e.Korobka).HasMaxLength(255);

                entity.Property(e => e.Line).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.NomerKontrUch)
                    .HasColumnName("Nomer_kontr_uch")
                    .HasMaxLength(255);

                entity.Property(e => e.Operator).HasMaxLength(255);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(255);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(250);

                entity.Property(e => e.RadiogramNo)
                    .HasColumnName("Radiogram_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Result).HasMaxLength(255);

                entity.Property(e => e.Rev).HasMaxLength(50);

                entity.Property(e => e.Sheet).HasMaxLength(50);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasColumnType("sql_variant");

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(255);

                entity.Property(e => e.Zona).HasMaxLength(255);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле33).HasMaxLength(255);

                entity.Property(e => e.Поле34).HasMaxLength(255);

                entity.Property(e => e.Поле36).HasMaxLength(255);
            });

            modelBuilder.Entity<Texk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEXK", "dbo");

                entity.Property(e => e.DiamDo).HasColumnName("Diam_Do");

                entity.Property(e => e.DiamOt).HasColumnName("Diam_Ot");

                entity.Property(e => e.PeВик)
                    .HasColumnName("PE_ВИК")
                    .HasMaxLength(250);

                entity.Property(e => e.ГостP52630Вик)
                    .HasColumnName("ГОСТ_P52630_ВИК")
                    .HasMaxLength(255);

                entity.Property(e => e.ГостP52630Рк)
                    .HasColumnName("ГОСТ_P52630_РК")
                    .HasMaxLength(255);

                entity.Property(e => e.ГостВик)
                    .HasColumnName("ГОСТ_ВИК")
                    .HasMaxLength(255);

                entity.Property(e => e.ГостРк)
                    .HasColumnName("ГОСТ_РК")
                    .HasMaxLength(255);

                entity.Property(e => e.ГостУзк)
                    .HasColumnName("ГОСТ_УЗК")
                    .HasMaxLength(300);

                entity.Property(e => e.ПэВик)
                    .HasColumnName("ПЭ_ВИК")
                    .HasMaxLength(300);

                entity.Property(e => e.РдВик)
                    .HasColumnName("РД_ВИК")
                    .HasMaxLength(255);

                entity.Property(e => e.РдРк)
                    .HasColumnName("РД_РК")
                    .HasMaxLength(255);

                entity.Property(e => e.РдУзк)
                    .HasColumnName("РД_УЗК")
                    .HasMaxLength(300);

                entity.Property(e => e.СниП30301Вик)
                    .HasColumnName("СНиП_30301_ВИК")
                    .HasMaxLength(250);

                entity.Property(e => e.СнипВик)
                    .HasColumnName("СНИП_ВИК")
                    .HasMaxLength(255);

                entity.Property(e => e.СнипРк)
                    .HasColumnName("СНИП_РК")
                    .HasMaxLength(255);

                entity.Property(e => e.СнипУзк)
                    .HasColumnName("СНИП_УЗК")
                    .HasMaxLength(300);

                entity.Property(e => e.Сп70Вик)
                    .HasColumnName("СП70_ВИК")
                    .HasMaxLength(255);

                entity.Property(e => e.Сп70Рк)
                    .HasColumnName("СП70_РК")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<UtParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UtParam", "dbo");

                entity.Property(e => e.Chast).HasMaxLength(600);

                entity.Property(e => e.Pep)
                    .HasColumnName("pep")
                    .HasMaxLength(600);

                entity.Property(e => e.Ploshad).HasMaxLength(600);

                entity.Property(e => e.Sop)
                    .HasColumnName("sop")
                    .HasMaxLength(600);

                entity.Property(e => e.ThinDo).HasColumnName("Thin_do");

                entity.Property(e => e.ThinOt).HasColumnName("Thin_ot");

                entity.Property(e => e.Ugol).HasMaxLength(600);
            });

            modelBuilder.Entity<UtParam1>(entity =>
            {
                entity.HasKey(e => e.Код)
                    .HasName("PK__UtParam__AE76132EC61858D8");

                entity.ToTable("UtParam", "u0554110_romi99");

                entity.Property(e => e.Chast).HasMaxLength(600);

                entity.Property(e => e.Pep)
                    .HasColumnName("pep")
                    .HasMaxLength(600);

                entity.Property(e => e.Ploshad).HasMaxLength(600);

                entity.Property(e => e.Sop)
                    .HasColumnName("sop")
                    .HasMaxLength(600);

                entity.Property(e => e.ThinDo).HasColumnName("Thin_do");

                entity.Property(e => e.ThinOt).HasColumnName("Thin_ot");

                entity.Property(e => e.Ugol).HasMaxLength(600);
            });

            modelBuilder.Entity<UtPs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UT_PS", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<UtRhiAg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UT_RHI_AG", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<UtRhiOzx>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UT_RHI_OZX", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<UtSsr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UT_SSR", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<UtYAg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UT_Y_AG", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<UtYTank>(entity =>
            {
                entity.HasKey(e => e.Код)
                    .HasName("PK__UT_Y_TAN__AE76132EFF5E1714");

                entity.ToTable("UT_Y_TANK", "u0554110_romi99");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(300);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<VtAl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_AL", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Diam).HasColumnType("sql_variant");

                entity.Property(e => e.Drawing).HasMaxLength(255);

                entity.Property(e => e.Element1).HasMaxLength(255);

                entity.Property(e => e.Element2).HasMaxLength(255);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.Line).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.Operator).HasMaxLength(255);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(255);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(255);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(255);

                entity.Property(e => e.Razbrakovka).HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Result).HasMaxLength(255);

                entity.Property(e => e.Rev).HasMaxLength(50);

                entity.Property(e => e.Sheet).HasMaxLength(50);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasColumnType("sql_variant");

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(255);

                entity.Property(e => e.Zona).HasMaxLength(255);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(255);

                entity.Property(e => e.Поле37).HasMaxLength(255);

                entity.Property(e => e.Поле38).HasMaxLength(255);

                entity.Property(e => e.Поле41).HasMaxLength(255);
            });

            modelBuilder.Entity<VtAp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_AP", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<VtEmm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_EMM", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<VtEnr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_ENR", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<VtEraK>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_ERA_K", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<VtIns>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_INS", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<VtKmmAg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_KMM_AG", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Diam).HasColumnType("sql_variant");

                entity.Property(e => e.Drawing).HasMaxLength(255);

                entity.Property(e => e.Element1).HasMaxLength(255);

                entity.Property(e => e.Element2).HasMaxLength(255);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.Line).HasMaxLength(255);

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.Operator).HasMaxLength(55);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(55);

                entity.Property(e => e.PrintSumma).HasColumnName("Print_Summa");

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(255);

                entity.Property(e => e.Razbrakovka).HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Result).HasMaxLength(55);

                entity.Property(e => e.Rev).HasMaxLength(255);

                entity.Property(e => e.Sheet).HasMaxLength(30);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasColumnType("sql_variant");

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(55);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(55);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(55);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(55);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(55);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(255);

                entity.Property(e => e.Zona).HasMaxLength(50);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(55);

                entity.Property(e => e.Поле36).HasMaxLength(55);

                entity.Property(e => e.Поле37).HasMaxLength(55);

                entity.Property(e => e.Поле38).HasMaxLength(255);

                entity.Property(e => e.Поле39).HasMaxLength(255);

                entity.Property(e => e.Поле41).HasMaxLength(255);
            });

            modelBuilder.Entity<VtKmmMkT>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_KMM_MK_T", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(600);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(600);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId).HasColumnName("WeldID");

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<VtMnt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_MNT", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<VtMzAg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_MZ_AG", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasMaxLength(255);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Diam).HasColumnType("sql_variant");

                entity.Property(e => e.Drawing).HasMaxLength(255);

                entity.Property(e => e.Element1).HasMaxLength(255);

                entity.Property(e => e.Element2).HasMaxLength(255);

                entity.Property(e => e.Line).HasMaxLength(255);

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.Operator).HasMaxLength(255);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(255);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(50);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(255);

                entity.Property(e => e.Razbrakovka).HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Result).HasMaxLength(255);

                entity.Property(e => e.Rev).HasMaxLength(255);

                entity.Property(e => e.Sheet).HasMaxLength(255);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasColumnType("sql_variant");

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(255);

                entity.Property(e => e.Zona).HasMaxLength(255);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(255);

                entity.Property(e => e.Поле36).HasMaxLength(255);

                entity.Property(e => e.Поле37).HasMaxLength(255);

                entity.Property(e => e.Поле38).HasMaxLength(255);

                entity.Property(e => e.Поле39).HasMaxLength(255);

                entity.Property(e => e.Поле41).HasMaxLength(255);
            });

            modelBuilder.Entity<VtPsAg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_PS_AG", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasMaxLength(255);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Diam).HasColumnType("sql_variant");

                entity.Property(e => e.Drawing).HasMaxLength(255);

                entity.Property(e => e.Element1).HasMaxLength(255);

                entity.Property(e => e.Element2).HasMaxLength(255);

                entity.Property(e => e.Line).HasMaxLength(255);

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.Operator).HasMaxLength(100);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(55);

                entity.Property(e => e.PrintSumma).HasColumnName("Print_Summa");

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(255);

                entity.Property(e => e.Razbrakovka).HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Result).HasMaxLength(55);

                entity.Property(e => e.Rev).HasMaxLength(55);

                entity.Property(e => e.Sheet).HasMaxLength(55);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasColumnType("sql_variant");

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(55);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(100);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(55);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(55);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(55);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(55);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(255);

                entity.Property(e => e.Zona).HasMaxLength(55);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(55);

                entity.Property(e => e.Поле36).HasMaxLength(55);

                entity.Property(e => e.Поле37).HasMaxLength(55);

                entity.Property(e => e.Поле38).HasMaxLength(55);

                entity.Property(e => e.Поле39).HasMaxLength(55);

                entity.Property(e => e.Поле41).HasMaxLength(55);
            });

            modelBuilder.Entity<VtPsMk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_PS_MK", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(800);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.Line).HasMaxLength(800);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId).HasColumnName("WeldID");

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<VtRhiAg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_RHI_AG", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Diam).HasColumnType("sql_variant");

                entity.Property(e => e.Drawing).HasMaxLength(255);

                entity.Property(e => e.Element1).HasMaxLength(255);

                entity.Property(e => e.Element2).HasMaxLength(255);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.Line).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.Operator).HasMaxLength(255);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(50);

                entity.Property(e => e.PrintSumma).HasColumnName("Print_Summa");

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(255);

                entity.Property(e => e.Razbrakovka).HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Result).HasMaxLength(255);

                entity.Property(e => e.Sheet).HasMaxLength(50);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasColumnType("sql_variant");

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(50);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(50);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(255);

                entity.Property(e => e.Zona).HasMaxLength(255);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(255);

                entity.Property(e => e.Поле36).HasMaxLength(255);

                entity.Property(e => e.Поле37).HasMaxLength(255);

                entity.Property(e => e.Поле38).HasMaxLength(255);

                entity.Property(e => e.Поле41).HasMaxLength(255);
            });

            modelBuilder.Entity<VtRhiMk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_RHI_MK", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<VtRhiMkL>(entity =>
            {
                entity.HasKey(e => e.Код)
                    .HasName("PK__VT_RHI_M__AE76132E67B38F4C");

                entity.ToTable("VT_RHI_MK_L", "u0554110_romi99");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(300);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<VtRhiOzx>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_RHI_OZX", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<VtRhiPe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_RHI_PE", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<VtRhiPs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_RHI_PS", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Diam).HasMaxLength(255);

                entity.Property(e => e.Drawing).HasMaxLength(255);

                entity.Property(e => e.Element1).HasMaxLength(255);

                entity.Property(e => e.Element2).HasMaxLength(255);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.Line).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(55);

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.Operator).HasMaxLength(55);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(255);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(255);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(255);

                entity.Property(e => e.Razbrakovka).HasMaxLength(55);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Result).HasMaxLength(55);

                entity.Property(e => e.Sheet).HasMaxLength(50);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(50);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(50);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(255);

                entity.Property(e => e.Zona).HasMaxLength(255);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(55);

                entity.Property(e => e.Поле36).HasMaxLength(55);

                entity.Property(e => e.Поле37).HasMaxLength(55);

                entity.Property(e => e.Поле38).HasMaxLength(55);

                entity.Property(e => e.Поле41).HasMaxLength(255);
            });

            modelBuilder.Entity<VtRhiUg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_RHI_UG", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Diam).HasColumnType("sql_variant");

                entity.Property(e => e.Drawing).HasMaxLength(255);

                entity.Property(e => e.Element1).HasMaxLength(255);

                entity.Property(e => e.Element2).HasMaxLength(255);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.Line).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.Operator).HasMaxLength(255);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(255);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(255);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(255);

                entity.Property(e => e.Razbrakovka).HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasColumnType("sql_variant");

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(255);

                entity.Property(e => e.Zona).HasMaxLength(255);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(255);

                entity.Property(e => e.Поле36).HasMaxLength(255);

                entity.Property(e => e.Поле37).HasMaxLength(255);

                entity.Property(e => e.Поле38).HasMaxLength(255);

                entity.Property(e => e.Поле41).HasMaxLength(255);
            });

            modelBuilder.Entity<VtRsp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_RSP", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<VtSmm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_SMM", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<VtSmu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_SMU", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasMaxLength(50);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Diam).HasMaxLength(255);

                entity.Property(e => e.Drawing).HasMaxLength(255);

                entity.Property(e => e.Element1).HasMaxLength(255);

                entity.Property(e => e.Element2).HasMaxLength(255);

                entity.Property(e => e.Line).HasMaxLength(255);

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.Operator).HasMaxLength(255);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(255);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(255);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(255);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Result).HasMaxLength(255);

                entity.Property(e => e.Rev).HasMaxLength(50);

                entity.Property(e => e.Sheet).HasMaxLength(150);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(255);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(255);

                entity.Property(e => e.Zona).HasMaxLength(255);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(255);

                entity.Property(e => e.Поле36).HasMaxLength(255);

                entity.Property(e => e.Поле37).HasMaxLength(255);

                entity.Property(e => e.Поле38).HasMaxLength(255);

                entity.Property(e => e.Поле39).HasMaxLength(255);

                entity.Property(e => e.Поле41).HasMaxLength(255);
            });

            modelBuilder.Entity<VtSmuMk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_SMU_MK", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<VtSsr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_SSR", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<VtUwtUg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_UWT_UG", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Diam).HasMaxLength(255);

                entity.Property(e => e.Drawing).HasMaxLength(255);

                entity.Property(e => e.Element1).HasMaxLength(255);

                entity.Property(e => e.Element2).HasMaxLength(255);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.Line).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(70);

                entity.Property(e => e.Operator).HasMaxLength(255);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(70);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(50);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(255);

                entity.Property(e => e.Razbrakovka).HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Result).HasMaxLength(255);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasMaxLength(255);

                entity.Property(e => e.Tolsh).HasMaxLength(255);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(70);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(70);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(255);

                entity.Property(e => e.Zona).HasMaxLength(255);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(255);

                entity.Property(e => e.Поле36).HasMaxLength(255);

                entity.Property(e => e.Поле37).HasMaxLength(255);

                entity.Property(e => e.Поле38).HasMaxLength(255);

                entity.Property(e => e.Поле41).HasMaxLength(255);
            });

            modelBuilder.Entity<VtYAg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_Y_AG", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasMaxLength(150);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Diam).HasColumnType("sql_variant");

                entity.Property(e => e.Drawing).HasMaxLength(255);

                entity.Property(e => e.Element1).HasMaxLength(255);

                entity.Property(e => e.Element2).HasMaxLength(255);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.Line).HasMaxLength(255);

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.Operator).HasMaxLength(255);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(255);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(255);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(255);

                entity.Property(e => e.Razbrakovka).HasMaxLength(500);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Result).HasMaxLength(500);

                entity.Property(e => e.Rev).HasMaxLength(50);

                entity.Property(e => e.Sheet).HasMaxLength(50);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh)
                    .IsRequired()
                    .HasColumnType("sql_variant");

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(255);

                entity.Property(e => e.Zona).HasMaxLength(255);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(255);

                entity.Property(e => e.Поле36).HasMaxLength(255);

                entity.Property(e => e.Поле37).HasMaxLength(255);

                entity.Property(e => e.Поле38).HasMaxLength(255);

                entity.Property(e => e.Поле39).HasMaxLength(255);

                entity.Property(e => e.Поле41).HasMaxLength(255);
            });

            modelBuilder.Entity<VtYLp>(entity =>
            {
                entity.HasKey(e => e.Код)
                    .HasName("PK__VT_Y_LP__AE76132E74B7652B");

                entity.ToTable("VT_Y_LP", "u0554110_romi99");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<VtYPe>(entity =>
            {
                entity.HasKey(e => e.Код)
                    .HasName("PK__VT_Y_PE__AE76132E6268B164");

                entity.ToTable("VT_Y_PE", "u0554110_romi99");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasColumnType("date");

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Diam).HasMaxLength(200);

                entity.Property(e => e.Drawing).HasMaxLength(200);

                entity.Property(e => e.Element1).HasMaxLength(200);

                entity.Property(e => e.Element2).HasMaxLength(200);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.Line).HasMaxLength(200);

                entity.Property(e => e.Logger).HasColumnName("logger");

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.Operator).HasMaxLength(200);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(200);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(200);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(200);

                entity.Property(e => e.Razbrakovka).HasMaxLength(1000);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(200);

                entity.Property(e => e.Result).HasMaxLength(200);

                entity.Property(e => e.Rev).HasMaxLength(200);

                entity.Property(e => e.Sheet).HasMaxLength(200);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasMaxLength(200);

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(200);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(200);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(200);

                entity.Property(e => e.Zona).HasMaxLength(200);

                entity.Property(e => e.Поле35).HasMaxLength(200);

                entity.Property(e => e.Поле36).HasMaxLength(200);

                entity.Property(e => e.Поле37).HasMaxLength(200);

                entity.Property(e => e.Поле38).HasMaxLength(200);

                entity.Property(e => e.Поле39).HasMaxLength(200);

                entity.Property(e => e.Поле41).HasMaxLength(200);
            });

            modelBuilder.Entity<VtYUg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VT_Y_UG", "dbo");

                entity.Property(e => e.ActDate)
                    .HasColumnName("Act_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ActNo).HasColumnName("Act_No");

                entity.Property(e => e.DataAddInBd)
                    .HasColumnName("Data_AddInBd")
                    .HasColumnType("date");

                entity.Property(e => e.DataWeld)
                    .HasColumnName("Data_Weld")
                    .HasMaxLength(50);

                entity.Property(e => e.DefectoskopistId)
                    .HasColumnName("Defectoskopist_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Diam).HasColumnType("sql_variant");

                entity.Property(e => e.Drawing).HasMaxLength(255);

                entity.Property(e => e.Element1).HasMaxLength(255);

                entity.Property(e => e.Element2).HasMaxLength(255);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.Line).HasMaxLength(255);

                entity.Property(e => e.NdtDate)
                    .HasColumnName("NDT_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NoNdt)
                    .HasColumnName("No_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.Operator).HasMaxLength(255);

                entity.Property(e => e.PipelineCategory)
                    .HasColumnName("Pipeline_Category")
                    .HasMaxLength(255);

                entity.Property(e => e.PrintSumma)
                    .HasColumnName("Print_Summa")
                    .HasMaxLength(255);

                entity.Property(e => e.PwhtBeforeOrAfter)
                    .HasColumnName("PWHT_before_or_after")
                    .HasMaxLength(255);

                entity.Property(e => e.Razbrakovka).HasMaxLength(500);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.ReqestDate)
                    .HasColumnName("Reqest_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReqestNo)
                    .HasColumnName("Reqest_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Result).HasMaxLength(255);

                entity.Property(e => e.Rev).HasMaxLength(50);

                entity.Property(e => e.Sheet).HasMaxLength(50);

                entity.Property(e => e.TimePrint)
                    .HasColumnName("Time_Print")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tolsh).HasColumnType("sql_variant");

                entity.Property(e => e.TypeOfControlNdt)
                    .HasColumnName("Type_of_control_NDT")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeOfWelds)
                    .HasColumnName("Type_of_welds")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldId)
                    .HasColumnName("WeldID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldSumm).HasMaxLength(100);

                entity.Property(e => e.Welder1Id)
                    .HasColumnName("Welder1_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder2Id)
                    .HasColumnName("Welder2_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder3Id)
                    .HasColumnName("Welder3_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Welder4Id)
                    .HasColumnName("Welder4_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.WeldingProcess)
                    .HasColumnName("Welding_Process")
                    .HasMaxLength(255);

                entity.Property(e => e.Zona).HasMaxLength(255);

                entity.Property(e => e.Код).ValueGeneratedOnAdd();

                entity.Property(e => e.Поле35).HasMaxLength(255);

                entity.Property(e => e.Поле36).HasMaxLength(255);

                entity.Property(e => e.Поле37).HasMaxLength(255);

                entity.Property(e => e.Поле38).HasMaxLength(255);

                entity.Property(e => e.Поле39).HasMaxLength(255);

                entity.Property(e => e.Поле41).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
