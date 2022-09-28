using Library105;
using System.Linq;

namespace TestBookCatalog
{
    [TestClass]
    public class UnitTest1
    {
        private BookCatalog _catalog;


        public void TestSetup()
        {
            Book b1 = new Book("AD1337", "C# for All", "John Potter", 352);
            Book b2 = new Book("XS3220", "Gardening", "Alex Sohn", 220);
            Book b3 = new Book("DD0095", "Cars in the USA", "Susan Dreyer", 528);
            Book b4 = new Book("PT1295", "The World Narrators", "Dan Mygind", 256);

            _catalog = new BookCatalog();
            _catalog.AddBook(b1);
            _catalog.AddBook(b2);
            _catalog.AddBook(b3);
            _catalog.AddBook(b4);
        }

        [TestMethod]
        public void TestAddBook()
        {
            // Arrange
            TestSetup();
            Book newBook = new Book("AA0001", "Agile Samurai", "Bitch boy 13", 2);
            int expected = _catalog.GetBooks().Count + 1;


            // Act
            _catalog.AddBook(newBook);
            int actual = _catalog.GetBooks().Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLookupBook_ExistingBook()
        {
            // Arrange
            TestSetup();


            // Act
            string isnLookUp = "AD1337";
            Book expected = _catalog.GetBooks()[0];
            Book actual = _catalog.LookUpBook(isnLookUp);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLookupBook_NonExistingBook_Case1NotNullNonExistingItem()
        {
            // Arrange
            TestSetup();


            // Act
            string isnLookUp = "Hejsa";


            // Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _catalog.LookUpBook(isnLookUp));

        }

        [TestMethod]
        public void TestLookupBook_NonExistingBook_Case2Null()
        {
            // Arrange
            TestSetup();

            // Act
            string isnLookUp = null;

            // Assert
            Assert.ThrowsException<ArgumentNullException>(() => _catalog.LookUpBook(isnLookUp));

        }

        [TestMethod]
        public void TestLookupBook_NonExistingBook_Case3Empty()
        {
            // Arrange
            TestSetup();

            // Act
            string isnLookUp = "";

            // Assert
            Assert.ThrowsException<ArgumentNullException>(() => _catalog.LookUpBook(isnLookUp));
        }

        [TestMethod]
        public void TestDeleteBook_ExistingBook()
        {
            // Arrange
            TestSetup();
            string isnLookUp = "AD1337";
            int expected = _catalog.GetBooks().Count - 1;

            // Act
            _catalog.DeleteBook(isnLookUp);
            int actual = _catalog.GetBooks().Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeleteBook_NotExistingBook()
        {
            // Arrange
            TestSetup();

            // Act
            string isnLookUp = "Hejsa";

            // Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _catalog.DeleteBook(isnLookUp));

        }
    }
}