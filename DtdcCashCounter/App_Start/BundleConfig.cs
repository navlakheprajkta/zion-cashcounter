﻿using System.Web;
using System.Web.Optimization;

namespace DtdcCashCounter
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                  
                  "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                           "~/Content/site.css",
                           "~/admin-lte/css/AdminLTE.css",
                           "~/admin-lte/css/skins/_all-skins.min.css",
                           "~/Content/bower_components/font-awesome/css/font-awesome.min.css"
                           ));


            bundles.Add(new ScriptBundle("~/admin-lte/js").Include(
           "~/admin-lte/js/app.js",
           "~/admin-lte/plugins/fastclick/fastclick.js"

           ));
        }
    }
}
