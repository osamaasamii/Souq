using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminArea.ProductImagescom.ProductImagescomRow;

namespace AdminArea.ProductImagescom;

public interface IProductImagescomDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ProductImagescomDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProductImagescomDeleteHandler
{
    public ProductImagescomDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}