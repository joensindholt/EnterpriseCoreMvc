using System.ComponentModel.DataAnnotations;

namespace EnterpriseCoreMvc.Core.Products
{
    public class Product
    {
        /// <summary>
        /// Empty constructor only for EF
        /// </summary>
        public Product()
        {            
        }

        public Product(string title)
        {
            Title = title;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; private set; }
    }
}