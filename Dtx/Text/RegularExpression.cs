namespace Dtx.Text
{
	public static class RegularExpression
	{
		public enum RegularExpressions
		{
			Guid,
			GuidWithoutDash,
			Undefined,
			Url,
			Email,
			Numeric,
			UserName,
			Password,
			CaptchaImage
		}

		public static string Get(RegularExpressions regularExpression)
		{
			return (Get(regularExpression, 0, 0));
		}

		public static string Get(RegularExpressions regularExpression, int minLength, int maxLength)
		{
			string strResult = string.Empty;

			switch (regularExpression)
			{
				case RegularExpressions.Url:
				{
					strResult = @"http://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?";
					break;
				}

				case RegularExpressions.Guid:
				{
					strResult = @"[\d-a-zA-Z0-9]{36,36}";
					break;
				}

				case RegularExpressions.GuidWithoutDash:
				{
					strResult = @"[\d-a-zA-Z0-9]{32,32}";
					break;
				}

				case RegularExpressions.Email:
				{
					strResult = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
					break;
				}

				case RegularExpressions.Numeric:
				{
					if (minLength > maxLength)
						strResult = "";
					else
						strResult = @"[0-9۰-۹]{" + minLength + "," + maxLength + "}";

					//strResult = @"[\d_0-9۰۱۲۳۴۵۶۷۸۹]{" + minLength + "," + maxLength + "}";
					//strResult = @"[0-9۰-۹]{" + minLength + "," + maxLength + "}";
					//strResult = @"[\d۰\d۱\d۲\d۳\d۴\d۵\d۶\d۷\d۸\d۹0-9]{" + minLength + "," + maxLength + "}";
					//strResult = @"[۰۱۲۳۴۵۶۷۸۹0-9]{" + minLength + "," + maxLength + "}";

					//strResult = @"[۰۱۲۳۴۵۶۷۸۹0-9]{1,5}";
					//strResult = @"[0-9۰-۹]{1,5}";
					break;
				}

				case RegularExpressions.UserName:
				{
					strResult = @"[\d_a-zA-Z0-9]{8,20}";
					break;
				}

				case RegularExpressions.Password:
				{
					strResult = @"[\d_a-zA-Z0-9]{8,20}";
					break;
				}

				case RegularExpressions.CaptchaImage:
				{
					strResult = @"[a-zA-Z0-9]{6,6}";
					break;
				}
			}

			return (strResult);
		}

		public static bool CheckGuidExpression(string guid, bool withDash)
		{
			bool blnResult = false;

			if (withDash)
			{
				if ((guid != null) &&
					(guid != string.Empty) &&
					(guid.Length == 36) &&
					(System.Text.RegularExpressions.Regex.IsMatch(guid, Get(RegularExpressions.Guid))))
				{
					blnResult = true;
				}
			}
			else
			{
				if ((guid != null) &&
					(guid != string.Empty) &&
					(guid.Length == 32) &&
					(System.Text.RegularExpressions.Regex.IsMatch(guid, Get(RegularExpressions.GuidWithoutDash))))
				{
					blnResult = true;
				}
			}
			return (blnResult);
		}
	}
}
