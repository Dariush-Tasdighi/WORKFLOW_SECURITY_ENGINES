namespace Models.Security.Infrastructure
{
	public static class Constants
	{
		public const string SECURITY_SCHEMA_NAME = "security";

		public const string SECURITY_TABLE_NAME_PREFIX = "Security";

		public const string SECURITY_TABLE_NAME_OF_ROLE = SECURITY_TABLE_NAME_PREFIX + "Roles";
		public const string SECURITY_TABLE_NAME_OF_GROUP = SECURITY_TABLE_NAME_PREFIX + "Groups";
		public const string SECURITY_TABLE_NAME_OF_ACCESSTYPE = SECURITY_TABLE_NAME_PREFIX + "AccessTypes";

		public const string SECURITY_TABLE_NAME_OF_SYSTEM_AREA = SECURITY_TABLE_NAME_PREFIX + "SystemAreas";
		public const string SECURITY_TABLE_NAME_OF_SYSTEM_ACTION = SECURITY_TABLE_NAME_PREFIX + "SystemActions";
		public const string SECURITY_TABLE_NAME_OF_SYSTEM_CONTROLLERS = SECURITY_TABLE_NAME_PREFIX + "SystemControllers";
	}
}
