namespace Models.Security
{
	[System.ComponentModel.DataAnnotations.Schema.Table
		(name: Infrastructure.Constants.SECURITY_TABLE_NAME_OF_ROLE, Schema = Infrastructure.Constants.SECURITY_SCHEMA_NAME)]
	public class Role :
		Models.Infrastructure.BaseLocalizedExtendedEntity,
		Models.Infrastructure.IDropDownList,
		Models.Infrastructure.ICode<Enums.Roles>
	{
		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Role>
		{
			public Configuration()
				: base()
			{
				switch (Models.Infrastructure.Utility.DatabaseProvider)
				{
					case Models.Enums.DatabaseProviders.Oracle:
					{
						break;
					}

					case Models.Enums.DatabaseProviders.SqlServer:
					{
						break;
					}

					case Models.Enums.DatabaseProviders.SqlServerCompactEdition:
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

		public Role()
			: base()
		{
		}

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.Name)]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]
		public string Name { get; set; }
		// **********

		// **********
		// **********
		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.Code)]

		[System.ComponentModel.DataAnnotations.Required
			(ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(Dtx.Text.RegularExpressions.Patterns.ZeroOrUnsignedInteger,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName =
			Resources.Strings.MessagesKeys.RegularExpressionForZeroOrUnsignedInteger)]
		public int Code { get; set; }
		// **********

		// **********
		public Enums.Roles CodeEnum
		{
			get
			{
				return ((Enums.Roles)Code);
			}
		}
		// **********
		// **********
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

		// **********
		public virtual System.Collections.Generic.IList<User> Users { get; set; }
		// **********
	}
}
