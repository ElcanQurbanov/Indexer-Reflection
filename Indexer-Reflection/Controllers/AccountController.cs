using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection.Controllers
{
    public class AccountController
    {
        private readonly IAccountService _service;

        public AccountController()
        {
            _service = new AccountService();
        }

        public void Register()
        {
            Console.WriteLine("Add your username:");

            string username = Console.ReadLine();

            Console.WriteLine("Add your email:");

            string email = Console.ReadLine();

            Console.WriteLine("Add your password:");

            string password = Console.ReadLine();

            var result = _service.Register(username, email, password);

            Console.WriteLine(result);
        }

    }
}
