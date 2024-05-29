﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aisapp
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Surname { get; set; }
        public string? Patronymic { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public List<Cart> Carts { get; set; }
    }
}
