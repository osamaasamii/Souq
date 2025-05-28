using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminArea.Productcom.ProductcomRow;

namespace AdminArea.Productcom;

public interface IProductcomDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ProductcomDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProductcomDeleteHandler
{
    public ProductcomDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}