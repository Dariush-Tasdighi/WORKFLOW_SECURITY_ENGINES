namespace Dtx.Text.RegularExpressions
{
	public static class Regex
	{
		static Regex()
		{
		}

		public static bool IsMatch(string input, Enums.PatternTypes pattern)
		{
			switch (pattern)
			{
				case Enums.PatternTypes.Url:
				{
					return (System.Text.RegularExpressions.Regex.IsMatch
						(input, @"^(https?)://(((([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5]))|((([a-zA-Z0-9]|[a-zA-Z0-9][a-zA-Z0-9\-]*[a-zA-Z0-9])\.)*([A-Za-z0-9]|[A-Za-z0-9][A-Za-z0-9\-]*[A-Za-z0-9])))(:[1-9][0-9]+)?(/)?([/?].+)?$"));
					//(input, @"http://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?"));
				}

				case Enums.PatternTypes.Email:
				{
					return (System.Text.RegularExpressions.Regex.IsMatch
						(input, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"));
				}

				default:
				{
					return (false);
				}
			}
		}
	}
}
