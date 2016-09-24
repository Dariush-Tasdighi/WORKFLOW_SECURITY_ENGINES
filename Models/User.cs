using System.Linq;

namespace Models
{
	[System.ComponentModel.DataAnnotations.Schema.Table
		(name: Infrastructure.Constants.TABLE_NAME_OF_USER,
		Schema = Infrastructure.Constants.SCHEMA_NAME)]
	public class User :
		Models.Infrastructure.BaseLocalizedExtendedEntity
	{
		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<User>
		{
			public Configuration()
				: base()
			{
				HasRequired(current => current.Role)
					.WithMany(other => other.Users)
					.HasForeignKey(current => current.RoleId)
					.WillCascadeOnDelete(false)
					;

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

		public User()
			: base()
		{
		}

		// **********
		// **********
		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.Security.Role),
			Name = Resources.Models.Security.Strings.RoleKeys.EntityName)]

		[System.ComponentModel.DataAnnotations.Required
			(ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]
		public System.Guid RoleId { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.Security.Role),
			Name = Resources.Models.Security.Strings.RoleKeys.EntityName)]
		public virtual Security.Role Role { get; set; }
		// **********
		// **********
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.FirstName)]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]
		public string FirstName { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.LastName)]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]
		public string LastName { get; set; }
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
		public virtual System.Collections.Generic.IList<Security.Group> Groups { get; set; }
		// **********

		// **********
		public virtual System.Collections.Generic.IList<Security.SystemAction> SystemActions { get; set; }
		// **********
	}
}
