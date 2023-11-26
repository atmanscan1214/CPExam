using Moq;
using api.Models;
using api.Repositories;

namespace Api_test
{
    [TestClass]
    public class ClientRepositoryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Setup Mock Data
            Client[] clients = new Client[]
            {
                new Client{Id="1", FirstName="Juan", LastName="Dela Cruz",Email="juandelacruz@gmail.com",PhoneNumber="123456789"},
                new Client{Id="2",FirstName="Juana", LastName="Change", Email="juana_change@yahoo.com",PhoneNumber="2222222"},
                new Client{Id="3",FirstName="Alberto", LastName="San Jose", Email="asj@outlook.ph",PhoneNumber="333333"}
            };

            Mock<IClientRepository> mockClientRepository = new Mock<IClientRepository>();

            //Return all client
            var _clients = mockClientRepository.Setup(mcr => mcr.Get());//.Returns((Task<Client[]>)clients);

            // Get all client using a search criteria

            string searchString = "Juan";
            var _filteredClient = mockClientRepository.Setup(mcr => mcr.SearchClient(searchString));
            
           
            // Get specific client
            searchString = "Dela Cruz";
            var specificClient = mockClientRepository.Setup(mcr => mcr.SearchClient(searchString));

            Mock<IEmailRepository> mockEmailRepo = new Mock<IEmailRepository>();

            //Create new client
            Client client = new Client();
            client.Id = "4";
            client.FirstName = "Artheine Sean";
            client.LastName = "San Juan";
            client.Email = "test.test@test.com";
            client.PhoneNumber = "88888888";

            var newClient = mockClientRepository.Setup(mcr => mcr.Create(client));

            //update existing client

            client.Id = "2";
            client.FirstName = "Juana";
            client.LastName = "ChangeNow";
            client.Email = "juana_changenow@yahoo.com";
            client.PhoneNumber = "2222222";

            var clietUpdate = mockClientRepository.Setup(mcr => mcr.Update(client));


        }
    }
}