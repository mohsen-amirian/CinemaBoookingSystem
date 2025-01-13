using CinemaBoookingSystem.Data;
using System.ComponentModel;

namespace CinemaBoookingSystem.Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        private Guid testCustomerId;
        private Customer testCustomer;
        private Screening testScreening;
        private Seat testSeat;

        [SetUp]
        public void SetUp()
        {
            testCustomer = Database.Customers.First();
            testCustomerId = testCustomer.Id;
            testScreening = Database.Screenings.First();
            testSeat = new Seat { Id = Guid.NewGuid(), Number = 1 };
        }

        [Test]
        public void TestCreateCustomer_Success()
        {
            var result = Database.CreateCustomer("Jane", "Doe", 1990, "jane.doe@example.com");
            var createdCustomer = Database.Customers.First(c => c.Name == "Jane");

            Assert.IsNotNull(createdCustomer);
            Assert.IsTrue(result);
        }


        [Test]
        public void TestUpdateCustomer_Success()
        {
            var result = Database.UpdateCustomer(testCustomerId, "John", "Smith", 1985, "john.smith@example.com");

            var updatedCustomer = Database.Customers.Single(c => c.Id == testCustomerId);
            Assert.IsTrue(result);
            Assert.That(updatedCustomer.Name, Is.EqualTo("John"));
            Assert.That(updatedCustomer.Email, Is.EqualTo("john.smith@example.com"));
        }

        [Test]
        public void TestDeleteCustomer_Success()
        {
            var result = Database.DeleteCustomer(testCustomerId);
            var empty = Database.Customers.Where(c => c.Id == testCustomerId).ToList();

            Assert.That(empty.Count, Is.Zero);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestBookSeat_Success()
        {
            var result = Database.Book(testCustomer, testScreening, testSeat);

            // Assert
            Assert.IsTrue(result);
            Assert.That(Database.Bookings.Count, Is.GreaterThan(0));  // One booking should be added
            
            var booking = Database.Bookings.FirstOrDefault(
                c => c.Customer.Id == testCustomerId
            && c.Screening.Id == testScreening.Id &&
            c.Seat.Id == testSeat.Id);
            
            Assert.NotNull(booking);
        }


        [Test]
        public void TestSerialize_Success()
        {
            string tempFile = "customers-test1.xml";
            Database.SerializeList(Database.Customers, tempFile);

            var fileExists = File.Exists(tempFile);

            Assert.IsTrue(fileExists);

            if (fileExists) File.Delete(tempFile);
        }

        [Test]
        public void TestDeserialize_Success()
        {
            string tempFile = "customers-test2.xml";
            Database.SerializeList(Database.Customers, tempFile);

            var deserializedCustomers = Database.Deserialize<BindingList<Customer>>(tempFile);

            Assert.That(deserializedCustomers.Count, Is.EqualTo(Database.Customers.Count));

            if (File.Exists(tempFile)) File.Delete(tempFile);
        }

        [Test]
        public void TestGenerateDataIfEmpty_CustomersGenerated()
        {
            Database.Customers.Clear();

            Database.GenerateDataIfEmpty();

            Assert.That(Database.Customers.Count, Is.Not.EqualTo(0));
        }
    }
}