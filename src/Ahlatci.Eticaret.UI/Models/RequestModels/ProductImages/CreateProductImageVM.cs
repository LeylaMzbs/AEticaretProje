using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Ahlatci.Eticaret.UI.Models.RequestModels.ProductImages
{
    public class CreateProductImageVM
    {
        
        public int? ProductId { get; set; }
        [Display(Name ="Sıra no")]
        public int? Order { get; set; } = 0;

        [Display(Name ="Varsayılan resim")]
        public bool? IsThumbnail { get; set; }

        [Display(Name ="Resim Dosyası")]
        public IFormFile ImageFile { get; set; }
        public string UploadedImage { get; set; }
        public string ContentType { get; internal set; }
    }
}


