using System;
using System.Linq;
using hms.Models;
using Microsoft.EntityFrameworkCore;

namespace hms.BO
{
    public class AccountBO
    {
        private hmsDBContext Context;

        public AccountBO(hmsDBContext hmsDBContext)
        {
            this.Context = hmsDBContext;
        }

        public UserMaster ValidateUser(UserMaster user)
        {
            UserMaster rec = null;
            try
            {
                rec = Context.UserMaster
                        .FromSqlRaw("ValidateUserSP {0},{1},{2}",user.UserName,user.Password,user.HmsTenantAutoId)
                        .AsEnumerable().FirstOrDefault();
            }
            catch (Exception ex)
            {

            }
            return rec;
        }

    }
}