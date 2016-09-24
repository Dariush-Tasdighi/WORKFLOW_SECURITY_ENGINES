namespace Dtx.Web.Mvc.Security
{
	public static class Utility
	{
		static Utility()
		{
		}

		public static bool CheckPermission(System.Web.Mvc.ActionResult actionResult)
		{
			// **************************************************
			System.Web.Mvc.IT4MVCActionResult
				oT4MVCActionResult = actionResult as System.Web.Mvc.IT4MVCActionResult;

			if (oT4MVCActionResult == null)
			{
				return (false);
			}
			// **************************************************

			// **************************************************
			string strAreaName = string.Empty;

			object objAreaName =
				oT4MVCActionResult.RouteValueDictionary["Area"];

			if (objAreaName != null)
			{
				strAreaName =
					objAreaName.ToString().Replace(" ", string.Empty);
			}
			// **************************************************

			bool blnCheckPermission =
				CheckPermission(strAreaName, oT4MVCActionResult.Controller, oT4MVCActionResult.Action);

			return (blnCheckPermission);

			//return (CheckPermission
			//	(strAreaName, oT4MVCActionResult.Controller, oT4MVCActionResult.Action));
		}

		public static bool CheckPermission(string areaName, string controllerName, string actionName)
		{
			// TODO برای تست
			return (true);

			if (AuthenticatedUser.IsAuthenticated)
			{
				switch (Sessions.AuthenticatedUser.Role)
				{
					case Models.Security.Enums.Roles.Programmer:
					{
						return (true);
					}
				}
			}

			// **************************************************
			// اگر
			// Infrastructure.AuthenticatedUser.IsAuthenticated = false
			// يا
			//		Infrastructure.AuthenticatedUser.IsAuthenticated = true
			//		و
			//		Infrastructure.Sessions.AuthenticatedUser.Role != Models.Enums.Roles.Programmer
			// **************************************************

			// TODO
			//DAL.UnitOfWork oUnitOfWork = new DAL.UnitOfWork();

			// TODO
			// **************************************************
			//Models.ProjectAction oProjectAction =
			//	oUnitOfWork.ProjectActionRepository
			//	.GetByRouteValues(areaName, controllerName, actionName);

			//if (oProjectAction == null)
			//{
			//	return (false);
			//}
			// **************************************************

			// **************************************************
			// اگر
			// oProjectAction != null
			// **************************************************

			// TODO
			//if ((oProjectAction.IsVisibleJustForProgrammer) ||
			//	(oProjectAction.ProjectController.IsVisibleJustForProgrammer) ||
			//	(oProjectAction.ProjectController.ProjectArea.IsVisibleJustForProgrammer))
			//{
			//	return (false);
			//}

			//if (Infrastructure.AuthenticatedUser.IsAuthenticated)
			//{
			//	switch (Infrastructure.Sessions.AuthenticatedUser.Role)
			//	{
			//		case Models.Enums.Roles.Owner:
			//		case Models.Enums.Roles.Administrator:
			//		{
			//			return (true);
			//		}
			//	}
			//}

			// **************************************************
			// اگر
			// Infrastructure.AuthenticatedUser.IsAuthenticated = false
			// يا
			//		Infrastructure.AuthenticatedUser.IsAuthenticated = true
			//		و
			//			Infrastructure.Sessions.AuthenticatedUser.Role == Models.Enums.Roles.User
			//			يا
			//			Infrastructure.Sessions.AuthenticatedUser.Role == Models.Enums.Roles.Supervisor
			// **************************************************

			// TODO
			//if ((oProjectAction.IsActive == false) ||
			//	(oProjectAction.ProjectController.IsActive == false) ||
			//	(oProjectAction.ProjectController.ProjectArea.IsActive == false))
			//{
			//	return (false);
			//}

			// **************************************************
			// oProjectAction.IsActive = true
			// و
			// oProjectAction.ProjectController.IsActive = true
			// و
			// oProjectAction.ProjectController.ProjectArea.IsActive = true
			// **************************************************

			// TODO
			//if (oProjectAction.AccessTypeEnum == Models.Enums.AccessTypes.Public)
			//{
			//	return (true);
			//}

			// **************************************************
			// اگر
			// oProjectAction.IsPublic == false
			// **************************************************

			// TODO
			//if (Infrastructure.AuthenticatedUser.IsAuthenticated == false)
			//{
			//	return (false);
			//}

			// **************************************************
			// اگر
			// Infrastructure.AuthenticatedUser.IsAuthenticated = true
			// **************************************************

			// TODO
			//if (oProjectAction.AccessTypeEnum == Models.Enums.AccessTypes.Registered)
			//{
			//	return (true);
			//}

			// **************************************************
			// اگر
			// oProjectAction.AccessTypeEnum = Models.Enums.AccessTypes.Special
			// و
			//		Infrastructure.Sessions.AuthenticatedUser.Role = Models.Enums.Roles.User
			//		يا
			//		Infrastructure.Sessions.AuthenticatedUser.Role = Models.Enums.Roles.Supervisor
			// **************************************************

			// TODO
			//int intGroupCount =
			//	oUnitOfWork.GroupRepository.GetActiveGroupCountByUserIdAndActionId
			//	(Infrastructure.Sessions.AuthenticatedUser.Id, oProjectAction.Id);

			//if (intGroupCount >= 1)
			//{
			//	return (true);
			//}

			// **************************************************
			// اگر
			// intGroupCount = 0
			// **************************************************

			// TODO
			//bool blnUserHasDirectAccessForAction =
			//	oUnitOfWork.UserRepository.CheckDirectAccessForAction
			//	(Infrastructure.Sessions.AuthenticatedUser.Id, oProjectAction.Id);

			//if (blnUserHasDirectAccessForAction)
			//{
			//	return (true);
			//}

			// **************************************************
			// اگر
			// blnUserHasDirectAccessForAction = false
			// **************************************************

			// TODO
			//return (false);
		}
	}
}
