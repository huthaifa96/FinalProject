using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWeekProjectAPI
{

    public class Rootobject
    {
        public Book[] books { get; set; }
        
    }

    public class Book
    {
        public string isbn { get; set; }
        public string title { get; set; }
        public string subTitle { get; set; }
        public string author { get; set; }
        public DateTime publish_date { get; set; }
        public string publisher { get; set; }
        public int pages { get; set; }
        public string description { get; set; }
        public string website { get; set; }
    }

}
