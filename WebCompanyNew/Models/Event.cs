namespace WebCompanyNew.Models
{
	public class Event
	{
		public int idEvent { get; set; }
		public string nameEvent { get; set; }
		public DateTime dateEvent { get; set; }
		public string author { get; set; }
		public string textEvent { get; set; }
		public int idPersonal { get; set; }
	}
}
