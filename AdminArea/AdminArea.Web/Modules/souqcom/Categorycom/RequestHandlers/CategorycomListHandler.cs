using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminArea.souqcom.CategorycomRow>;
using MyRow = AdminArea.souqcom.CategorycomRow;

namespace AdminArea.souqcom;

public interface ICategorycomListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class CategorycomListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategorycomListHandler
{
    public CategorycomListHandler(IRequestContext context)
            : base(context)
    {
    }
}