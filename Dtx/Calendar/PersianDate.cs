namespace Dtx.Calendar
{
	/// <summary>
	/// Dariush Tasdighi - 1386/02/01 - Version: 3.0.0
	/// </summary>
	public class PersianDate
	{
		/// <summary>
		/// 23:02:07
		/// </summary>
		public static string GetTime1(System.DateTime dateTime)
		{
			string strResult =
				Dtx.Text.Convert.DigitsToUnicode(dateTime.Hour.ToString().PadLeft(2, '0')) +
				":" +
				Dtx.Text.Convert.DigitsToUnicode(dateTime.Minute.ToString().PadLeft(2, '0')) +
				":" +
				Dtx.Text.Convert.DigitsToUnicode(dateTime.Second.ToString().PadLeft(2, '0'));

			return (strResult);
		}

		#region Private Fields
		private int _day = -1;
		private int _year = -1;
		private int _month = -1;
		private System.DayOfWeek? _dayOfWeek = null;
		#endregion /Private Fields

		#region Public Properties
		/// <summary>
		/// Dariush Tasdighi - 1386/02/01 - Version: 3.0.0
		/// </summary>
		public int Day
		{
			get
			{
				return (_day);
			}
			private set
			{
				_day = value;
			}
		}

		/// <summary>
		/// Dariush Tasdighi - 1386/02/01 - Version: 3.0.0
		/// </summary>
		public int Month
		{
			get
			{
				return (_month);
			}
			private set
			{
				_month = value;
			}
		}

		/// <summary>
		/// Dariush Tasdighi - 1386/02/01 - Version: 3.0.0
		/// </summary>
		public int Year
		{
			get
			{
				return (_year);
			}
			private set
			{
				_year = value;
			}
		}

		/// <summary>
		/// ۱۳۸۷/۱۱/۱۳
		/// </summary>
		public string Value1
		{
			get
			{
				string strResult =
					Dtx.Text.Convert.DigitsToUnicode(Year.ToString().PadLeft(4, '0')) +
					"/" +
					Dtx.Text.Convert.DigitsToUnicode(Month.ToString().PadLeft(2, '0')) +
					"/" +
					Dtx.Text.Convert.DigitsToUnicode(Day.ToString().PadLeft(2, '0')) +
					"";

				return (strResult);
			}
		}

		/// <summary>
		/// ۱۳۸۷/۱۱/۱۳
		/// </summary>
		public string ReverseValue1
		{
			get
			{
				string strResult =
					Dtx.Text.Convert.DigitsToUnicode(Day.ToString().PadLeft(2, '0')) +
					"/" +
					Dtx.Text.Convert.DigitsToUnicode(Month.ToString().PadLeft(2, '0')) +
					"/" +
					Dtx.Text.Convert.DigitsToUnicode(Year.ToString().PadLeft(4, '0')) +
					"";

				return (strResult);
			}
		}

		/// <summary>
		/// سيزدهم بهمن ۱۳۸۷
		/// </summary>
		public string Value2
		{
			get
			{
				string strResult = "" +
					GetDayOfMonthName(Day) + " " +
					GetMonthName(Month) + " " +
					Dtx.Text.Convert.DigitsToUnicode(Year) + " " +
					"";

				return (strResult);
			}
		}

		/// <summary>
		/// سيزدهم بهمن ۱۳۸۷
		/// </summary>
		public string ReverseValue2
		{
			get
			{
				string strResult = "" +
					Dtx.Text.Convert.DigitsToUnicode(Year) + " " +
					GetMonthName(Month) + " " +
					GetDayOfMonthName(Day) + " " +
					"";

				return (strResult);
			}
		}

		/// <summary>
		/// جمعه ۱۳ بهمن ۱۳۸۷
		/// </summary>
		public string Value3
		{
			get
			{
				string strResult = "" +
					GetDayOfWeekName(DayOfWeek) + " " +
					Dtx.Text.Convert.DigitsToUnicode(Day) + " " +
					GetMonthName(Month) + " " +
					Dtx.Text.Convert.DigitsToUnicode(Year) + " " +
					"";

				return (strResult);
			}
		}

		/// <summary>
		/// جمعه ۱۳ بهمن ۱۳۸۷
		/// </summary>
		public string ReverseValue3
		{
			get
			{
				string strResult = "" +
					Dtx.Text.Convert.DigitsToUnicode(Year) + " " +
					GetMonthName(Month) + " " +
					Dtx.Text.Convert.DigitsToUnicode(Day) + " " +
					GetDayOfWeekName(DayOfWeek) + " " +
					"";

				return (strResult);
			}
		}

		/// <summary>
		/// جمعه سيزدهم بهمن ۱۳۸۷
		/// </summary>
		public string Value4
		{
			get
			{
				string strResult = "" +
					GetDayOfWeekName(DayOfWeek) + " " +
					GetDayOfMonthName(Day) + " " +
					GetMonthName(Month) + " " +
					Dtx.Text.Convert.DigitsToUnicode(Year) + " " +
					"";

				return (strResult);
			}
		}

		/// <summary>
		/// جمعه سيزدهم بهمن ۱۳۸۷
		/// </summary>
		public string ReverseValue4
		{
			get
			{
				string strResult = "" +
					Dtx.Text.Convert.DigitsToUnicode(Year) + " " +
					GetMonthName(Month) + " " +
					GetDayOfMonthName(Day) + " " +
					GetDayOfWeekName(DayOfWeek) + " " +
					"";

				return (strResult);
			}
		}

		/// <summary>
		/// جمعه سيزدهم بهمن يک هزار و سيصد و هشتاد و هفت
		/// </summary>
		public string Value5
		{
			get
			{
				string strResult = "" +
					GetDayOfWeekName(DayOfWeek) + " " +
					GetDayOfMonthName(Day) + " " +
					GetMonthName(Month) + " " +
					Dtx.Text.Convert.NumberToWord(Year) + " " +
					"";

				return (strResult);
			}
		}

		/// <summary>
		/// جمعه سيزدهم بهمن يک هزار و سيصد و هشتاد و هفت
		/// </summary>
		public string ReverseValue5
		{
			get
			{
				string strResult = "" +
					Dtx.Text.Convert.NumberToWord(Year) + " " +
					GetMonthName(Month) + " " +
					GetDayOfMonthName(Day) + " " +
					GetDayOfWeekName(DayOfWeek) + " " +
					"";

				return (strResult);
			}
		}

		/// <summary>
		/// Dariush Tasdighi - 1386/02/01 - Version: 3.0.0
		/// </summary>
		public bool IsLeapYear
		{
			get
			{
				return (CheckLeapYear(Year));
			}
		}

		/// <summary>
		/// Dariush Tasdighi - 1386/02/01 - Version: 3.0.0
		/// </summary>
		public System.DayOfWeek DayOfWeek
		{
			get
			{
				if (_dayOfWeek == null)
					_dayOfWeek = Convert.GetPersianDayOfWeekIndex(Year, Month, Day);

				return ((System.DayOfWeek)_dayOfWeek);
			}
			internal set
			{
				_dayOfWeek = value;
			}
		}

		/// <summary>
		/// Dariush Tasdighi - 1386/02/01 - Version: 3.0.0
		/// </summary>
		public string DayOfMonthName
		{
			get
			{
				return (GetDayOfMonthName(Day));
			}
		}

		/// <summary>
		/// Dariush Tasdighi - 1386/02/01 - Version: 3.0.0
		/// </summary>
		public string DayOfWeekName
		{
			get
			{
				return (GetDayOfWeekName(DayOfWeek));
			}
		}
		#endregion /Public Properties

		#region Internal Static Methods
		/// <summary>
		/// Dariush Tasdighi - 1386/02/01 - Version: 3.0.0
		/// </summary>
		internal static string ParseDate(string date, out int year, out int month, out int day)
		{
			int intFirstIndex;
			int intSecondIndex;
			int intYear, intMonth, intDay;

			day = 0;
			year = 0;
			month = 0;

			date = date.Replace(" ", "");

			if (date.Length < 5)
				return ("");

			string strTemp = date;
			strTemp = strTemp.Replace("/", "");

			if (date.Length - strTemp.Length != 2)
				return ("");

			if (date.StartsWith("/"))
				return ("");

			if (date.EndsWith("/"))
				return ("");

			intFirstIndex = date.IndexOf("/", 0);
			intYear = int.Parse(date.Substring(0, intFirstIndex));

			if (intYear == 0)
				return ("");

			intSecondIndex = date.IndexOf("/", intFirstIndex + 1);

			if (intSecondIndex == intFirstIndex + 1)
				return ("");

			intMonth = int.Parse(date.Substring(intFirstIndex + 1, intSecondIndex - intFirstIndex - 1));

			if ((intMonth < 1) || (intMonth > 12))
				return ("");

			intDay = int.Parse(date.Substring(intSecondIndex + 1, date.Length - intSecondIndex - 1));

			if ((intDay < 1) || (intDay > 31))
				return ("");

			if ((intMonth > 6) && (intDay > 30))
				return ("");

			if ((!CheckLeapYear(intYear)) && (intMonth == 12) && (intDay > 29))
				return ("");

			day = intDay;
			year = intYear;
			month = intMonth;

			string strResult = intYear.ToString().PadLeft(4, '0') + "/" + intMonth.ToString().PadLeft(2, '0') + "/" + intDay.ToString().PadLeft(2, '0');

			return (strResult);
		}
		#endregion /Internal Static Methods

		#region Public Static Methods
		/// <summary>
		/// Dariush Tasdighi - 1386/02/01 - Version: 3.0.0
		/// </summary>
		public static bool CheckLeapYear(int year)
		{
			if (year > 0)
				return (Dtx.Math.GetRemainder((Dtx.Math.Mod(year - 474, 2820) + 474 + 38) * 682, 2816) < 682);
			else
				return (Dtx.Math.GetRemainder((Dtx.Math.Mod(year - 473, 2820) + 474 + 38) * 682, 2816) < 682);
		}

		/// <summary>
		/// Dariush Tasdighi - 1386/02/01 - Version: 3.0.0
		/// </summary>
		public static int GetDayCount(int year, int month)
		{
			if (month <= 6)
				return (31);
			else
			{
				if (month <= 11)
					return (30);
				else
				{
					if (CheckLeapYear(year))
						return (30);
					else
						return (29);
				}
			}
		}

		/// <summary>
		/// Dariush Tasdighi - 1386/02/01 - Version: 3.0.0
		/// </summary>
		public static string GetDayOfWeekName(System.DayOfWeek index)
		{
			switch (index)
			{
				case System.DayOfWeek.Sunday:
				{
					return ("يکشنبه");
				}

				case System.DayOfWeek.Monday:
				{
					return ("دوشنبه");
				}

				case System.DayOfWeek.Tuesday:
				{
					return ("سه شنبه");
				}

				case System.DayOfWeek.Wednesday:
				{
					return ("چهارشنبه");
				}

				case System.DayOfWeek.Thursday:
				{
					return ("پنجشنبه");
				}

				case System.DayOfWeek.Friday:
				{
					return ("جمعه");
				}

				case System.DayOfWeek.Saturday:
				{
					return ("شنبه");
				}

				default:
				{
					return ("");
				}
			}
		}

		/// <summary>
		/// Dariush Tasdighi - 1386/04/24 - Version: 3.0.1
		/// </summary>
		public static string GetDayOfMonthName(int day)
		{
			string strResult = Dtx.Text.Convert.NumberToWord(day);

			if (strResult == "سی")
				strResult = strResult + " " + "ام";
			else
			{
				if (strResult.IndexOf("سه") >= 0)
					strResult = strResult.Replace("سه", "سوم");
				else
					strResult = strResult + "م";
			}

			return (strResult);
		}

		/// <summary>
		/// Dariush Tasdighi - 1386/02/01 - Version: 3.0.0
		/// </summary>
		public static string GetMonthName(int month)
		{
			switch (month)
			{
				case 1:
				{
					return ("فروردين");
				}

				case 2:
				{
					return ("ارديبهشت");
				}

				case 3:
				{
					return ("خرداد");
				}

				case 4:
				{
					return ("تير");
				}

				case 5:
				{
					return ("مرداد");
				}

				case 6:
				{
					return ("شهريور");
				}

				case 7:
				{
					return ("مهر");
				}

				case 8:
				{
					return ("آبان");
				}

				case 9:
				{
					return ("آذر");
				}

				case 10:
				{
					return ("دی");
				}

				case 11:
				{
					return ("بهمن");
				}

				case 12:
				{
					return ("اسفند");
				}

				default:
				{
					return ("");
				}
			}
		}
		#endregion /Public Static Methods

		#region Constructor
		/// <summary>
		/// Dariush Tasdighi - 1386/02/01 - Version: 3.0.0
		/// </summary>
		public PersianDate(int year, int month, int day)
		{
			Day = day;
			Year = year;
			Month = month;
		}
		#endregion /Constructor
	}
}
