namespace Models.Infrastructure
{
	public interface ICode<T> where T : struct, System.IConvertible
	{
		T CodeEnum { get; }

		int Code { get; set; }
	}
}

//// **********
//// **********
//// **********
//[System.ComponentModel.DataAnnotations.Display
//	(ResourceType = typeof(Resources.Models.General),
//	Name = Resources.Models.Strings.GeneralKeys.Code)]

//[System.ComponentModel.DataAnnotations.Required
//	(ErrorMessageResourceType = typeof(Resources.Messages),
//	ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]

//[System.ComponentModel.DataAnnotations.RegularExpression
//	(Dtx.Text.RegularExpressions.Patterns.ZeroOrUnsignedInteger,
//	ErrorMessageResourceType = typeof(Resources.Messages),
//	ErrorMessageResourceName =
//	Resources.Strings.MessagesKeys.RegularExpressionForZeroOrUnsignedInteger)]
//public int Code { get; set; }
//// **********

//// **********
//public Enums.WorkflowActivityTypes CodeEnum
//{
//	get
//	{
//		return ((Enums.WorkflowActivityTypes)Code);
//	}
//}
//// **********
//// **********
//// **********
