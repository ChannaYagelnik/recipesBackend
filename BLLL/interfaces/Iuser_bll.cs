using DAL.models;
using Dto.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLL.interfaces
{
    public interface Iuser_bll
{
        List<user_dto> GetAll();
       bool add(user_dto user);
        user_dto MYGetUser(string id,string mail); 

    }
}
