using System.Linq;
using System.Data.Entity;

namespace MainApplication.Areas.Workflow.Controllers
{
	[Dtx.Web.Mvc.Security.ControllerPermission
		(isJustForProgrammer: false,
		resourceType: typeof(Resources.Areas.Workflow.ProcessController),
		resourceName: Resources.Areas.Workflow.Strings.ProcessControllerKeys.ControllerName)]
	public partial class ProcessController : Infrastructure.BaseController
	{
		public ProcessController()
			: base()
		{
		}

		[System.Web.Mvc.HttpGet]
		[Dtx.Web.Mvc.Security.ActionPermission
			(isJustForProgrammer: false,
			defaultAccessType: Models.Security.Enums.AccessTypes.Special,
			resourceType: typeof(Resources.Areas.General),
			resourceName: Resources.Areas.Strings.GeneralKeys.Index)]
		public virtual System.Web.Mvc.ActionResult Index()
		{
			var varWorkflowProcesses =
				UnitOfWork.WorkflowUnitOfWork.ProcessRepository
				.Get()
				.OrderBy(current => current.Ordering)
				.ThenBy(current => current.Code)
				.ToList()
				;

			return (View(model: varWorkflowProcesses));
		}

		[System.Web.Mvc.HttpGet]
		[Dtx.Web.Mvc.Security.ActionPermission
			(isJustForProgrammer: false,
			defaultAccessType: Models.Security.Enums.AccessTypes.Special,
			resourceType: typeof(Resources.Areas.General),
			resourceName: Resources.Areas.Strings.GeneralKeys.Details)]
		public virtual System.Web.Mvc.ActionResult Details(System.Guid? id)
		{
			if (id.HasValue == false)
			{
				return (RedirectToAction
					(MVC.Error.Display(System.Net.HttpStatusCode.BadRequest)));
			}

			Models.Workflow.Process oWorkflowProcess =
				UnitOfWork.WorkflowUnitOfWork.ProcessRepository
				.Get()
				.Where(current => current.Id == id.Value)
				.FirstOrDefault();

			if (oWorkflowProcess == null)
			{
				return (RedirectToAction
					(MVC.Error.Display(System.Net.HttpStatusCode.NotFound)));
			}

			return (View(model: oWorkflowProcess));
		}

		[System.Web.Mvc.HttpGet]
		[Dtx.Web.Mvc.Security.ActionPermission
			(isJustForProgrammer: false,
			defaultAccessType: Models.Security.Enums.AccessTypes.Special,
			resourceType: typeof(Resources.Areas.General),
			resourceName: Resources.Areas.Strings.GeneralKeys.Edit)]
		public virtual System.Web.Mvc.ActionResult Edit(System.Guid? id)
		{
			if (id.HasValue == false)
			{
				return (RedirectToAction
					(MVC.Error.Display(System.Net.HttpStatusCode.BadRequest)));
			}

			Models.Workflow.Process oWorkflowProcess =
				UnitOfWork.WorkflowUnitOfWork.ProcessRepository
				.Get()
				.Where(current => current.Id == id.Value)
				.FirstOrDefault();

			if (oWorkflowProcess == null)
			{
				return (RedirectToAction
					(MVC.Error.Display(System.Net.HttpStatusCode.NotFound)));
			}

			return (View(model: oWorkflowProcess));
		}

		[System.Web.Mvc.HttpPost]
		[System.Web.Mvc.ValidateAntiForgeryToken]
		[Dtx.Web.Mvc.Security.ActionPermission
			(isJustForProgrammer: false,
			defaultAccessType: Models.Security.Enums.AccessTypes.Special,
			resourceType: typeof(Resources.Areas.General),
			resourceName: Resources.Areas.Strings.GeneralKeys.Edit)]
		public virtual System.Web.Mvc.ActionResult Edit(Models.Workflow.Process workflowProcess)
		{
			// **************************************************
			Models.Workflow.Process oOriginalWorkflowProcess =
				UnitOfWork.WorkflowUnitOfWork.ProcessRepository
				.GetById(workflowProcess.Id);

			if (oOriginalWorkflowProcess == null)
			{
				return (RedirectToAction
					(MVC.Error.Display(System.Net.HttpStatusCode.NotFound)));
			}
			// **************************************************

			if (ModelState.IsValid)
			{
				// **************************************************
				// **************************************************
				// **************************************************
				oOriginalWorkflowProcess.Name = workflowProcess.Name;
				oOriginalWorkflowProcess.Ordering = workflowProcess.Ordering;
				// **************************************************

				// **************************************************
				//oOriginalWorkflowProcess.SetUpdateDateTime
				//	(Infrastructure.Sessions.AuthenticatedUser.Id);

				//oOriginalWorkflowProcess.SetIsActive
				//	(workflowProcess.IsActive, Infrastructure.Sessions.AuthenticatedUser.Id);
				// **************************************************
				// **************************************************
				// **************************************************

				UnitOfWork.WorkflowUnitOfWork.ProcessRepository.Update(oOriginalWorkflowProcess);

				UnitOfWork.Save();

				return (RedirectToAction(MVC.Workflow.Process.Index()));
			}

			return (View(model: workflowProcess));
		}
	}
}
