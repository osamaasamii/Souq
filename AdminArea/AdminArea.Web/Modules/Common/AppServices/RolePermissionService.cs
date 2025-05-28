using AdminArea.Administration;

namespace AdminArea.AppServices;
public class RolePermissionService(ITwoLevelCache cache, ISqlConnections sqlConnections, ITypeSource typeSource)
    : BaseRolePermissionService<RolePermissionRow>(cache, sqlConnections, typeSource)
{
}