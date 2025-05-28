using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminArea.Reviewcom.ReviewcomRow>;
using MyRow = AdminArea.Reviewcom.ReviewcomRow;

namespace AdminArea.Reviewcom;

public interface IReviewcomListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ReviewcomListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IReviewcomListHandler
{
    public ReviewcomListHandler(IRequestContext context)
            : base(context)
    {
    }
}