﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DTO
{
    public class RegistrationResponse
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
    }
}
