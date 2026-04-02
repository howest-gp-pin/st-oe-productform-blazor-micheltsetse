using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Pin.Products.Core.Services.Models
{
    public class CreateOrUpdateProductModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("title")]
        [Required(ErrorMessage = "Please provide a Title!")]
        public string Title { get; set; }

        [JsonPropertyName("price")]
        [Required(ErrorMessage = "Please provide a price between 1 and 1000!")]
        [Range(1,1000)]
        public int Price { get; set; }

        [JsonPropertyName("description")]
        [Required(ErrorMessage = "Please provide a Description!")]
        public string Description { get; set; }

        [JsonPropertyName("categoryId")]
        public int CategoryId { get; set; }

        [JsonPropertyName("images")]
        public List<string> Images { get; set; }
    }
}
