using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CourtManagement
{
    public static class GlobalVariables
    {
        public static SystemUser System_User {  get; set; }
    }

    public class SystemUser
    {
        public int UserId { get; set; }
        public int UserRole { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClinetLastName { get; set; }
    }
}
