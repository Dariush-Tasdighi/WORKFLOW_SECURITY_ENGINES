namespace Models.Infrastructure
{
	[System.Serializable]
	public abstract class BaseEntity : object
	{
		public BaseEntity()
		{
			Id = System.Guid.NewGuid();
		}

		// **********
		[System.ComponentModel.DataAnnotations.Key]

		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.Id)]

		[System.ComponentModel.DataAnnotations.Schema.Column(Order = 0)]
		public System.Guid Id { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.MasterDataCode)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]

		[System.ComponentModel.DataAnnotations.Schema.Column(Order = 1)]
		[System.ComponentModel.DataAnnotations.Schema.Index(IsUnique = false)]
		public string MasterDataCode { get; set; }
		// **********
	}
}
