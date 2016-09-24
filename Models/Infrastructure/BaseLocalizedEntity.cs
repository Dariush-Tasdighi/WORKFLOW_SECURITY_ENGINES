namespace Models.Infrastructure
{
	[System.Serializable]
	public abstract class BaseLocalizedEntity : BaseEntity, ICulture
	{
		public BaseLocalizedEntity()
		{
			CultureLcid =
				System.Threading.Thread.CurrentThread.CurrentCulture.LCID;
		}

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.CultureLcid)]

		[System.ComponentModel.DataAnnotations.Schema.NotMapped]
		public System.Guid CultureId { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.CultureLcid)]

		[System.ComponentModel.DataAnnotations.ScaffoldColumn(false)]
		[System.ComponentModel.DataAnnotations.Schema.Column(Order = 2)]
		public int CultureLcid { get; set; }
		// **********
	}
}
