using Newtonsoft.Json;
using System.Web.UI;


namespace FinalWeekProjectAPI
{
    
    public class BooksLatestDTO
    {
        public Rootobject Book { get; set; }

        public void DeserializeBooks(string getBook)
        {
            Book = JsonConvert.DeserializeObject<Rootobject>(getBook);
        }
    }
}
