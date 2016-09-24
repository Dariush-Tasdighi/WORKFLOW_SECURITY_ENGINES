namespace Models.Workflow.Infrastructure
{
	public static class Constants
	{
		public const string WORKFLOW_SCHEMA_NAME = "workflow";

		public const string WORKFLOW_TABLE_NAME_PREFIX = "Workflow";

		public const string WORKFLOW_TABLE_NAME_OF_STATE = WORKFLOW_TABLE_NAME_PREFIX + "States";
		public const string WORKFLOW_TABLE_NAME_OF_ACTION = WORKFLOW_TABLE_NAME_PREFIX + "Actions";
		public const string WORKFLOW_TABLE_NAME_OF_PROCESS = WORKFLOW_TABLE_NAME_PREFIX + "Processes";
		public const string WORKFLOW_TABLE_NAME_OF_STATE_TYPE = WORKFLOW_TABLE_NAME_PREFIX + "StateTypes";
		public const string WORKFLOW_TABLE_NAME_OF_ACTION_TYPE = WORKFLOW_TABLE_NAME_PREFIX + "ActionTypes";
		public const string WORKFLOW_TABLE_NAME_OF_ACTIVITY_TYPE = WORKFLOW_TABLE_NAME_PREFIX + "ActivityTypes";
	}
}
