using System.Linq;

namespace MainApplication.Controllers
{
	public partial class HomeController : Infrastructure.BaseController
	{
		public HomeController() : base()
		{
			var Users =
				UnitOfWork.UserRepository
				.Get()
				.ToList()
				;
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ActionResult Index()
		{
			return (View());
		}
	}
}
