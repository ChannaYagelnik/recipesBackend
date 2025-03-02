using DAL.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.models;
using Dto.repository;

namespace BLLL.interfaces
{
    public interface Iingredientcrecepie_bll
{
         List<recepiyingridentc_dto> GetAll();
        int add(recepiyingridentc_dto l);

        List<recepiyingridentc_dto> Gety_by_idRecipy(int id);
        bool AddAllIngridiens(int id, List<recepiyingridentc_dto> lingrid);


    }
}
