namespace Models.ComplexTypes
{
	[System.ComponentModel.DataAnnotations.Schema.ComplexType]
	public class CustomDateTime : object
	{
		public CustomDateTime()
			: base()
		{
		}

		// **********
		private System.DateTime? _value;

		public System.DateTime? Value
		{
			get
			{
				return (_value);
			}
			set
			{
				_value = value;

				if (_value == null)
				{
					Day = null;
					Year = null;
					Month = null;
				}
				else
				{
					int intCulture =
						System.Threading.Thread.CurrentThread.CurrentCulture.LCID;

					switch (intCulture)
					{
						case 1065:
						{
							Dtx.Calendar.PersianDate oPersianDate =
								Dtx.Calendar.Convert.CivilToPersion(_value.Value);

							Day = oPersianDate.Day;
							Year = oPersianDate.Year;
							Month = oPersianDate.Month;

							break;
						}

						default:
						{
							Day = _value.Value.Day;
							Year = _value.Value.Year;
							Month = _value.Value.Month;

							break;
						}
					}
				}
			}
		}
		// **********

		// **********
		public string DisplayDate
		{
			get
			{
				if (Value.HasValue == false)
				{
					return ("-----");
				}
				else
				{
					int intCulture =
						System.Threading.Thread.CurrentThread.CurrentCulture.LCID;

					switch (intCulture)
					{
						case 1065:
						{
							Dtx.Calendar.PersianDate oPersianDate =
								Dtx.Calendar.Convert.CivilToPersion(Value.Value);

							return (oPersianDate.Value1);
						}

						default:
						{
							return (Value.Value.ToString("yyyy/MM/dd"));
						}
					}
				}
			}
		}
		// **********

		// **********
		public string DisplayTime
		{
			get
			{
				if (Value.HasValue == false)
				{
					return ("-----");
				}
				else
				{
					int intCulture =
						System.Threading.Thread.CurrentThread.CurrentCulture.LCID;

					switch (intCulture)
					{
						case 1065:
						{
							string strSecond =
								Dtx.Text.Convert.DigitsToUnicode(Value.Value.Second.ToString().PadLeft(2, '0'));

							string strMinute =
								Dtx.Text.Convert.DigitsToUnicode(Value.Value.Minute.ToString().PadLeft(2, '0'));

							string strHour =
								Dtx.Text.Convert.DigitsToUnicode(Value.Value.Hour.ToString().PadLeft(2, '0'));

							string strResult =
								string.Format("[{0}:{1}:{2}]", strHour, strMinute, strSecond);

							return (strResult);
						}

						default:
						{
							return (Value.Value.ToString("HH:mm:ss"));
						}
					}
				}
			}
		}
		// **********

		// **********
		public string DisplayDateTime
		{
			get
			{
				return (DisplayDate + " " + DisplayTime);
			}
		}
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.Day)]

		[System.ComponentModel.DataAnnotations.Schema.NotMapped]
		public virtual int? Day { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.Month)]

		[System.ComponentModel.DataAnnotations.Schema.NotMapped]
		public virtual int? Month { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.Year)]

		[System.ComponentModel.DataAnnotations.Schema.NotMapped]
		public virtual int? Year { get; set; }
		// **********
	}
}
