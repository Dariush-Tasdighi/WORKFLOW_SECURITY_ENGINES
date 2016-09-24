namespace Models.Workflow.Enums
{
	public enum ActivityTypes : int
	{
		SendSms = 0,

		SendEmail = 1000,

		AddManualNote = 2000,

		AddAutomaticNote = 3000,

		AddStackholder = 4000,

		RemoveStackholder = 5000,
	}
}
