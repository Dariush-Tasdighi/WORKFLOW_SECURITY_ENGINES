namespace MY_WEB_APPLICATION.Controllers
{
	[Dtx.Web.Mvc.Security.ControllerPermission
		(isJustForProgrammer: false,
		resourceType: typeof(Resources.Areas.ErrorController),
		resourceName: Resources.Areas.Strings.ErrorControllerKeys.ControllerName)]
	public partial class ErrorController : Infrastructure.BaseController
	{
		public ErrorController()
			: base()
		{
		}

		//[System.Web.Mvc.HttpGet]
		//[Infrastructure.Attributes.ProjectActionPermission
		//	(isVisibleJustForProgrammer: false,
		//	accessType: Models.Enums.AccessTypes.Public,
		//	resourceType: typeof(Resources.Errors),
		//	resourceName: Resources.Strings.ErrorsKeys.BadRequest)]
		//public virtual System.Web.Mvc.ActionResult BadRequest()
		//{
		//	return (RedirectToAction
		//		(MVC.Error.Display(System.Net.HttpStatusCode.BadRequest)));
		//}

		//[System.Web.Mvc.HttpGet]
		//[Infrastructure.Attributes.ProjectActionPermission
		//	(isVisibleJustForProgrammer: false,
		//	accessType: Models.Enums.AccessTypes.Public,
		//	resourceType: typeof(Resources.Errors),
		//	resourceName: Resources.Strings.ErrorsKeys.Forbidden)]
		//public virtual System.Web.Mvc.ActionResult Forbidden()
		//{
		//	return (RedirectToAction
		//		(MVC.Error.Display(System.Net.HttpStatusCode.BadRequest)));
		//}

		[System.Web.Mvc.HttpGet]
		[Dtx.Web.Mvc.Security.ActionPermission
			(isJustForProgrammer: false,
			defaultAccessType: Models.Security.Enums.AccessTypes.Public,
			resourceType: typeof(Resources.Areas.General),
			resourceName: Resources.Areas.Strings.GeneralKeys.Display)]
		public virtual System.Web.Mvc.ViewResult Display(System.Net.HttpStatusCode? code)
		{
			if (code == null)
			{
				code = System.Net.HttpStatusCode.BadRequest;
			}

			// TODO
			//switch (code.Value)
			//{
			//	case System.Net.HttpStatusCode.BadRequest:
			//	{
			//		ViewBag.Message = Resources.Errors.BadRequest;
			//		break;
			//	}

			//	case System.Net.HttpStatusCode.Forbidden:
			//	{
			//		ViewBag.Message = Resources.Errors.Forbidden;
			//		break;
			//	}

			//	case System.Net.HttpStatusCode.NotFound:
			//	{
			//		ViewBag.Message = Resources.Errors.NotFound;
			//		break;
			//	}

			//	case System.Net.HttpStatusCode.TemporaryRedirect:
			//	{
			//		ViewBag.Message = Resources.Errors.TemporaryRedirect;
			//		break;
			//	}

			//	case System.Net.HttpStatusCode.Unauthorized:
			//	{
			//		ViewBag.Message = Resources.Errors.Unauthorized;
			//		break;
			//	}

			//	default:
			//	{
			//		ViewBag.Message = code.ToString();

			//		break;
			//	}
			//}

			return (View());
		}
	}
}
