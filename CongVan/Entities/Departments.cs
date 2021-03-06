﻿using Kids.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace CongVan.Entities
{
    [Table("kid_Departments")]
    public class Departments : Entity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
    }
}