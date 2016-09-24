namespace Models.Workflow
{
	[System.ComponentModel.DataAnnotations.Schema.Table
		(name: Infrastructure.Constants.WORKFLOW_TABLE_NAME_OF_STATE_TYPE,
		Schema = Infrastructure.Constants.WORKFLOW_SCHEMA_NAME)]
	public class StateType :
		Models.Infrastructure.BaseExtendedEntity,
		Models.Infrastructure.ICode<Enums.StateTypes>
	{
		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<StateType>
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

		public StateType()
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
		public Enums.StateTypes CodeEnum
		{
			get
			{
				return ((Enums.StateTypes)Code);
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
		public virtual System.Collections.Generic.IList<State> States { get; set; }
		// **********
	}
}
