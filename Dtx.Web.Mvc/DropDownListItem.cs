namespace Dtx.Web.Mvc
{
	public class DropDownListItem : object
	{
		public DropDownListItem()
			: base()
		{
		}

		public DropDownListItem(object id, object name)
		{
			if (id == null)
			{
				Id = string.Empty;
			}
			else
			{
				Id = id.ToString().Trim();
			}

			if (name == null)
			{
				Name = string.Empty;
			}
			else
			{
				Name = name.ToString().Trim();
			}
		}

		public string Id { get; set; }

		public string Name { get; set; }
	}
}
