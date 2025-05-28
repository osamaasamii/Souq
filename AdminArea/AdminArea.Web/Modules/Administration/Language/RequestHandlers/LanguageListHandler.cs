using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminArea.Administration.LanguageRow>;
using MyRow = AdminArea.Administration.LanguageRow;


namespace AdminArea.Administration;
public interface ILanguageListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class LanguageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageListHandler
{
    public LanguageListHandler(IRequestContext context)
         : base(context)
    {
    }
}