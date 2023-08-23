using System.ComponentModel.DataAnnotations;

namespace Ahlatci.Eticaret.UI.Models.RequestModels
{
    public class CreateCategoryVM
    {
        [Display(Name = "Kategori adı")]
        public string CategoryName { get; set; }
    }
}
