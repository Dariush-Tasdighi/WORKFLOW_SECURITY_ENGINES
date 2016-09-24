namespace Dtx.Web.Mvc.Security
{
	public class ActionPermissionAttribute : ControllerPermissionAttribute
	{
		public ActionPermissionAttribute
			(System.Type resourceType,
			string resourceName,
			bool isJustForProgrammer = true,
			bool forceToChangeNameAfterSyncing = false,
			bool forceToChangeAccessTypeAfterSyncing = false,
			Models.Security.Enums.AccessTypes defaultAccessType = Models.Security.Enums.AccessTypes.Special)
			: base(resourceType: resourceType,
				resourceName: resourceName,
				isJustForProgrammer: isJustForProgrammer,
				forceToChangeNameAfterSyncing: forceToChangeNameAfterSyncing)
		{
			DefaultAccessType = defaultAccessType;
			ForceToChangeAccessTypeAfterSyncing = forceToChangeAccessTypeAfterSyncing;
		}

		public bool ForceToChangeAccessTypeAfterSyncing { get; set; }

		public Models.Security.Enums.AccessTypes DefaultAccessType { get; set; }
	}
}
