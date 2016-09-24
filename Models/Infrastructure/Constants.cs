namespace Models.Infrastructure
{
	public static class Constants
	{
		public const int MAX_FILE_NAME_LENGTH = 200;
		public const int MAX_FILE_EXTENSION_LENGTH = 5;

		public const string SCHEMA_NAME = "dbo";

		public const string TABLE_NAME_PREFIX = "";

		public const string TABLE_NAME_OF_USER = TABLE_NAME_PREFIX + "Users";
		public const string TABLE_NAME_OF_CULTURE = TABLE_NAME_PREFIX + "Cultures";

		public const string TABLE_NAME_OF_APPLICATION_SETTINGS = TABLE_NAME_PREFIX + "ApplicationSettings";
		public const string TABLE_NAME_OF_GLOBAL_APPLICATION_SETTINGS = TABLE_NAME_PREFIX + "GlobalApplicationSettings";
	}
}
