using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entity.Entities
{
    public partial class DBETICARETContext : DbContext
    {
        public DBETICARETContext()
        {
        }

        public DBETICARETContext(DbContextOptions<DBETICARETContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbleniyilerHomedesign> TbleniyilerHomedesign { get; set; }
        public virtual DbSet<TblgaleriHomedesign> TblgaleriHomedesign { get; set; }
        public virtual DbSet<TblhtmltasarimHomedesign> TblhtmltasarimHomedesign { get; set; }
        public virtual DbSet<TbliletisimHomedesign> TbliletisimHomedesign { get; set; }
        public virtual DbSet<Tblkargo> Tblkargo { get; set; }
        public virtual DbSet<Tblkategori> Tblkategori { get; set; }
        public virtual DbSet<TblkategoriUrun> TblkategoriUrun { get; set; }
        public virtual DbSet<TblkategorialaniHomedesign> TblkategorialaniHomedesign { get; set; }
        public virtual DbSet<Tblkullanici> Tblkullanici { get; set; }
        public virtual DbSet<Tblmarka> Tblmarka { get; set; }
        public virtual DbSet<Tblmodel> Tblmodel { get; set; }
        public virtual DbSet<TblmodelUrun> TblmodelUrun { get; set; }
        public virtual DbSet<Tblozellik> Tblozellik { get; set; }
        public virtual DbSet<TblozellikUrun> TblozellikUrun { get; set; }
        public virtual DbSet<Tblprofil> Tblprofil { get; set; }
        public virtual DbSet<Tblsepet> Tblsepet { get; set; }
        public virtual DbSet<Tblsiparis> Tblsiparis { get; set; }
        public virtual DbSet<Tblsiparisdetay> Tblsiparisdetay { get; set; }
        public virtual DbSet<TblsiteHomedesign> TblsiteHomedesign { get; set; }
        public virtual DbSet<TblsiteSlider> TblsiteSlider { get; set; }
        public virtual DbSet<TblsoneklenenlerHomedesign> TblsoneklenenlerHomedesign { get; set; }
        public virtual DbSet<Tblurun> Tblurun { get; set; }
        public virtual DbSet<Tblurunresim> Tblurunresim { get; set; }
        public virtual DbSet<Tblurunyildiz> Tblurunyildiz { get; set; }
        public virtual DbSet<TblyetkiKullanici> TblyetkiKullanici { get; set; }
        public virtual DbSet<Tblyetkiler> Tblyetkiler { get; set; }
        public virtual DbSet<Tblyorum> Tblyorum { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=eticaretcore.database.windows.net;Initial Catalog=eticaretdb;User ID=muhammedali55;Password=Ankara06*;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbleniyilerHomedesign>(entity =>
            {
                entity.ToTable("tbleniyiler_homedesign");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ortaresimurl)
                    .HasColumnName("ortaresimurl")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sagaltbaslik)
                    .HasColumnName("sagaltbaslik")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sagaltresimurl)
                    .HasColumnName("sagaltresimurl")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sagortabaslik)
                    .HasColumnName("sagortabaslik")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sagortaresimurl)
                    .HasColumnName("sagortaresimurl")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Sagustbaslik)
                    .HasColumnName("sagustbaslik")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sagustresimurl)
                    .HasColumnName("sagustresimurl")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Silid)
                    .HasColumnName("silid")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Solbaslik)
                    .HasColumnName("solbaslik")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Solbutton)
                    .HasColumnName("solbutton")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Solicerik)
                    .HasColumnName("solicerik")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Solresimurl)
                    .HasColumnName("solresimurl")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblgaleriHomedesign>(entity =>
            {
                entity.ToTable("tblgaleri_homedesign");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Resimurl)
                    .HasColumnName("resimurl")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Silid)
                    .HasColumnName("silid")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TblhtmltasarimHomedesign>(entity =>
            {
                entity.ToTable("tblhtmltasarim_homedesign");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Icerik)
                    .HasColumnName("icerik")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbliletisimHomedesign>(entity =>
            {
                entity.ToTable("tbliletisim_homedesign");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Baslik)
                    .HasColumnName("baslik")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Button)
                    .HasColumnName("button")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Icerik)
                    .HasColumnName("icerik")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Silid)
                    .HasColumnName("silid")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Tblkargo>(entity =>
            {
                entity.ToTable("tblkargo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aciklama)
                    .HasColumnName("aciklama")
                    .IsUnicode(false);

                entity.Property(e => e.Firmaadi)
                    .HasColumnName("firmaadi")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Iletisim)
                    .HasColumnName("iletisim")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SilId).HasColumnName("sil_id");

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Tblkategori>(entity =>
            {
                entity.ToTable("tblkategori");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasColumnName("ad")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.SilId).HasColumnName("sil_id");

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblkategoriUrun>(entity =>
            {
                entity.ToTable("tblkategori_urun");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.KategoriId).HasColumnName("kategori_id");

                entity.Property(e => e.SilId).HasColumnName("sil_id");

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");
            });

            modelBuilder.Entity<TblkategorialaniHomedesign>(entity =>
            {
                entity.ToTable("tblkategorialani_homedesign");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AltBaslik)
                    .HasColumnName("alt_baslik")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Baslik)
                    .HasColumnName("baslik")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ButtonText)
                    .HasColumnName("button_text")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KategoriId).HasColumnName("kategori_id");

                entity.Property(e => e.ResimUrl)
                    .HasColumnName("resim_url")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SilId)
                    .HasColumnName("sil_id")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Tblkullanici>(entity =>
            {
                entity.ToTable("tblkullanici");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Eposta)
                    .HasColumnName("eposta")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Kullaniciadi)
                    .HasColumnName("kullaniciadi")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Sifre)
                    .HasColumnName("sifre")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.SilId).HasColumnName("sil_id");

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Tblmarka>(entity =>
            {
                entity.ToTable("tblmarka");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aciklama)
                    .HasColumnName("aciklama")
                    .IsUnicode(false);

                entity.Property(e => e.Ad)
                    .HasColumnName("ad")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SilId).HasColumnName("sil_id");

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Tblmodel>(entity =>
            {
                entity.ToTable("tblmodel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasColumnName("ad")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MarkaId).HasColumnName("marka_id");

                entity.Property(e => e.SilId).HasColumnName("sil_id");

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblmodelUrun>(entity =>
            {
                entity.ToTable("tblmodel_urun");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModelId).HasColumnName("model_id");

                entity.Property(e => e.SilId).HasColumnName("sil_id");

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");
            });

            modelBuilder.Entity<Tblozellik>(entity =>
            {
                entity.ToTable("tblozellik");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasColumnName("ad")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.SilId).HasColumnName("sil_id");

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblozellikUrun>(entity =>
            {
                entity.ToTable("tblozellik_urun");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OzellikId).HasColumnName("ozellik_id");

                entity.Property(e => e.SilId).HasColumnName("sil_id");

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");
            });

            modelBuilder.Entity<Tblprofil>(entity =>
            {
                entity.ToTable("tblprofil");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasColumnName("ad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Adres)
                    .HasColumnName("adres")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ceptel)
                    .HasColumnName("ceptel")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dogumtarihi)
                    .HasColumnName("dogumtarihi")
                    .HasColumnType("date");

                entity.Property(e => e.Evtel)
                    .HasColumnName("evtel")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Istel)
                    .HasColumnName("istel")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KullaniciId).HasColumnName("kullanici_id");

                entity.Property(e => e.Profilresim)
                    .HasColumnName("profilresim")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SilId).HasColumnName("sil_id");

                entity.Property(e => e.Soyad)
                    .HasColumnName("soyad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tckimlik)
                    .HasColumnName("tckimlik")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Tblsepet>(entity =>
            {
                entity.ToTable("tblsepet");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adet).HasColumnName("adet");

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.KullaniciId).HasColumnName("kullanici_id");

                entity.Property(e => e.SilId).HasColumnName("sil_id");

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");
            });

            modelBuilder.Entity<Tblsiparis>(entity =>
            {
                entity.ToTable("tblsiparis");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Durumu).HasColumnName("durumu");

                entity.Property(e => e.FaturaAdres)
                    .HasColumnName("fatura_adres")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.KargoId).HasColumnName("kargo_id");

                entity.Property(e => e.KargoTakipNo)
                    .HasColumnName("kargo_takip_no")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KullaniciId).HasColumnName("kullanici_id");

                entity.Property(e => e.OdemeTuru)
                    .HasColumnName("odeme_turu")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SilId).HasColumnName("sil_id");

                entity.Property(e => e.TeslimatAdres)
                    .HasColumnName("teslimat_adres")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Tblsiparisdetay>(entity =>
            {
                entity.ToTable("tblsiparisdetay");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adet).HasColumnName("adet");

                entity.Property(e => e.Birimfiyat).HasColumnName("birimfiyat");

                entity.Property(e => e.Indirimlifiyat).HasColumnName("indirimlifiyat");

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Kdvtutari).HasColumnName("kdvtutari");

                entity.Property(e => e.SilId).HasColumnName("sil_id");

                entity.Property(e => e.SiparisId).HasColumnName("siparis_id");

                entity.Property(e => e.Toplamfiyat).HasColumnName("toplamfiyat");

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");
            });

            modelBuilder.Entity<TblsiteHomedesign>(entity =>
            {
                entity.ToTable("tblsite_homedesign");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aciklama)
                    .HasColumnName("aciklama")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Ad)
                    .HasColumnName("ad")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Durum).HasColumnName("durum");

                entity.Property(e => e.Silid).HasColumnName("silid");
            });

            modelBuilder.Entity<TblsiteSlider>(entity =>
            {
                entity.ToTable("tblsite_slider");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasColumnName("ad")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Altbaslik)
                    .HasColumnName("altbaslik")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Backimgurl)
                    .HasColumnName("backimgurl")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Baslik)
                    .HasColumnName("baslik")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Butonlinkurl)
                    .HasColumnName("butonlinkurl")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Butontext)
                    .HasColumnName("butontext")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Frontimgurl)
                    .HasColumnName("frontimgurl")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Silid).HasColumnName("silid");
            });

            modelBuilder.Entity<TblsoneklenenlerHomedesign>(entity =>
            {
                entity.ToTable("tblsoneklenenler_homedesign");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Baslik)
                    .HasColumnName("baslik")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kategori1).HasColumnName("kategori1");

                entity.Property(e => e.Kategori2).HasColumnName("kategori2");

                entity.Property(e => e.Kategori3).HasColumnName("kategori3");

                entity.Property(e => e.Kategori4).HasColumnName("kategori4");

                entity.Property(e => e.Silid)
                    .HasColumnName("silid")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tab1)
                    .HasColumnName("tab1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tab2)
                    .HasColumnName("tab2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tab3)
                    .HasColumnName("tab3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tab4)
                    .HasColumnName("tab4")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblurun>(entity =>
            {
                entity.ToTable("tblurun");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aciklama)
                    .HasColumnName("aciklama")
                    .IsUnicode(false);

                entity.Property(e => e.Ad)
                    .HasColumnName("ad")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Fiyat).HasColumnName("fiyat");

                entity.Property(e => e.IndirimliFiyat).HasColumnName("indirimli_fiyat");

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Kdv).HasColumnName("kdv");

                entity.Property(e => e.SilId).HasColumnName("sil_id");

                entity.Property(e => e.StokMiktari).HasColumnName("stok_miktari");

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Tblurunresim>(entity =>
            {
                entity.ToTable("tblurunresim");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Anaresim).HasColumnName("anaresim");

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SilId).HasColumnName("sil_id");

                entity.Property(e => e.UrunId).HasColumnName("urunid");

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UrunUrl)
                    .HasColumnName("urun_url")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblurunyildiz>(entity =>
            {
                entity.ToTable("tblurunyildiz");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Puanadedi).HasColumnName("puanadedi");

                entity.Property(e => e.SilId).HasColumnName("sil_id");

                entity.Property(e => e.Toplampuan).HasColumnName("toplampuan");

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");
            });

            modelBuilder.Entity<TblyetkiKullanici>(entity =>
            {
                entity.ToTable("tblyetki_kullanici");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.KullaniciId).HasColumnName("kullanici_id");

                entity.Property(e => e.SilId).HasColumnName("sil_id");

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.YetkiId).HasColumnName("yetki_id");
            });

            modelBuilder.Entity<Tblyetkiler>(entity =>
            {
                entity.ToTable("tblyetkiler");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SilId).HasColumnName("sil_id");

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Yetki)
                    .HasColumnName("yetki")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblyorum>(entity =>
            {
                entity.ToTable("tblyorum");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Insertdate)
                    .HasColumnName("insertdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.KullaniciId).HasColumnName("kullanici_id");

                entity.Property(e => e.Puan).HasColumnName("puan");

                entity.Property(e => e.SilId).HasColumnName("sil_id");

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UrunId).HasColumnName("urun_id");

                entity.Property(e => e.Yorum)
                    .HasColumnName("yorum")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
