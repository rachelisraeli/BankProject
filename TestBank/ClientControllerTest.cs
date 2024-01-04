using Bank.Controllers;
using Bank.Entities;
using Microsoft.AspNetCore.Mvc;
using Solid.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBank
{
    public class ClientControllerTest
    {
        private readonly IDataContext _fakeContext;

        private readonly ClientController _clientController;

        public ClientControllerTest(IDataContext fakeContext)
        {  
            _fakeContext = fakeContext;
            _clientController = new ClientController(fakeContext);
        }

        [Fact]
        public void GetAll_ReturnsListOfClients()
        {
            var result = _clientController.Get();

            Assert.IsType<List<Client>>(result);
        }

        [Fact]
        public void GetByID_ReturnsOk()
        {
            var id = 1;

            var result = _clientController.Get(id);

            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetByID_ReturnsNotFound()
        {
            var id = 4;

            var result = _clientController.Get(id);

            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void GetByName_ReturnsOk()
        {
            var name = "Aharon";

            var result = _clientController.GetByName(name);

            Assert.IsType<OkObjectResult>(result);
        }

    }
}
