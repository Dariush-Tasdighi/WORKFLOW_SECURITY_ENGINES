namespace Dtx.Calendar
{
	/// <summary>
	/// Version: 1.0.1
	/// Update Date: 1394/10/06
	/// Changed in New Version: 1.0.7
	/// Developer: Mr. Dariush Tasdighi
	/// </summary>
	public class Year : System.Object
	{
		// **************************************************
		private static System.Collections.Generic.List<Year> _years;

		public static System.Collections.Generic.List<Year> Years
		{
			get
			{
				if (_years == null)
				{
					_years =
						new System.Collections.Generic.List<Year>();

					for (int intIndex = 1395; intIndex >= 1300; intIndex--)
					{
						_years.Add(new Year(intIndex));
					}
				}

				return (_years);
			}
		}
		// **************************************************

		public Year()
			: base()
		{
		}

		public Year(int value)
		{
			Value = value;
		}

		public int Value { get; set; }

		public string Text
		{
			get
			{
				return (Dtx.Text.Convert.DisplayNumber(Value));
			}
		}
	}
}
