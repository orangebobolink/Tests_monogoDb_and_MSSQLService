﻿using ApplicationCore.Domain.Core.Models.Roles;

namespace ApplicationCore.Domain.Core.Models.Cinema.Films
{
	public class Review : EntityBase
	{
		RegisteredUser RegisteredUser { get; set; }
		public string Dicriprion { get; set; }

		public Review(RegisteredUser registeredUser, string dicriprion)
		{
			RegisteredUser = registeredUser;
			Dicriprion = dicriprion;
		}
	}
}