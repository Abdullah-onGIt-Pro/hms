using System;
using System.Linq;
using hms.Models;

namespace hms.BO
{
    public class AccountBO
    {
        private hmsDBContext Context;

        public AccountBO(hmsDBContext hmsDBContext)
        {
            this.Context = Context;
        }

        public UserMaster ValidateUser(UserMaster user)
        {
            UserMaster rec = null;
            try
            {
                rec = Context.UserMaster.FirstOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);
            }
            catch (Exception ex)
            {

            }
            return rec;
        }

    }
}