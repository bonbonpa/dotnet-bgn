﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspMvcAuthv0.Models
{
 

    /// <summary>
    /// used
    /// </summary>
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
