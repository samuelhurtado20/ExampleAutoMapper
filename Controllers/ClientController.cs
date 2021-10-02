using ExampleAutoMapper.Models;
using ExampleAutoMapper.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleAutoMapper.Controllers
{
	public class ClientController : Controller
	{
		private IClientRepository _clientRepository;
		public ClientController(IClientRepository clientRepository)
		{
			_clientRepository = clientRepository;
		}

		public IActionResult Index()
		{
			ClientDto client = _clientRepository.GetClient();
			return View(client);
		}
	}
}
