namespace Models.Security
{
	[System.ComponentModel.DataAnnotations.Schema.Table
		(name: Infrastructure.Constants.SECURITY_TABLE_NAME_OF_SYSTEM_AREA, Schema = Infrastructure.Constants.SECURITY_SCHEMA_NAME)]
	public class SystemArea :
		Infrastructure.BaseSystemAreaControllerAction,
		Models.Infrastructure.IDropDownList
	{
		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SystemArea>
		{
			public Configuration() : base()
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

		// TODO
		//#region Static Method(s)
		//public static string GetDisplayName(SecurityArea securityArea)
		//{
		//	if (securityArea == null)
		//	{
		//		return (string.Empty);
		//	}

		//	string strResult = securityArea.DisplayName;

		//	if (strResult == null)
		//	{
		//		strResult = securityArea.Name;
		//	}
		//	else
		//	{
		//		strResult = strResult.Trim();

		//		if (strResult == string.Empty)
		//		{
		//			strResult = securityArea.Name;
		//		}
		//	}

		//	return (strResult);
		//}
		//#endregion /Static Method(s)

		public SystemArea() : base()
		{
		}

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.Name)]

		// Note: دستور ذيل نبايد نوشته شود
		//[System.ComponentModel.DataAnnotations.Required
		//	(AllowEmptyStrings = false,
		//	ErrorMessageResourceType = typeof(Resources.Messages),
		//	ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 250,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]

		[System.ComponentModel.DataAnnotations.Schema.Index(IsUnique = true)]
		public string Name { get; set; }
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
		public virtual System.Collections.Generic.IList<SystemController> SystemControllers { get; set; }
		// **********
	}
}
