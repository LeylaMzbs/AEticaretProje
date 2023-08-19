using Ahlatci.Eticaret.Application.Models.Dtos;
using Ahlatci.Eticaret.Application.Models.Dtos.ProductImages;
using Ahlatci.Eticaret.Application.Models.RequestModels.ProductImages;
using Ahlatci.Eticaret.Application.Wrapper;

namespace Ahlatci.Eticaret.Application.Services.Abstraction
{
    public interface IProductImageService
    {
        #region Select

        Task<Result<List<ProductImageDto>>> GetAllImagesByProduct(GetAllProductImageByProductVM getByProductVM);
        Task<Result<List<ProductImageWithProductDto>>> GetAllProductImagesWithProduct(GetAllProductImageByProductVM getByProductVM);

        #endregion

        #region Insert, Update, Delete

        Task<Result<int>> CreateProductImage(CreateProductImageVM createProductImageVM);
        Task<Result<int>> DeleteProductImage(DeleteProductImageVM deleteProductImageVM);

        #endregion
    }
}
