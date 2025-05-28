using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminArea.souqcom.CartcomRow>;
using MyRow = AdminArea.souqcom.CartcomRow;

namespace AdminArea.souqcom;

public interface ICartcomRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class CartcomRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICartcomRetrieveHandler
{
    public CartcomRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}