using Newtonsoft.Json;
using System.Web.UI;


namespace FinalWeekProjectAPI
{
    //this class is the model of the data returned by the API call
    public class BooksLatestDTO
    {
        public Rootobject Book { get; set; }

        public void DeserializeBooks(string getBook)
        {
            Book = JsonConvert.DeserializeObject<Rootobject>(getBook);
        }
    }
}
