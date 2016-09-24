namespace Dtx.Web.Mvc.Security
{
	public class ControllerPermissionAttribute : System.Attribute
	{
		public ControllerPermissionAttribute
			(System.Type resourceType,
			string resourceName,
			bool isJustForProgrammer = true,
			bool forceToChangeNameAfterSyncing = false)
		{
			ResourceName = resourceName;
			ResourceType = resourceType;

			IsJustForProgrammer = isJustForProgrammer;
			ForceToChangeNameAfterSyncing = forceToChangeNameAfterSyncing;
		}

		public string ResourceName { get; set; }

		public System.Type ResourceType { get; set; }

		public bool IsJustForProgrammer { get; set; }

		public bool ForceToChangeNameAfterSyncing { get; set; }
	}
}
