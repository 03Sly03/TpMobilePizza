﻿using System.ComponentModel.DataAnnotations;

namespace TpMobilePizza.Models
{
    public class MyPizza
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Le nom est requis")]
        public string Name { get; set; }
        [Required(ErrorMessage = "La liste des ingrédients est requise")]
        public List<Ingredient> Ingredients { get; set; }
        [Range(1, 99, ErrorMessage = "Le prix doit être compris entre 1€ et 99€")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Le lien vers l'image est requis")] 
        public string PicturePath { get; set; }
    }
}
