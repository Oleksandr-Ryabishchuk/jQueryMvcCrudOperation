using System.IO;
using System.Web.Mvc;

namespace JqueryCrudOperarion
{
    public static class GlobalClass
    {
        public static string RenderRazorViewToString(Controller controller, string viewName, object model = null)
        {
            controller.ViewData.Model = model;
            using(var sw = new StringWriter())
            {
                ViewEngineResult engineResult;
                engineResult = ViewEngines.Engines.FindPartialView(controller.ControllerContext, viewName);
                var viewContext = new ViewContext(controller.ControllerContext, engineResult.View, controller.ViewData, controller.TempData, sw);
                engineResult.View.Render(viewContext, sw);
                engineResult.ViewEngine.ReleaseView(controller.ControllerContext, engineResult.View);
                return sw.GetStringBuilder().ToString();
            }
        }
    }
}