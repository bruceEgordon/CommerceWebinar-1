using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using CommerceTraining.Models.Pages;
using EPiServer.ServiceLocation;
using EPiServer.Commerce.Catalog.ContentTypes;
using EPiServer.Web.Routing;

namespace CommerceTraining.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
       
        public readonly IContentLoader _contentLoader;

        ContentReference topCategory { get; set; } // used for listing of nodes at the start-page

        public StartPageController(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }

        public ActionResult Index(StartPage currentPage)
        {
            var model = new CommerceTraining.Models.ViewModels.PageViewModel<StartPage>(currentPage)
            {
                myPageChildren = _contentLoader.GetChildren<IContent>(currentPage.ContentLink),
            };

            return View(model);
        }
    }
}