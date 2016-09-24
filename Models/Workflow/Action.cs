namespace Models.Workflow
{
	[System.ComponentModel.DataAnnotations.Schema.Table
		(name: Infrastructure.Constants.WORKFLOW_TABLE_NAME_OF_ACTION,
		Schema = Infrastructure.Constants.WORKFLOW_SCHEMA_NAME)]
	public class Action :
		Models.Infrastructure.BaseExtendedEntity
	{
		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<State>
		{
			public Configuration()
				: base()
			{
				HasRequired(current => current.Process)
					.WithMany(other => other.States)
					.HasForeignKey(current => current.ProcessId)
					.WillCascadeOnDelete(false)
					;

				HasRequired(current => current.StateType)
					.WithMany(other => other.States)
					.HasForeignKey(current => current.StateTypeId)
					.WillCascadeOnDelete(false)
					;

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

		public Action()
			: base()
		{
		}

		// **********
		// **********
		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.Workflow.WorkflowStateType),
		//	Name = Resources.Models.Workflow.Strings.WorkflowStateTypeKeys.EntityName)]

		[System.ComponentModel.DataAnnotations.Required
			(ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]
		public System.Guid ActionTypeId { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.Workflow.WorkflowStateType),
		//	Name = Resources.Models.Workflow.Strings.WorkflowStateTypeKeys.EntityName)]
		public virtual ActionType ActionType { get; set; }
		// **********
		// **********
		// **********

		// **********
		// **********
		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.Workflow.Process),
			Name = Resources.Models.Workflow.Strings.ProcessKeys.EntityName)]

		[System.ComponentModel.DataAnnotations.Required
			(ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]
		public System.Guid ProcessId { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.Workflow.Process),
			Name = Resources.Models.Workflow.Strings.ProcessKeys.EntityName)]
		public virtual Workflow.Process Process { get; set; }
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
	}
}
