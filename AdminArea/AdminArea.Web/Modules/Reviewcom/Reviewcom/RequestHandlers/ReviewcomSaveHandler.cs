using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminArea.Reviewcom.ReviewcomRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminArea.Reviewcom.ReviewcomRow;

namespace AdminArea.Reviewcom;

public interface IReviewcomSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ReviewcomSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IReviewcomSaveHandler
{
    public ReviewcomSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}