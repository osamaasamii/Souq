using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminArea.souqcom.CategorycomRow;

namespace AdminArea.souqcom;

public interface ICategorycomDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class CategorycomDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICategorycomDeleteHandler
{
    public CategorycomDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}