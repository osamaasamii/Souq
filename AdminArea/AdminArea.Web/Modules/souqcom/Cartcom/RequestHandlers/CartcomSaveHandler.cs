using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminArea.souqcom.CartcomRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminArea.souqcom.CartcomRow;

namespace AdminArea.souqcom;

public interface ICartcomSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class CartcomSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICartcomSaveHandler
{
    public CartcomSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}