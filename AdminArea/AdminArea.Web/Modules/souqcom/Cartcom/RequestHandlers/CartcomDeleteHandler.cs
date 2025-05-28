using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminArea.souqcom.CartcomRow;

namespace AdminArea.souqcom;

public interface ICartcomDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class CartcomDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICartcomDeleteHandler
{
    public CartcomDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}