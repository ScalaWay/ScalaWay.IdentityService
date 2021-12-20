namespace IdentityService.Application.Contracts.Authorization
{
    public static class ServicePermissions
    {
        public const string ServiceName = "IdentityService";

        public static class Accounts
        {
            public const string All = $"{ServiceName}.Workspaces.All";
            public const string Read = $"{ServiceName}.Workspaces.Read";
            public const string Create = $"{ServiceName}.Workspaces.Create";
            public const string Update = $"{ServiceName}.Workspaces.Update";
            public const string Delete = $"{ServiceName}.Workspaces.Delete";
        }

        public static class Roles
        {
            public const string All = $"{ServiceName}.Compartments.All";
        }
    }
}
