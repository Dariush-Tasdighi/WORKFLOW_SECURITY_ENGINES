namespace Models
{
	[System.ComponentModel.DataAnnotations.Schema.Table
		(name: Infrastructure.Constants.TABLE_NAME_OF_APPLICATION_SETTINGS,
		Schema = Infrastructure.Constants.SCHEMA_NAME)]
	public class ApplicationSettings : Infrastructure.BaseLocalizedEntity
	{
		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ApplicationSettings>
		{
			public Configuration()
			{
				//HasOptional(current => current.MailSettings)
				//	.WithMany(mailSettings => mailSettings.AllOfApplicationSettings)
				//	.HasForeignKey(current => current.MailSettingsId)
				//	.WillCascadeOnDelete(false)
				//	;

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
						Property(current => current.ApplicationName)
							.HasColumnType("ntext")
							.IsMaxLength()
							;

						Property(current => current.HomePageKeywords)
							.HasColumnType("ntext")
							.IsMaxLength()
							;

						Property(current => current.HomePageCopyright)
							.HasColumnType("ntext")
							.IsMaxLength()
							;

						Property(current => current.ApplicationVersion)
							.HasColumnType("ntext")
							.IsMaxLength()
							;

						Property(current => current.HomePageClassification)
							.HasColumnType("ntext")
							.IsMaxLength()
							;

						Property(current => current.ApplicationCopyrightUrl)
							.HasColumnType("ntext")
							.IsMaxLength()
							;

						Property(current => current.ApplicationCopyrightText)
							.HasColumnType("ntext")
							.IsMaxLength()
							;

						break;
					}
				}
			}
		}
		#endregion /Configuration

		public ApplicationSettings()
		{
			IsUserEmailVerificationRequiredForLogin = true;

			CultureLcid =
				System.Threading.Thread.CurrentThread.CurrentCulture.LCID;
		}

		// TODO
		// **********
		// **********
		// **********
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.MailSettings),
		//	Name = Resources.Models.Strings.MailSettingsKeys.EntityName)]
		//public virtual MailSettings MailSettings { get; set; }
		// **********

		// **********
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.MailSettings),
		//	Name = Resources.Models.Strings.MailSettingsKeys.EntityName)]
		//public System.Guid? MailSettingsId { get; set; }
		// **********
		// **********
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.ApplicationName)]
		public string ApplicationName { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.ApplicationVersion)]
		public string ApplicationVersion { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.ApplicationCopyrightText)]
		public string ApplicationCopyrightText { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.ApplicationCopyrightUrl)]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(Dtx.Text.RegularExpressions.Patterns.Url,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName =
			Resources.Strings.MessagesKeys.RegularExpressionForUrl)]
		public string ApplicationCopyrightUrl { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.CheckNationalCode)]
		public bool CheckNationalCode { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.ServerTimeZoneDifference)]

		[System.ComponentModel.DataAnnotations.Required
			(ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(Dtx.Text.RegularExpressions.Patterns.Integer,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName =
			Resources.Strings.MessagesKeys.RegularExpressionForInteger)]
		public int ServerTimeZoneDifference { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.ForceUserToUpdateProfileAfterLogin)]
		public bool ForceUserToUpdateProfileAfterLogin { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.IsCaptchaImageEnabled)]
		public bool IsCaptchaImageEnabled { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.IsSmsServiceEnabled)]
		public bool IsSmsServiceEnabled { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.IsCmsEnabled)]
		public bool IsCmsEnabled { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.ShouldUserBeActivatedAfterRegistration)]
		public bool ShouldUserBeActivatedAfterRegistration { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.CanUserAttachFileInContactUsPage)]
		public bool CanUserAttachFileInContactUsPage { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.ApplicationSettings),
		//	Name = Resources.Models.Strings.ApplicationSettingsKeys.IsUserEmailVerificationRequiredForLogin)]
		public bool IsUserEmailVerificationRequiredForLogin { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.Title)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 65,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]
		public string HomePageTitle { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.Common.BaseSeo),
		//	Name = Resources.Models.Common.Strings.BaseSeoKeys.Keywords)]
		public string HomePageKeywords { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.Common.BaseSeo),
		//	Name = Resources.Models.Common.Strings.BaseSeoKeys.Classification)]
		public string HomePageClassification { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.Description)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 65,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]
		public string HomePageDescription { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.Common.BaseSeo),
		//	Name = Resources.Models.Common.Strings.BaseSeoKeys.Copyright)]
		public string HomePageCopyright { get; set; }
		// **********
	}
}
