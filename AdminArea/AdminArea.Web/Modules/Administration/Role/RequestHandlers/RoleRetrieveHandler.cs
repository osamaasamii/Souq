using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminArea.Administration.RoleRow>;
using MyRow = AdminArea.Administration.RoleRow;


namespace AdminArea.Administration;
public interface IRoleRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
public class RoleRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleRetrieveHandler
{
    public RoleRetrieveHandler(IRequestContext context)
         : base(context)
    {
    }
}