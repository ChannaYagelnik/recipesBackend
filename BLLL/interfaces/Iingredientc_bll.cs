using DAL.models;
using Dto.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLL.interfaces
{
    public interface Iingredientc_bll
{
        List<ingridentce_dto> GetAll();
     int add(ingridentce_dto i);  

    }
}
