﻿using System;

namespace Exercicio12
{
     class Students
    {

        public string Name { get; set; }
        public string Email { get; set; }

        public Students(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
