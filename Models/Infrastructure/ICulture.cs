namespace Models.Infrastructure
{
	public interface ICulture
	{
		int CultureLcid { get; set; }

		System.Guid CultureId { get; set; }

	}
}
