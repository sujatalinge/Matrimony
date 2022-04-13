using CRUDUsingEFDBFirstApproach.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace CRUDUsingEFDBFirstApproach.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/myjs").
                Include("~/Scripts/myjs/Javascript1.js", "~/Scripts/myjs/Javascript2.js",
                "~/Scripts/myjs/Javascript3.js"));

            bundles.Add(new ScriptBundle("~/bundles/mybootstrap").
                Include("~/Scripts/jquery-1.9.1.min.js", 
                "~/Scripts/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/bundles/mycss").
                Include("~/Content/MyCss/StyleSheet1.css",
                "~/Content/MyCss/StyleSheet2.css",
                "~/Content/MyCss/StyleSheet3.css"));

            //  BundleTable.EnableOptimizations = true;
            BundleTable.EnableOptimizations = AppKeys.EnableBundling;

        }

    }
}