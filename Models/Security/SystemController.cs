namespace Models.Security
{
	[System.ComponentModel.DataAnnotations.Schema.Table
		(name: Infrastructure.Constants.SECURITY_TABLE_NAME_OF_SYSTEM_CONTROLLERS, Schema = Infrastructure.Constants.SECURITY_SCHEMA_NAME)]
	public class SystemController : Infrastructure.BaseSystemAreaControllerAction
	{
		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SystemController>
		{
			public Configuration()
				: base()
			{
				// **************************************************
				// *** Define Index(es) *****************************
				// **************************************************
				Property(current => current.SystemAreaId)
					.HasColumnAnnotation("Index",
					new System.Data.Entity.Infrastructure.Annotations.IndexAnnotation
						(new System.ComponentModel.DataAnnotations.Schema.IndexAttribute
							("IX_SecurityAreaId_Name", 1) { IsUnique = true }));

				Property(current => current.Name)
					.HasColumnAnnotation("Index",
					new System.Data.Entity.Infrastructure.Annotations.IndexAnnotation
						(new System.ComponentModel.DataAnnotations.Schema.IndexAttribute
							("IX_SecurityAreaId_Name", 2) { IsUnique = true }));
				// **************************************************
				// *** /Define Index(es) ****************************
				// **************************************************

				HasRequired(current => current.SystemArea)
					.WithMany(SecurityArea => SecurityArea.SystemControllers)
					.HasForeignKey(current => current.SystemAreaId)
					.WillCascadeOnDelete(false);

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

		// TODO
		//#region Static Method(s)
		//public static string GetDisplayName(SecurityController SecurityController)
		//{
		//	if (SecurityController == null)
		//	{
		//		return (string.Empty);
		//	}

		//	string strResult = SecurityController.DisplayName;

		//	if (strResult == null)
		//	{
		//		strResult = SecurityController.Name;
		//	}
		//	else
		//	{
		//		strResult = strResult.Trim();

		//		if (strResult == string.Empty)
		//		{
		//			strResult = SecurityController.Name;
		//		}
		//	}

		//	return (strResult);
		//}
		//#endregion /Static Method(s)

		public SystemController()
			: base()
		{
		}

		// **********
		// **********
		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.SecurityArea),
		//	Name = Resources.Models.Strings.SecurityAreaKeys.EntityName)]

		[System.ComponentModel.DataAnnotations.Required
			(ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]
		public System.Guid SystemAreaId { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.SecurityArea),
		//	Name = Resources.Models.Strings.SecurityAreaKeys.EntityName)]
		public virtual SystemArea SystemArea { get; set; }
		// **********
		// **********
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
			(maximumLength: 250,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]
		public string Name { get; set; }
		// **********

		// **********
		public virtual System.Collections.Generic.IList<SystemAction> SystemActions { get; set; }
		// **********
	}
}
