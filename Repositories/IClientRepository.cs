using ExampleAutoMapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleAutoMapper.Repositories
{
	public interface IClientRepository
	{
		ClientDto GetClient();
	}
}
