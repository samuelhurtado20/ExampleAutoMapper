using System;
using System.ComponentModel;

namespace ExampleAutoMapper.Models
{
	public class ClientDto
	{
		public Guid Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Alias { get; set; }

		[DisplayName("Address City")]
		public string AddressCity { get; set; }

		[DisplayName("Address Street")]
		public string AddressStreet { get; set; }

		[DisplayName("Address Number")]
		public string AddressNumber { get; set; }
	}
}
