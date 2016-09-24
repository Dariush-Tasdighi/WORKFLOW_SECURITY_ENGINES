namespace Models.Workflow.Enums
{
	public enum ActionTypes : int
	{
		Deny = 0,

		Cancel = 1000,

		Approve = 2000,

		Resolve = 3000,

		Restart = 4000,
	}
}
