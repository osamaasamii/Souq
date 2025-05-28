using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminArea.ProductImagescom.ProductImagescomRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminArea.ProductImagescom.ProductImagescomRow;

namespace AdminArea.ProductImagescom;

public interface IProductImagescomSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ProductImagescomSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProductImagescomSaveHandler
{
    public ProductImagescomSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}