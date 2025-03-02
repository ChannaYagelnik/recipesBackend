using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IngrientRecepies
    {
        List<IngridentcRecpey> GetAll();
        int add(IngridentcRecpey l);
        bool myremove(IngridentcRecpey l);
        bool myupdate(IngridentcRecpey l);

        //List<string> Gety_by_idRecipy(string id);

    }
}
