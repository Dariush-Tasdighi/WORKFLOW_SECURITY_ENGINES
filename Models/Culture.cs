namespace Models
{
	[System.ComponentModel.DataAnnotations.Schema.Table
		(name: Infrastructure.Constants.TABLE_NAME_OF_CULTURE, Schema = Infrastructure.Constants.SCHEMA_NAME)]
	public class Culture : Infrastructure.BaseExtendedEntity, Models.Infrastructure.IDropDownList
	{
		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Culture>
		{
			public Configuration()
			{
				// **************************************************
				// *** Define Index(es) *****************************
				// **************************************************
				Property(current => current.Lcid)
					.HasColumnAnnotation("Index",
					new System.Data.Entity.Infrastructure.Annotations.IndexAnnotation
						(new System.ComponentModel.DataAnnotations.Schema.IndexAttribute() { IsUnique = true }));
				// **************************************************

				// **************************************************
				Property(current => current.Name)
					.HasColumnAnnotation("Index",
					new System.Data.Entity.Infrastructure.Annotations.IndexAnnotation
						(new System.ComponentModel.DataAnnotations.Schema.IndexAttribute() { IsUnique = true }));

				// **************************************************
				Property(current => current.NativeName)
					.HasColumnAnnotation("Index",
					new System.Data.Entity.Infrastructure.Annotations.IndexAnnotation
						(new System.ComponentModel.DataAnnotations.Schema.IndexAttribute() { IsUnique = true }));
				// **************************************************

				// **************************************************
				Property(current => current.DisplayName)
					.HasColumnAnnotation("Index",
					new System.Data.Entity.Infrastructure.Annotations.IndexAnnotation
						(new System.ComponentModel.DataAnnotations.Schema.IndexAttribute() { IsUnique = true }));
				// **************************************************
				// **************************************************
				// *** /Define Index(es) ****************************
				// **************************************************

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
						Property(current => current.Description)
							.HasColumnType("ntext")
							.IsMaxLength()
							;

						break;
					}
				}
			}
		}
		#endregion /Configuration

		public Culture()
			: base()
		{
		}

		// TODO
		//public Culture(System.Globalization.CultureInfo cultureInfo)
		//{
		//	Lcid = cultureInfo.LCID;
		//	Name = cultureInfo.Name;
		//	NativeName = cultureInfo.NativeName;
		//	DisplayName = cultureInfo.DisplayName;
		//}

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.MyCulture),
		//	Name = Resources.Models.Strings.MyCultureKeys.Lcid)]
		public int Lcid { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.Name)]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]
		public string Name { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.MyCulture),
		//	Name = Resources.Models.Strings.MyCultureKeys.NativeName)]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]
		public string NativeName { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.MyCulture),
		//	Name = Resources.Models.Strings.MyCultureKeys.DisplayName)]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]
		public string DisplayName { get; set; }
		// **********

		// **********
		[System.Web.Mvc.AllowHtml]

		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.Description)]

		[System.ComponentModel.DataAnnotations.DataType
			(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
		public string Description { get; set; }
		// **********

		// **********
		public string ListItemText
		{
			get
			{
				string strResult = Name;

				if (IsDeleted)
				{
					strResult =
						string.Format("{0} [{1}]",
						strResult, Resources.Models.General.IsDeleted);
				}

				if (IsActive == false)
				{
					strResult =
						string.Format("{0} [{1}]",
						strResult, Resources.Models.General.IsInactive);
				}

				return (strResult);
			}
		}
		// **********
	}
}
