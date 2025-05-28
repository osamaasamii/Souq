using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminArea.ProductImagescom.ProductImagescomRow>;
using MyRow = AdminArea.ProductImagescom.ProductImagescomRow;

namespace AdminArea.ProductImagescom;

public interface IProductImagescomRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ProductImagescomRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProductImagescomRetrieveHandler
{
    public ProductImagescomRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}