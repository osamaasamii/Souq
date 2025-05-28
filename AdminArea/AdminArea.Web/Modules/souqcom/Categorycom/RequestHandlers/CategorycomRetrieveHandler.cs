using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminArea.souqcom.CategorycomRow>;
using MyRow = AdminArea.souqcom.CategorycomRow;

namespace AdminArea.souqcom;

public interface ICategorycomRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class CategorycomRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICategorycomRetrieveHandler
{
    public CategorycomRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}