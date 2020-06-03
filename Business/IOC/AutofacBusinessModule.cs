using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.IOC
{
    public class AutofacBusinessModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EniyilerHomedesignManager>().As<IEniyilerHomedesignService>();
            builder.RegisterType<EfEniyilerHomedesignDal>().As<IEniyilerHomedesignDal>();

            builder.RegisterType<GaleriHomedesignManager>().As<IGaleriHomedesignService>();
            builder.RegisterType<EfGaleriHomedesignDal>().As<IGaleriHomedesignDal>();

            builder.RegisterType<HtmltasarimHomedesignManager>().As<IHtmltasarimHomedesignService>();
            builder.RegisterType<EfHtmltasarimHomedesignDal>().As<IHtmltasarimHomedesignDal>();

            builder.RegisterType<İletisimHomedesignManager>().As<IİletisimHomedesignService>();
            builder.RegisterType<EfİletisimHomedesignDal>().As<IİletisimHomedesignDal>();

            builder.RegisterType<KargoManager>().As<IKargoService>();
            builder.RegisterType<EfKargoDal>().As<IKargoDal>();

            builder.RegisterType<Kategorialani_homedesignManager>().As<IKategorialani_homedesignService>();
            builder.RegisterType<EfKategorialani_homedesignDal>().As<IKategorialani_homedesignDal>();

            builder.RegisterType<KategoriManager>().As<IKategoriService>();
            builder.RegisterType<EfKategoriDal>().As<IKategoriDal>();

            builder.RegisterType<KategoriUrunManager>().As<IKategoriUrunService>();
            builder.RegisterType<EfKategoriUrunDal>().As<IKategoriUrunDal>();

            builder.RegisterType<KullaniciManager>().As<IKullaniciService>();
            builder.RegisterType<EfKullaniciDal>().As<IKullaniciDal>();

            builder.RegisterType<MarkaManager>().As<IMarkaService>();
            builder.RegisterType<EfMarkaDal>().As<IMarkaDal>();

            builder.RegisterType<ModelManager>().As<IModelService>();
            builder.RegisterType<EfModelDal>().As<IModelDal>();

            builder.RegisterType<ModelUrunManager>().As<IModelUrunService>();
            builder.RegisterType<EfModelUrunDal>().As<IModelUrunDal>();

            builder.RegisterType<OzellikManager>().As<IOzellikService>();
            builder.RegisterType<EfOzellikDal>().As<IOzellikDal>();

            builder.RegisterType<OzellikUrunManager>().As<IOzellikUrunService>();
            builder.RegisterType<EfOzellikUrunDal>().As<IOzellikUrunDal>();

            builder.RegisterType<ProfilManager>().As<IProfilService>();
            builder.RegisterType<EfProfilDal>().As<IProfilDal>();

            builder.RegisterType<SepetManager>().As<ISepetService>();
            builder.RegisterType<EfSepetDal>().As<ISepetDal>();

            builder.RegisterType<SiparisdetayManager>().As<ISiparisdetayService>();
            builder.RegisterType<EfSiparisdetayDal>().As<ISiparisdetayDal>();

            builder.RegisterType<SiparisManager>().As<ISiparisService>();
            builder.RegisterType<EfSiparisDal>().As<ISiparisDal>();

            builder.RegisterType<SiteHomedesignManager>().As<ISiteHomedesignService>();
            builder.RegisterType<EfSiteHomedesignDal>().As<ISiteHomedesignDal>();

            builder.RegisterType<KategoriManager>().As<IKategoriService>();
            builder.RegisterType<EfKategoriDal>().As<IKategoriDal>();

            builder.RegisterType<SiteSliderManager>().As<ISiteSliderService>();
            builder.RegisterType<EfSiteSliderDal>().As<ISiteSliderDal>();

            builder.RegisterType<SoneklenenlerHomedesignManager>().As<ISoneklenenlerHomedesignService>();
            builder.RegisterType<EfSoneklenenlerHomedesignDal>().As<ISoneklenenlerHomedesignDal>();

            builder.RegisterType<UrunresimManager>().As<IUrunresimService>();
            builder.RegisterType<EfUrunresimDal>().As<IUrunresimDal>();

            builder.RegisterType<UrunManager>().As<IUrunService>();
            builder.RegisterType<EfUrunDal>().As<IUrunDal>();

            builder.RegisterType<UrunyildizManager>().As<IUrunyildizService>();
            builder.RegisterType<EfUrunyildizDal>().As<IUrunyildizDal>();

            builder.RegisterType<YetkiKullaniciManager>().As<IYetkiKullaniciService>();
            builder.RegisterType<EfYetkiKullaniciDal>().As<IYetkiKullaniciDal>();

            builder.RegisterType<YetkilerManager>().As<IYetkilerService>();
            builder.RegisterType<EfYetkilerDal>().As<IYetkilerDal>();

            builder.RegisterType<YorumManager>().As<IYorumService>();
            builder.RegisterType<EfYorumDal>().As<IYorumDal>();

        }
    }
}
