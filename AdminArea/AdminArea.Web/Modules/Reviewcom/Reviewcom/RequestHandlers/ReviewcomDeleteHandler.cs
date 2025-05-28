using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminArea.Reviewcom.ReviewcomRow;

namespace AdminArea.Reviewcom;

public interface IReviewcomDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ReviewcomDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IReviewcomDeleteHandler
{
    public ReviewcomDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}