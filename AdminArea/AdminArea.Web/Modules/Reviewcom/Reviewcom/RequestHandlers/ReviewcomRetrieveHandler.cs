using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminArea.Reviewcom.ReviewcomRow>;
using MyRow = AdminArea.Reviewcom.ReviewcomRow;

namespace AdminArea.Reviewcom;

public interface IReviewcomRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ReviewcomRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IReviewcomRetrieveHandler
{
    public ReviewcomRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}