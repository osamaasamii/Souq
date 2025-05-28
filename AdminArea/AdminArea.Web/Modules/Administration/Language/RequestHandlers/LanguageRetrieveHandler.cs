using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminArea.Administration.LanguageRow>;
using MyRow = AdminArea.Administration.LanguageRow;


namespace AdminArea.Administration;
public interface ILanguageRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageRetrieveHandler
{
    public LanguageRetrieveHandler(IRequestContext context)
         : base(context)
    {
    }
}