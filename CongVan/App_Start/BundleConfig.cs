﻿using System.Web;
using System.Web.Optimization;

namespace CongVan
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/header/js").Include(
                      "~/assets/js/ace-extra.min.js"
                      ));

            bundles.Add(new ScriptBundle("~/footer/js").Include(
                      "~/assets/js/bootstrap.min.js",
                      "~/assets/js/jquery-2.1.4.min.js",
                      "~/assets/js/ace-elements.min.js",
                      "~/assets/js/ace.min.js"
                      ));

            bundles.Add(new ScriptBundle("~/datetime/js").Include(
                "~/assets/js/bootstrap-datepicker.min.js",
                "~/assets/js/moment.min.js",
                "~/assets/js/daterangepicker.min.js",
                "~/assets/js/bootstrap-datetimepicker.min.js"
                ));

            bundles.Add(new StyleBundle("~/main/css").Include(
                 "~/assets/css/bootstrap.min.css",
                 "~/assets/font-awesome/4.5.0/css/font-awesome.min.css",
                 "~/assets/css/fonts.googleapis.com.css",
                 "~/assets/css/ace.min.css",
                 "~/assets/css/ace-part2.min.css",
                 "~/assets/css/ace-skins.min.css",
                 "~/assets/css/ace-rtl.min.css"
                 ));

            bundles.Add(new ScriptBundle("~/departments/js").Include(
                      "~/Scripts/ViewModels/Departments.js"
                      ));

            bundles.Add(new ScriptBundle("~/members/js").Include(
                      "~/Scripts/ViewModels/Members.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/require").Include(
                        "~/Scripts/require.js"));
        }
    }
}