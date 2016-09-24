namespace Models.Security
{
	[System.ComponentModel.DataAnnotations.Schema.Table
		(name: Infrastructure.Constants.SECURITY_TABLE_NAME_OF_SYSTEM_ACTION, Schema = Infrastructure.Constants.SECURITY_SCHEMA_NAME)]
	public class SystemAction : Infrastructure.BaseSystemAreaControllerAction
	{
		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SystemAction>
		{
			public Configuration()
				: base()
			{
				// **************************************************
				// *** Define Index(es) *****************************
				// **************************************************
				Property(current => current.SystemControllerId)
					.HasColumnAnnotation("Index",
					new System.Data.Entity.Infrastructure.Annotations.IndexAnnotation
						(new System.ComponentModel.DataAnnotations.Schema.IndexAttribute
							("IX_SecurityControllerId_Name", 1)
						{ IsUnique = true }));

				Property(current => current.Name)
					.HasColumnAnnotation("Index",
					new System.Data.Entity.Infrastructure.Annotations.IndexAnnotation
						(new System.ComponentModel.DataAnnotations.Schema.IndexAttribute
							("IX_SecurityControllerId_Name", 2)
						{ IsUnique = true }));
				// **************************************************
				// *** /Define Index(es) ****************************
				// **************************************************

				//HasOptional(current => current.Layout)
				//	.WithMany(layout => layout.SecurityActions)
				//	.HasForeignKey(current => current.LayoutId)
				//	.WillCascadeOnDelete(true);

				HasRequired(current => current.SystemController)
					.WithMany(SecurityController => SecurityController.SystemActions)
					.HasForeignKey(current => current.SystemControllerId)
					.WillCascadeOnDelete(true);

				HasMany(current => current.Groups)
					.WithMany(group => group.SystemActions)
					.Map(current =>
					{
						current.ToTable("SecuritySystemActionsOfGroups", Infrastructure.Constants.SECURITY_SCHEMA_NAME);
						// MapRightKey را می نويسيم و بعد MapLeftKey اول
						// و سپس قانون دور در دور و نزديک در نزديک را رعايت می کنيم
						current.MapLeftKey("SystemActionId");
						current.MapRightKey("GroupId");
					});

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
		//public static string GetDisplayName(SecurityAction securityAction)
		//{
		//	if (securityAction == null)
		//	{
		//		return (string.Empty);
		//	}

		//	string strResult = securityAction.DisplayName;

		//	if (strResult == null)
		//	{
		//		strResult = securityAction.Name;
		//	}
		//	else
		//	{
		//		strResult = strResult.Trim();

		//		if (strResult == string.Empty)
		//		{
		//			strResult = securityAction.Name;
		//		}
		//	}

		//	return (strResult);
		//}
		//#endregion /Static Method(s)

		public SystemAction()
			: base()
		{
		}

		// **********
		// **********
		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.SecurityController),
		//	Name = Resources.Models.Strings.SecurityControllerKeys.EntityName)]

		[System.ComponentModel.DataAnnotations.Required
			(ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]
		public System.Guid SystemControllerId { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.SecurityController),
		//	Name = Resources.Models.Strings.SecurityControllerKeys.EntityName)]
		public virtual SystemController SystemController { get; set; }
		// **********
		// **********
		// **********

		// TODO
		//// **********
		//// **********
		//// **********
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.Cms.Layout),
		//	Name = Resources.Models.Cms.Strings.LayoutKeys.EntityName)]

		//public System.Guid? LayoutId { get; set; }
		//// **********

		//// **********
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.Cms.Layout),
		//	Name = Resources.Models.Cms.Strings.LayoutKeys.EntityName)]
		//public virtual Cms.Layout Layout { get; set; }
		//// **********
		//// **********
		//// **********

		// **********
		// **********
		// **********
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.AccessType),
		//	Name = Resources.Models.Strings.AccessTypeKeys.EntityName)]

		[System.ComponentModel.DataAnnotations.Required
			(ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]
		public System.Guid AccessTypeId { get; set; }
		// **********

		// **********
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.AccessType),
		//	Name = Resources.Models.Strings.AccessTypeKeys.EntityName)]
		public virtual AccessType AccessType { get; set; }
		// **********

		// **********
		public Enums.AccessTypes AccessTypeEnum
		{
			get
			{
				return ((Enums.AccessTypes)AccessType.Code);

				// TODO
				//if (AccessType == null)
				//{
				//	return (Enums.Security.AccessTypes.Special);
				//}
				//else
				//{
				//	return ((Enums.Security.AccessTypes)AccessType.Code);
				//}
			}
		}
		// **********
		// **********
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]
		public string Name { get; set; }
		// **********

		// **********
		public virtual System.Collections.Generic.IList<User> Users { get; set; }
		// **********

		// **********
		public virtual System.Collections.Generic.IList<Group> Groups { get; set; }
		// **********
	}
}
