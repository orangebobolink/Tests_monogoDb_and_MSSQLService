﻿namespace ApplicationCore.Domain.Core.Models.Cinema.Films
{
	public class Distributor : EntityBase
	{
		public string NameCompany { get; set; }

		public Distributor(string nameCompany)
		{
			NameCompany = nameCompany;
		}
	}
}