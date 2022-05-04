﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppInventarioWeb.Models
{
    public class Entity
    {
        public bool Activo { get; set; } 
        public DateTime FechaAlta { get; set; } 
        public DateTime? FechaMod { get; set; }
    }
}