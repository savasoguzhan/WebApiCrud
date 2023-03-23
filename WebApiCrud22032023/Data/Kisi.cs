﻿using System.ComponentModel.DataAnnotations;

namespace WebApiCrud22032023.Data
{
    public class Kisi
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Ad { get; set; } = null!;
    }
}
