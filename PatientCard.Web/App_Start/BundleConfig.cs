using System.Web.Optimization;

namespace PatientCard.Web
{
	public class BundleConfig
	{
		public static void Register(BundleCollection bundles)
		{
			bundles.Add(new StyleBundle("~/bundles/styles/common")
				            .Include("~/Content/bootstrap/css/bootstrap.css")
							.IncludeDirectory("~/Content/patient-card/styles", "*.css"));

			bundles.Add(new ScriptBundle("~/bundles/js/common")
				            .Include("~/Content/jquery/jquery-2.1.1.js")
				            .Include("~/Content/bootstrap/js/bootstrap.js"));

			bundles.Add(new ScriptBundle("~/bundles/js/angular")
				            .Include("~/Content/angularjs/angular.js")
				            .Include("~/Content/angularjs/i18n/angular-locale_ru-ru.js")
				            .Include("~/Content/angularjs/angular-route.js")
				            .Include("~/Content/angularjs/angular-resource.js")
				            .Include("~/Content/d3/d3.js")
				            .Include("~/Content/angularjs-nvd3-directives/nv.d3.js")
				            .Include("~/Content/angularjs-nvd3-directives/angularjs-nvd3-directives.js")
				            .IncludeDirectory("~/Content/angularjs-ui-bootstrap", "*.js")
							.IncludeDirectory("~/Content/angularjs-ui-router", "*.js")
				            .IncludeDirectory("~/Content/patient-card/controllers", "*.js")
				            .IncludeDirectory("~/Content/patient-card/modules", "*.js")
				            .IncludeDirectory("~/Content/patient-card/directives", "*.js")
				            .IncludeDirectory("~/Content/patient-card/services", "*.js")
				            .IncludeDirectory("~/Content/patient-card/app", "*.js"));
		}
	}
}