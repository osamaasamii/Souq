using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminArea.Productcom.ProductcomRow>;
using MyRow = AdminArea.Productcom.ProductcomRow;

namespace AdminArea.Productcom;

public interface IProductcomRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ProductcomRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProductcomRetrieveHandler
{
    public ProductcomRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}