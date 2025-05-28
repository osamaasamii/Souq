using MyRequest = AdminArea.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminArea.Administration.UserRow>;
using MyRow = AdminArea.Administration.UserRow;

namespace AdminArea.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}