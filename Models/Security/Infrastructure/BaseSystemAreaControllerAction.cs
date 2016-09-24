namespace Models.Security.Infrastructure
{
	public abstract class BaseSystemAreaControllerAction :
		Models.Infrastructure.BaseExtendedEntity
	{
		public BaseSystemAreaControllerAction()
			: base()
		{
		}

		// **********
		public bool IsAvailableInSourceCode { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.BaseAreaControllerAction),
		//	Name = Resources.Models.Strings.BaseAreaControllerActionKeys.IsVisibleJustForProgrammer)]
		public bool IsVisibleJustForProgrammer { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.BaseAreaControllerAction),
		//	Name = Resources.Models.Strings.BaseAreaControllerActionKeys.DisplayName)]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 250,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]
		public string DisplayName { get; set; }
		// **********

		// **********
		[System.Web.Mvc.AllowHtml]

		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.Description)]

		[System.ComponentModel.DataAnnotations.DataType
			(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
		public string Description { get; set; }
		// **********
	}
}
