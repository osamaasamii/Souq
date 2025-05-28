using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminArea.ProductImagescom.ProductImagescomRow>;
using MyRow = AdminArea.ProductImagescom.ProductImagescomRow;

namespace AdminArea.ProductImagescom;

public interface IProductImagescomListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ProductImagescomListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProductImagescomListHandler
{
    public ProductImagescomListHandler(IRequestContext context)
            : base(context)
    {
    }
}