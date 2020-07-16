using System;
using System.Linq;
using hms.Models;

namespace hms.BO
{
    public class UserMasterBO : BaseBO
    {
        private hmsDBContext hmsDBContext;
        public UserMasterBO(hmsDBContext hmsDBContext)
        {
            this.hmsDBContext = hmsDBContext;
        }

        public UserMaster CreateUpdate(UserMaster rec)
        {
            UserMaster UserMaster = null;
            try
            {
                if (rec.UserMasterAutoId > 0)
                {
                    UserMaster = hmsDBContext.Update(rec).Entity;
                }
                else
                {
                    rec.CreatedBy = 0;
                    rec.CreatedDate = DateTime.Now;
                    UserMaster = hmsDBContext.Add(rec).Entity;
                }
                hmsDBContext.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return UserMaster;
        }

        public UserMaster AddEdit(int AutoId)
        {
            UserMaster rec = new UserMaster();
            if (AutoId > 0)
            {
                try
                {
                    rec = hmsDBContext.UserMaster.FirstOrDefault(x => x.UserMasterAutoId == AutoId);
                }
                catch (Exception ex)
                {

                }
            }
            return rec;
        }
    }
}