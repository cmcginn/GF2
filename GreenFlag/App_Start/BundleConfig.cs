using System.Web;
using System.Web.Optimization;

namespace GreenFlag
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
          
           bundles.Add(new ScriptBundle("~/bundles/plugin").Include(
            "~/Theme/OnePage/js-plugin/respond/respond.min.js"
           ,"~/Theme/OnePage/js-plugin/jquery/1.8.3/jquery.js"
           ,"~/Theme/OnePage/js-plugin/jquery-ui/jquery-ui-1.8.23.custom.min.js"       
           ,"~/Scripts/Vendor/bootstrap.js"
           ,"~/Theme/OnePage/js-plugin/easing/jquery.easing.1.3.js"
           ,"~/Theme/OnePage/js-plugin/flexslider/jquery.flexslider-min.js"
           ,"~/Theme/OnePage/js-plugin/isotope/jquery.isotope.min.js"
           ,"~/Theme/OnePage/js-plugin/neko-contact-ajax-plugin/js/jquery.form.js"
           ,"~/Theme/OnePage/js-plugin/neko-contact-ajax-plugin/js/jquery.validate.min.js"
           ,"~/Theme/OnePage/js-plugin/magnific-popup/jquery.magnific-popup.min.js"
           ,"~/Theme/OnePage/js-plugin/parallax/js/jquery.scrollTo-1.4.3.1-min.js"
           ,"~/Theme/OnePage/js-plugin/parallax/js/jquery.localscroll-1.2.7-min.js"
           ,"~/Theme/OnePage/js-plugin/parallax/js/jquery.stellar.min.js"         
           ,"~/Theme/OnePage/js-plugin/appear/jquery.appear.js"
           ,"~/Theme/OnePage/js-plugin/pageSlide/jquery.pageslide-custom.js"
           ,"~/Theme/OnePage/js-plugin/jquery.sharrre-1.3.4/jquery.sharrre-1.3.4.min.js"
           ,"~/Theme/OnePage/js-plugin/owl.carousel/owl-carousel/owl.carousel.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/app").Include("~/Scripts/app/custom.js", "~/Scripts/app/site.js"));
            bundles.Add(new StyleBundle("~/styles/bootstrap").Include(
                      "~/Content/bootstrap/css/bootstrap.css",
                      "~/Content/bootstrap/css/bootstrap-theme.css"
                      ));
            bundles.Add(new StyleBundle("~/styles/Theme").Include(
                "~/Theme/OnePage/js-plugin/animation-framework/animate.css"
                , "~/Theme/OnePage/js-plugin/magnific-popup/magnific-popup.css"
                , "~/Theme/OnePage/js-plugin/isotope/css/style.css"
                , "~/Theme/OnePage/js-plugin/flexslider/flexslider.css"
                , "~/Theme/OnePage/js-plugin/pageSlide/jquery.pageslide.css"
                , "~/Theme/OnePage/js-plugin/owl.carousel/owl-carousel/owl.carousel.css"
                , "~/Theme/OnePage/js-plugin/owl.carousel/owl-carousel/owl.theme.css"
                , "~/Theme/OnePage/js-plugin/appear/nekoAnim.css"
                , "~/Theme/OnePage/css/layout.css"
        ));
           
        }
    }
}