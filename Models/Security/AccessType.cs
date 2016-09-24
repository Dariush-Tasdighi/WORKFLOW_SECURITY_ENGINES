namespace Models.Security
{
	[System.ComponentModel.DataAnnotations.Schema.Table
		(name: Infrastructure.Constants.SECURITY_TABLE_NAME_OF_ACCESSTYPE, Schema = Infrastructure.Constants.SECURITY_SCHEMA_NAME)]
	public class AccessType :
		Models.Infrastructure.BaseLocalizedExtendedEntity,
		Models.Infrastructure.ICode<Enums.AccessTypes>
	{
		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AccessType>
		{
			public Configuration()
				: base()
			{
				// TODO
				//// **************************************************
				//// *** Define Index(es) *****************************
				//// **************************************************
				//Property(current => current.CultureLcid)
				//	.HasColumnAnnotation("Index",
				//		new System.Data.Entity.Infrastructure.Annotations.IndexAnnotation(new[]
				//		{
				//			new System.ComponentModel.DataAnnotations.Schema.IndexAttribute
				//				("IX_CultureLcid_Code", 1) { IsUnique = true },
				//			new System.ComponentModel.DataAnnotations.Schema.IndexAttribute
				//				("IX_CultureLcid_Name", 1) { IsUnique = true },
				//		}));
				//// **************************************************

				//// **************************************************
				//Property(current => current.Code)
				//	.HasColumnAnnotation("Index",
				//	new System.Data.Entity.Infrastructure.Annotations.IndexAnnotation
				//		(new System.ComponentModel.DataAnnotations.Schema.IndexAttribute
				//			("IX_CultureLcid_Code", 2)
				//		{ IsUnique = true }));

				//Property(current => current.Name)
				//	.HasColumnAnnotation("Index",
				//	new System.Data.Entity.Infrastructure.Annotations.IndexAnnotation
				//		(new System.ComponentModel.DataAnnotations.Schema.IndexAttribute
				//			("IX_CultureLcid_Name", 2)
				//		{ IsUnique = true }));
				//// **************************************************
				//// *** /Define Index(es) ****************************
				//// **************************************************

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
		//public static SecurityAccessType GetByCultureAndCode(int cultureLcid, Enums.SecurityAccessTypes code)
		//{
		//	AccessType oResult = null;
		//	DatabaseContext oDatabaseContext = null;

		//	try
		//	{
		//		oDatabaseContext =
		//			new DatabaseContext();

		//		oResult =
		//			oDatabaseContext.SecurityAccessTypes
		//			.Where(current => current.Code == (int)code)
		//			.Where(current => current.CultureLcid == cultureLcid)
		//			.FirstOrDefault();
		//	}
		//	catch
		//	{
		//	}
		//	finally
		//	{
		//		if (oDatabaseContext != null)
		//		{
		//			oDatabaseContext.Dispose();
		//			oDatabaseContext = null;
		//		}
		//	}

		//	return (oResult);
		//}

		public AccessType()
			: base()
		{
		}

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
		public Enums.AccessTypes CodeEnum
		{
			get
			{
				return ((Enums.AccessTypes)Code);
			}
		}
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
			(maximumLength: 100,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.MaxLength)]
		public string Name { get; set; }
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
		public virtual System.Collections.Generic.IList<SystemAction> SystemActions { get; set; }
		// **********
	}
}
