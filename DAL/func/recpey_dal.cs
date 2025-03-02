using DAL.interfaces;
using DAL.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.func
{
    public class recpey_dal : IRecpey
    {
        Recepis_chaniWContext _Recepis_chaniWContext;
        public recpey_dal(Recepis_chaniWContext r)
        {
            _Recepis_chaniWContext = r;
        }

        public bool add(Recepy l)
        {
            try
            {
                _Recepis_chaniWContext.Recepies.Add(l);
                _Recepis_chaniWContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Recepy> GetAll()
        {
           return _Recepis_chaniWContext.Recepies.Include(x=>x.CodeuserNavigation).ToList();
        }

        public bool myremove(Recepy l)
        {
            try
            {
                _Recepis_chaniWContext.Recepies.Remove(l);  
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool myupdate(Recepy l)
        {
            try
            {
                _Recepis_chaniWContext.Recepies.Update(l);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
