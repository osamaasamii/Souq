using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminArea.Productcom.ProductcomRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminArea.Productcom.ProductcomRow;

namespace AdminArea.Productcom;

public interface IProductcomSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ProductcomSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProductcomSaveHandler
{
    public ProductcomSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}