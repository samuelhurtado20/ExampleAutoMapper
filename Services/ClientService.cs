using ExampleAutoMapper.Models;
using System;

namespace ExampleAutoMapper.Services
{
	public class ClientService : IClientService
	{
		public Client GetClient()
		{
			return new Client
			{
				Guid = Guid.NewGuid(),
				LastName = @"Hurtado",
				Name = @"Samuel",
				NickName = @"samuelhurtado20",
				Address = new Address {
					City = @"Quito",
					Number = 32,
					Street = @"Rumipamba"
				}
			};
		}
	}
}
