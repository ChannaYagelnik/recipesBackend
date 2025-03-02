using DAL.interfaces;
using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.func
{
    public class ingredients_dal: Iingriduentce
    {
        Recepis_chaniWContext _Recepis_chaniWContext;
        public ingredients_dal(Recepis_chaniWContext recepis_chaniWContext)
        {
            _Recepis_chaniWContext = recepis_chaniWContext;
        }

        public int add(Ingriduentce l)
        {
            try
            {
                _Recepis_chaniWContext.Ingriduentces.Add(l);
                _Recepis_chaniWContext.SaveChanges();
                return l.CodeIngrid;   


            }
            catch
            {
                return 0;

            }
        }

        public List<Ingriduentce> GetAll()
        {
            //שם הטבלה
            return _Recepis_chaniWContext.Ingriduentces.ToList();
            


        }

        public bool myremove(Ingriduentce l)
        {
            try
            {
                _Recepis_chaniWContext.Ingriduentces.Remove(l);
                
                return true;
            }
            catch
            {
               return false;
            }
        }

        

        public bool myupdate(Ingriduentce l)
        {
            try
            {
                _Recepis_chaniWContext.Ingriduentces.Update(l);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
