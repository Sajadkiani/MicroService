using System.ComponentModel.DataAnnotations;

namespace ProductService.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}