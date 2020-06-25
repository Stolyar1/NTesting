using System;
using System.Collections.Generic;

namespace DAL.Context.dbContext
{
    public partial class RolePermissions
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
    }
}
