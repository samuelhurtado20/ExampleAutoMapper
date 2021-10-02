using AutoMapper;
using ExampleAutoMapper.Models;
using ExampleAutoMapper.Services;

namespace ExampleAutoMapper.Repositories
{
	public class ClientRepository : IClientRepository
	{
		private IClientService _clientService;
		private IMapper _map;

		public ClientRepository(IClientService clientService, IMapper map)
		{
			_clientService = clientService;
			_map = map;
		}

		public ClientDto GetClient()
		{
			var client = _clientService.GetClient();

			return _map.Map<ClientDto>(client);
		}
	}
}
