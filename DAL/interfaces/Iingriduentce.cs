using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface Iingriduentce
    {
        List<Ingriduentce> GetAll();
        int add(Ingriduentce l);
        bool myremove(Ingriduentce l);
        bool myupdate(Ingriduentce l);
       
    }
}
