using DAL.interfaces;
using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.func
{
    public class usr_dal: IUser
    {
        Recepis_chaniWContext _Recepis_chaniWContext;
        public usr_dal(Recepis_chaniWContext r)
        {
            _Recepis_chaniWContext = r;
        }

        public int add(User l)
        {
            try
            {
                _Recepis_chaniWContext.Users.Add(l);
                _Recepis_chaniWContext.SaveChanges();
                return l.Codeusr;
            }
            catch
            {
                return 0;   
            }
        }

        public List<User> GetAll()
        {
            return _Recepis_chaniWContext.Users.ToList();
        }

        public bool myremove(User l)
        {
            try
            {
                _Recepis_chaniWContext.Users.Remove(l);
                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool myupdate(User l)
        {
            try
            {
                _Recepis_chaniWContext.Users.Update(l);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
