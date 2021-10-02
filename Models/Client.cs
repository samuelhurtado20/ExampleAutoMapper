using System;

namespace ExampleAutoMapper.Models
{
	public class Client
	{
		public Guid Guid { get; set; }
		public string Name { get; set; }
		public string LastName{ get; set; }
		public string NickName { get; set; }
		public Address Address{ get; set; }
	}
}
