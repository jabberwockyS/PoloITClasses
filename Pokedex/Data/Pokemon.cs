﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data.Models
{
    public class Pokemon
    {

        public string Name { get; set; }
          
        public string Trainer { get; set; }

        public Pokemon(string name, string trainer) {
            this.Name = name;
            this.Trainer = trainer;            
        }



      
    }
}
