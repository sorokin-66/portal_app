﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace diga.web.ViewModels
{
    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
