using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AspTask_3.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Desciption { get; set; }

        public double Price { get; set; }
        public double Discount { get; set; }
    }
}
