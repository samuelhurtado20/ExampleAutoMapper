using AutoMapper;
using ExampleAutoMapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleAutoMapper.MapperProfiles
{
	public class ClientProfile : Profile
	{
		public ClientProfile()
		{
			CreateMap<Client, ClientDto>()
			.ForMember(t => t.Id, opt => opt.MapFrom(s => s.Guid))
			.ForMember(t=>t.FirstName, opt=> opt.MapFrom(s=>s.Name))
			.ForMember(t => t.Alias, opt => opt.MapFrom(s => s.NickName));
		}
	}
}
