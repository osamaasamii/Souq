using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminArea.Productcom.ProductcomRow>;
using MyRow = AdminArea.Productcom.ProductcomRow;

namespace AdminArea.Productcom;

public interface IProductcomListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ProductcomListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProductcomListHandler
{
    public ProductcomListHandler(IRequestContext context)
            : base(context)
    {
    }
}