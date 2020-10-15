using NUnit.Framework;
using System.Linq;

namespace FinalWeekProjectAPI
{
    
    public class APITests
    {
        private Service _Service = new Service();
                
        [Test]
        public void ResultsReturn()
        {
            _Service.GetResults();
            Assert.That(_Service.BooksLatestDTO.Book.Books[0].title, Is.EqualTo("Git Pocket Guide"));
            Assert.That(_Service.BooksLatestDTO.Book.Books[0].author, Is.EqualTo("Richard E. Silverman"));
            Assert.That(_Service.BooksLatestDTO.Book.Books[0].publisher, Is.EqualTo("O'Reilly Media"));
            Assert.That(_Service.BooksLatestDTO.Book.Books[0].pages, Is.EqualTo(234));
        }

        //[Test]
        //public void AddingABook()
        //{
        //    string[] names = { "isbn", "title", "subTitle", "author", "publish_date", "publisher", "pages", "description", "website"};
        //    string[] value = { "123", "LOTR", "test", "test", "2020-06-04T08:48:39.000Z", "test", "1", "test", "test"};
        //    _Service.CallManager.AddBook(names, value);
        //    _Service.GetResults();
        //    Assert.That(_Service.BooksLatestDTO.Book.Books.ToString(), Is.EqualTo("LOTR"));
        //}


    }
}
