﻿using Kabutar.Attributes;
using Kabutar.Domain.Entities;
using Kabutar.Service.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Kabutar.Service.Dtos
{
    public class UserUpdateDto
    {
        [Required, Name]
        public string Firstname { get; set; } = string.Empty;

        [Required, Name]
        public string Lastname { get; set; } = string.Empty;

        [Required, UsernameCheck]
        public string Username { get; set; } = string.Empty;

        [Required, PhoneNumber]
        public string PhoneNumber { get; set; } = string.Empty;

        public static implicit operator User(UserUpdateDto userUpdate)
        {
            return new User()
            {
                FirstName = userUpdate.Firstname,
                LastName = userUpdate.Lastname,
                Username = userUpdate.Username,
                PhoneNumber = userUpdate.PhoneNumber,
            };
        }
    }


}
