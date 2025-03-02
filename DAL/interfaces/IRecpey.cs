using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IRecpey
    {
        List<Recepy> GetAll();
        bool add(Recepy l);
        bool myremove(Recepy l);
        bool myupdate(Recepy l);


    }
}
