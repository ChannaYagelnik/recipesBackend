
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
    public class recpeyingredients_dal: IngrientRecepies
    {
        Recepis_chaniWContext _Recepis_chaniWContext;

        public recpeyingredients_dal(Recepis_chaniWContext r)
        {
            _Recepis_chaniWContext = r;
        }

        public int add(IngridentcRecpey l)
        {
            try
            {
               
                _Recepis_chaniWContext.IngridentcRecpeys.Add(l);
                _Recepis_chaniWContext.SaveChanges();
                return l.CodeIingridRecpie;


            }
            catch
            {
                return 0;

            }
        }

        public List<IngridentcRecpey> GetAll()
        {
            //Include(k => k.CodeIngrdiensNavigation).ToList()
            return _Recepis_chaniWContext.IngridentcRecpeys.Include(k => k.CodeIngr).ToList();
        }
        public bool myremove(IngridentcRecpey l)
        {
            try
            {
                _Recepis_chaniWContext.IngridentcRecpeys.Remove(l);
                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool myupdate(IngridentcRecpey l)
        {
            try
            {
                _Recepis_chaniWContext.IngridentcRecpeys.Update(l);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
