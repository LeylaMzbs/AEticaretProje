using System.ComponentModel.DataAnnotations;

namespace Ahlatci.Eticaret.UI.Models.Dtos.ProductImages
{
    public class ProductImageDto
    {
        
        public int Id { get; set; }
        [Display(Name ="Ürün no")]
        public int ProductId { get; set; }

        [Display(Name ="Resim")]
        public string Path { get; set; }
        [Display(Name ="Sıra no")]
        public int Order { get; set; }

        [Display(Name ="Durumu")]
        public bool? IsThumbnail { get; set; }
    }
}
