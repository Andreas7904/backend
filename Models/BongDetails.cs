using System;
using System.Text.Json.Serialization;

namespace BackendProject.Models
{
    public class BongDetails
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public int IngredientId { get; set; }
        [JsonIgnore]
        public Ingredient Ingredient { get; set; }
        [JsonIgnore]
        public Product Product { get; set; }

    }
}