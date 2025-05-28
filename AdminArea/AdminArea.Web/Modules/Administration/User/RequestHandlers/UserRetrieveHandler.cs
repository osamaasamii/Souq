using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminArea.Administration.UserRow>;
using MyRow = AdminArea.Administration.UserRow;


namespace AdminArea.Administration;
public interface IUserRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
public class UserRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IUserRetrieveHandler
{
    public UserRetrieveHandler(IRequestContext context)
         : base(context)
    {
    }
}