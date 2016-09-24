namespace Dtx.Calendar
{
	public class Age : System.Object
	{
		private static System.Collections.Generic.List<Age> _ages;
		public static System.Collections.Generic.List<Age> Ages
		{
			get
			{
				if (_ages == null)
				{
					_ages =
						new System.Collections.Generic.List<Age>();

					for (int intIndex = 1; intIndex <= 99; intIndex++)
					{
						_ages.Add(new Age(intIndex));
					}
				}

				return (_ages);
			}
		}

		public Age()
		{
		}

		public Age(int value)
		{
			Value = value;
		}

		public int Value { get; set; }

		public string Text
		{
			get
			{
				return (Dtx.Text.Convert.DisplayFormattedNumber(Value));
			}
		}
	}
}
