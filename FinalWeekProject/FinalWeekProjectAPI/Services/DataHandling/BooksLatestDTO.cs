using Newtonsoft.Json;
using System.Web.UI;


namespace FinalWeekProjectAPI
{
    //this class is the model of the data returned by the API call
    public class BooksLatestDTO
    {
        public Rootobject Books { get; set; }

        public void DeserializeBooks(string getBook)
        {
            Books = JsonConvert.DeserializeObject<Rootobject>(getBook);
        }
    }
}
