using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MyFirstEpiserverSite.Business
{
  [InitializableModule]
  public class BundleConfig : IInitializableModule
  {
    public void Initialize(InitializationEngine context)
    {
      if (context.HostType == HostType.WebApplication)
      {
        RegisterBundles(BundleTable.Bundles);
      }
    
    }

    private static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new ScriptBundle("~/bundles/jquery.js").Include(
        "~/Scripts/jquery-{version}.js"));

      bundles.Add(new ScriptBundle("~/bundles/bootstrap.js").Include(
        "~/Scripts/bootsrap.js"
       ,"~/Scripts/respond.js"));

      bundles.Add(new StyleBundle("~/Content/style.css").Include(
        "~/Content/bootstrap.css"));

      BundleTable.EnableOptimizations = false;
    }

    public void Uninitialize(InitializationEngine context)
    {
      throw new NotImplementedException();
    }
  }
}