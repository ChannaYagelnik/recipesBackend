using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.interfaces
{
    public interface IUser
    {
        List<User> GetAll();
        int add(User l);
        bool myremove(User l);
        bool myupdate(User l);


    }
}
