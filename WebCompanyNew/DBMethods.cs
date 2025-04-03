using System.Data;
using WebCompanyNew.Models;

namespace WebCompanyNew
{
	public class DBMethods
	{
		ClassAdo classAdo = new ClassAdo();
		string sqlPersonal = "select top 5 * from personal, pos where pos.idPos = personal.idPos";
		string sqlEvent = "select * from event";

		public List<Personal> GetPersonals()
		{
			string[] months = new string[] { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября",
				"октября", "ноября", "декабля" };

			List<Models.Personal> personalList = new List<Personal>();
			DataSet ds = classAdo.GetDataSet(sqlPersonal);
			for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
				Personal personal = new Personal();
				personal.idPersonal = int.Parse(ds.Tables[0].Rows[i]["idPersonal"].ToString());
				personal.idPos = int.Parse(ds.Tables[0].Rows[i]["idPos"].ToString());
				personal.person = ds.Tables[0].Rows[i]["person"].ToString();
				personal.workEmail = ds.Tables[0].Rows[i]["workEmail"].ToString();
				personal.birthday = DateTime.Parse(ds.Tables[0].Rows[i]["birthday"].ToString());
				personal.namePos = ds.Tables[0].Rows[i]["namePos"].ToString();
				personal.dateB = personal.birthday.Day + " " + months[personal.birthday.Month - 1];
				personalList.Add(personal);
			}
			return personalList;
		}

		public List<Event> GetEvents()
		{
			List<Event> events = new List<Event>();
			DataSet ds = classAdo.GetDataSet(sqlEvent);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
				Event event1 = new Event();
				event1.idEvent = int.Parse(ds.Tables[0].Rows[i]["idEvent"].ToString());
				event1.dateEvent = DateTime.Parse(ds.Tables[0].Rows[i]["dateEvent"].ToString());
				event1.author = ds.Tables[0].Rows[i]["authorEvent"].ToString();
				event1.textEvent = ds.Tables[0].Rows[i]["textEvent"].ToString();
				event1.nameEvent = ds.Tables[0].Rows[i]["nameEvent"].ToString();
				events.Add(event1);
			}
			return events;
        }

		public List<News> GetNews()
		{
			List<News> list = new List<News>();
            for (int i = 0; i < 3; i++)
            {
                News news = new News();
				news.titleNews = "Заголовок";
				news.titleNews = "Оооооооооооооооооочень длинный текст для новости";
				news.dateNews = DateTime.Now;
				list.Add(news);
            }
			return list;
        }
	}
}
