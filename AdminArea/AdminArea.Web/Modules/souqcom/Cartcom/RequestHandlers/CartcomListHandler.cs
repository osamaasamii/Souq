using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminArea.souqcom.CartcomRow>;
using MyRow = AdminArea.souqcom.CartcomRow;

namespace AdminArea.souqcom;

public interface ICartcomListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class CartcomListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICartcomListHandler
{
    public CartcomListHandler(IRequestContext context)
            : base(context)
    {
    }
}