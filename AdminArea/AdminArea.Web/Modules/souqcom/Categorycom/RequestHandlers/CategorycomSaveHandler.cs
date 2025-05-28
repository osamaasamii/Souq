using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminArea.souqcom.CategorycomRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminArea.souqcom.CategorycomRow;

namespace AdminArea.souqcom;

public interface ICategorycomSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class CategorycomSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategorycomSaveHandler
{
    public CategorycomSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}