namespace Models.Infrastructure
{
	[System.Serializable]
	public abstract class BaseExtendedEntity : BaseEntity, IBaseExtendedEntity
	{
		public BaseExtendedEntity() : base()
		{
			Ordering = 10000;

			ActiveDateTime = new ComplexTypes.CustomDateTime();
			DeleteDateTime = new ComplexTypes.CustomDateTime();
			InsertDateTime = new ComplexTypes.CustomDateTime();
			UpdateDateTime = new ComplexTypes.CustomDateTime();
			VerifyDateTime = new ComplexTypes.CustomDateTime();

			InsertDateTime.Value = Utility.Now;
		}

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.IsSystem)]
		public bool IsSystem { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.Ordering)]

		[System.ComponentModel.DataAnnotations.Required
			(ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]

		[System.ComponentModel.DataAnnotations.RegularExpression
			(Dtx.Text.RegularExpressions.Patterns.ZeroOrUnsignedInteger,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName =
			Resources.Strings.MessagesKeys.RegularExpressionForZeroOrUnsignedInteger)]
		public int Ordering { get; set; }
		// **********

		// **********
		// **********
		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.General),
		//	Name = Resources.Models.Strings.GeneralKeys.InsertDateTime)]
		public virtual ComplexTypes.CustomDateTime InsertDateTime { get; protected internal set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.General),
		//	Name = Resources.Models.Strings.GeneralKeys.CreatorUserId)]
		public System.Guid? CreatorUserId { get; protected internal set; }
		// **********

		// **********
		[System.NonSerialized]
		private User _creatorUser;

		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.General),
		//	Name = Resources.Models.Strings.GeneralKeys.CreatorUserId)]
		public virtual User CreatorUser
		{
			get
			{
				return (_creatorUser);
			}
			protected internal set
			{
				_creatorUser = value;
			}
		}
		// **********

		// **********
		public void SetInsertDateTime(System.Guid userId)
		{
			CreatorUserId = userId;
			InsertDateTime.Value = Utility.Now;

			// در حال بررسی
			SetUpdateDateTime(userId);
		}
		// **********
		// **********
		// **********

		// **********
		// **********
		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.General),
		//	Name = Resources.Models.Strings.GeneralKeys.UpdateDateTime)]
		public virtual ComplexTypes.CustomDateTime UpdateDateTime { get; protected internal set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.General),
		//	Name = Resources.Models.Strings.GeneralKeys.EditorUserId)]
		public System.Guid? EditorUserId { get; protected internal set; }
		// **********

		// **********
		[System.NonSerialized]
		private User _editorUser;

		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.General),
		//	Name = Resources.Models.Strings.GeneralKeys.EditorUserId)]
		public virtual User EditorUser
		{
			get
			{
				return (_editorUser);
			}
			protected internal set
			{
				_editorUser = value;
			}
		}
		// **********

		// **********
		public void SetUpdateDateTime(System.Guid userId)
		{
			EditorUserId = userId;
			UpdateDateTime.Value = Utility.Now;
		}
		// **********
		// **********
		// **********

		// **********
		// **********
		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.IsActive)]
		public bool IsActive { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.General),
		//	Name = Resources.Models.Strings.GeneralKeys.ActiveDateTime)]
		public ComplexTypes.CustomDateTime ActiveDateTime { get; protected internal set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.General),
		//	Name = Resources.Models.Strings.GeneralKeys.ActivatorUserId)]
		public System.Guid? ActivatorUserId { get; protected internal set; }
		// **********

		// **********
		[System.NonSerialized]
		private User _activatorUser;

		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.General),
		//	Name = Resources.Models.Strings.GeneralKeys.ActivatorUserId)]
		public virtual User ActivatorUser
		{
			get
			{
				return (_activatorUser);
			}
			protected internal set
			{
				_activatorUser = value;
			}
		}
		// **********

		// **********
		public void SetIsActive(bool isActive, System.Guid userId)
		{
			if (isActive)
			{
				if (IsActive == false)
				{
					IsActive = true;
					ActivatorUserId = userId;
					ActiveDateTime.Value = Utility.Now;
				}
				else
				{
					if (ActivatorUserId.HasValue == false)
					{
						ActivatorUserId = userId;
					}

					if (ActiveDateTime.Value.HasValue == false)
					{
						ActiveDateTime.Value = Utility.Now;
					}
				}
			}
			else
			{
				if (IsActive)
				{
					IsActive = false;
					ActivatorUserId = userId;
					ActiveDateTime.Value = Utility.Now;
				}
			}
		}
		// **********
		// **********
		// **********

		// **********
		// **********
		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.IsVerified)]
		public bool IsVerified { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.General),
		//	Name = Resources.Models.Strings.GeneralKeys.VerifyDateTime)]
		public ComplexTypes.CustomDateTime VerifyDateTime { get; protected internal set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.General),
		//	Name = Resources.Models.Strings.GeneralKeys.VerifierUserId)]
		public System.Guid? VerifierUserId { get; protected internal set; }
		// **********

		// **********
		[System.NonSerialized]
		private User _verifierUser;

		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.General),
		//	Name = Resources.Models.Strings.GeneralKeys.VerifierUserId)]
		public virtual User VerifierUser
		{
			get
			{
				return (_verifierUser);
			}
			protected internal set
			{
				_verifierUser = value;
			}
		}
		// **********

		// **********
		public void SetIsVerified(bool isVerified, System.Guid userId)
		{
			if (isVerified)
			{
				if (IsVerified == false)
				{
					IsVerified = true;
					VerifierUserId = userId;
					VerifyDateTime.Value = Utility.Now;
				}
				else
				{
					if (VerifierUserId.HasValue == false)
					{
						VerifierUserId = userId;
					}

					if (VerifyDateTime.Value.HasValue == false)
					{
						VerifyDateTime.Value = Utility.Now;
					}
				}
			}
			else
			{
				if (IsVerified)
				{
					IsVerified = false;
					VerifierUserId = userId;
					VerifyDateTime.Value = Utility.Now;
				}
			}
		}
		// **********
		// **********
		// **********

		// **********
		// **********
		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.IsDeleted)]
		public bool IsDeleted { get; set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.General),
		//	Name = Resources.Models.Strings.GeneralKeys.DeleteDateTime)]
		public ComplexTypes.CustomDateTime DeleteDateTime { get; protected internal set; }
		// **********

		// **********
		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.General),
		//	Name = Resources.Models.Strings.GeneralKeys.RemoverUserId)]
		public System.Guid? RemoverUserId { get; protected internal set; }
		// **********

		// **********
		[System.NonSerialized]
		private User _removerUser;

		// TODO
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.Models.General),
		//	Name = Resources.Models.Strings.GeneralKeys.RemoverUserId)]
		public virtual User RemoverUser
		{
			get
			{
				return (_removerUser);
			}
			protected internal set
			{
				_removerUser = value;
			}
		}
		// **********

		// **********
		public void SetIsDeleted(bool isDeleted, System.Guid userId)
		{
			if (isDeleted)
			{
				if (IsDeleted == false)
				{
					IsDeleted = true;
					RemoverUserId = userId;
					DeleteDateTime.Value = Utility.Now;
				}
				else
				{
					if (RemoverUserId.HasValue == false)
					{
						RemoverUserId = userId;
					}

					if (DeleteDateTime.Value.HasValue == false)
					{
						DeleteDateTime.Value = Utility.Now;
					}
				}
			}
			else
			{
				if (IsDeleted)
				{
					IsDeleted = false;
					RemoverUserId = userId;
					DeleteDateTime.Value = Utility.Now;
				}
			}
		}
		// **********
		// **********
		// **********
	}
}
