using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp.Data.Entity
{
    public class UsersEntity : EntityBase
    {
        public string UserId { get; set; }
        public string EmailId { get; set; }
        public int EmployeeID { get; set; }
        public bool Active { get; set; }
        public string Status { get; set; }
        public bool ResetPassword { get; set; }
    }
}
