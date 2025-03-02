using DAL.models;
using Dto.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLL.interfaces
{
    public interface Irecepie_bll
{
        List<recepiy_dto> GetAll();
       int add(recepiy_dto l);
        List<recepiy_dto> Get(int id);
    }
}
