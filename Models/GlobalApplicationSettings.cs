namespace Models
{
	[System.ComponentModel.DataAnnotations.Schema.Table
		(name: Infrastructure.Constants.TABLE_NAME_OF_GLOBAL_APPLICATION_SETTINGS,
		Schema = Infrastructure.Constants.SCHEMA_NAME)]
	public class GlobalApplicationSettings : Infrastructure.BaseEntity
	{
		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<GlobalApplicationSettings>
		{
			public Configuration()
			{
				switch (Infrastructure.Utility.DatabaseProvider)
				{
					case Enums.DatabaseProviders.Oracle:
					{
						break;
					}

					case Enums.DatabaseProviders.SqlServer:
					{
						break;
					}

					case Enums.DatabaseProviders.SqlServerCompactEdition:
					{
						Property(current => current.SiteUrl)
							.HasColumnType("ntext")
							.IsMaxLength()
							;

						Property(current => current.AlexaCode)
							.HasColumnType("ntext")
							.IsMaxLength()
							;

						Property(current => current.GoogleCode)
							.HasColumnType("ntext")
							.IsMaxLength()
							;

						Property(current => current.RssImageUrl)
							.HasColumnType("ntext")
							.IsMaxLength()
							;

						break;
					}
				}
			}
		}
		#endregion /Configuration

		public GlobalApplicationSettings()
		{
			CurrentUserProfileLevel = 1;

			SleepTimeoutInDemoVersion = 2500;
			IsApplicationInDemoVersion = true;

			RssItemCount = 10;
			RssImageUrl = "http://www.IranianExperts.com/Content/Images/Rss.png";
		}

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.SiteUrl)]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(Dtx.Text.RegularExpressions.Patterns.Url,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName =
			Resources.Strings.MessagesKeys.RegularExpressionForUrl)]
		public string SiteUrl { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.MasterPassword)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 40,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(Dtx.Text.RegularExpressions.Patterns.Password,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName =
			Resources.Strings.MessagesKeys.RegularExpressionForPassword)]
		public string MasterPassword { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.CurrentUserProfileLevel)]

		[System.ComponentModel.DataAnnotations.Required
			(ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(Dtx.Text.RegularExpressions.Patterns.ZeroOrUnsignedInteger,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName =
			Resources.Strings.MessagesKeys.RegularExpressionForZeroOrUnsignedInteger)]
		public int CurrentUserProfileLevel { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.IsSslEnabled)]
		public bool IsSslEnabled { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.SmsCenterNumber)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 40,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]
		public string SmsCenterNumber { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.SmsCenterUsername)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 40,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]
		public string SmsCenterUsername { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.SmsCenterPassword)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 40,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]
		public string SmsCenterPassword { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display(Name = "Alexa Code")]
		public string AlexaCode { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display(Name = "Google Code")]
		public string GoogleCode { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.TotalUserCount)]

		[System.ComponentModel.DataAnnotations.Required
			(ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(Dtx.Text.RegularExpressions.Patterns.ZeroOrUnsignedInteger,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName =
			Resources.Strings.MessagesKeys.RegularExpressionForZeroOrUnsignedInteger)]
		public int TotalUserCount { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.IsApplicationInDemoVersion)]
		public bool IsApplicationInDemoVersion { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.SleepTimeoutInDemoVersion)]
		public int SleepTimeoutInDemoVersion { get; set; }
		// **********


		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.RssItemCount)]

		[System.ComponentModel.DataAnnotations.Required
			(ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(Dtx.Text.RegularExpressions.Patterns.ZeroOrUnsignedInteger,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName =
			Resources.Strings.MessagesKeys.RegularExpressionForZeroOrUnsignedInteger)]
		public int RssItemCount { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.RssImageUrl)]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(Dtx.Text.RegularExpressions.Patterns.Url,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName =
			Resources.Strings.MessagesKeys.RegularExpressionForUrl)]
		public string RssImageUrl { get; set; }
		// **********
	}
}
