using NUnit.Framework;
using System.Linq;

namespace FinalWeekProjectAPI
{
    
    public class UnitTest1
    {
        private Service _Service = new Service();

        [Test]
        public void CheckStatusIs200()
        {
            Assert.That(_Service.BooksLatestDTO.Books.success);
        }

    }
}
