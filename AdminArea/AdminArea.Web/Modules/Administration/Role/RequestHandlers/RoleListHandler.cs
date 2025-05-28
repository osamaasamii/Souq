using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminArea.Administration.RoleRow>;
using MyRow = AdminArea.Administration.RoleRow;


namespace AdminArea.Administration;
public interface IRoleListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class RoleListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoleListHandler
{
    public RoleListHandler(IRequestContext context)
         : base(context)
    {
    }
}