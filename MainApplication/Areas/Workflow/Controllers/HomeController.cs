using System.Linq;

namespace MainApplication.Areas.Workflow.Controllers
{
	public partial class HomeController : Infrastructure.BaseController
	{
		public HomeController() : base()
		{
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Index()
		{
			return (View());
		}
	}
}
