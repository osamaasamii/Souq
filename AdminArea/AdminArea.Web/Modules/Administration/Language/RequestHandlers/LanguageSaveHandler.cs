using MyRequest = Serenity.Services.SaveRequest<AdminArea.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminArea.Administration.LanguageRow;


namespace AdminArea.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}