﻿using ApplicationCore.Domain.Core.Interfaces;
using ApplicationCore.Services.Interfaces.Validations;
using System.Text.RegularExpressions;

namespace ApplicationCore.Services.Implementations.Validations
{
	public class AutorizationValidation : IAuthorizationValidation
	{
		/// <summary>
		/// The regular expression below cheks that a password:
		/// Has minimum 8 characters in length. Adjust it by modifying {8,}
		///	At least one uppercase English letter. You can remove this condition by removing (?=.*?[A-Z])
		/// At least one lowercase English letter.  You can remove this condition by removing (?=.*?[a-z])
		/// At least one digit. You can remove this condition by removing (?=.*?[0-9])
		/// At least one special character,  You can remove this condition by removing (?=.*?[#?!@$%^&*-]).
		/// </summary>
		/// <param name="password">verification password.</param>
		/// <returns>Is verefication.</returns>
		public bool PasswordIsValidate(string password)
		{
			var regex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");

			return regex.IsMatch(password);
		}

		public bool UsernameIsNotUse(string username, List<IAuthorization> authorizations)
			=> !authorizations.Any(user => user.Username == username);

		/// <summary>
		/// I use the following regular expression to validate a username.
		/// [a-zA-Z] => first character must be a letter
		/// [a-zA-Z0-9] => it can contain letter and number
		/// {5,11} => the length is between 6 to 12
		/// </summary>
		/// <param name="username">Verification password.</param>
		/// <returns>Is verefication.</returns>
		public bool UsernameIsValidate(string username)
		{
			var regex = new Regex("(?=.{8,24}$)(?=[^0-9]*[0-9])(?=[^A-Z]*[A-Z])[a-z0-9][a-zA-Z0-9]*[._-][a-zA-Z0-9]*[a-z0-9]$");

			return regex.IsMatch(username);
		}
	}
}
