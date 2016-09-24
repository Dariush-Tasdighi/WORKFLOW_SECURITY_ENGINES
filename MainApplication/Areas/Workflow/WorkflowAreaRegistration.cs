namespace MainApplication.Areas.Workflow
{
	public class WorkflowAreaRegistration : System.Web.Mvc.AreaRegistration
	{
		public WorkflowAreaRegistration() : base()
		{
		}

		public override string AreaName
		{
			get
			{
				return ("Workflow");
			}
		}

		public override void RegisterArea(System.Web.Mvc.AreaRegistrationContext context)
		{
			context.MapRoute
				(name: "Workflow_Default",
				url: "Workflow/{controller}/{action}/{id}",
				defaults:
				new
				{
					controller = "Home",
					action = "Index",
					id = System.Web.Mvc.UrlParameter.Optional
				},
				namespaces: new[] { "MainApplication.Areas.Workflow.Controllers" }
			);
		}
	}
}
