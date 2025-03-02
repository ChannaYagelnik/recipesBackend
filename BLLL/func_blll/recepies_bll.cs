using AutoMapper;
using BLLL.interfaces;
using DAL.interfaces;
using DAL.models;
using Dto;
using Dto.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLL.func_blll
{
    public class recepies_bll: Irecepie_bll
    {
        static IMapper _Mapper;
        IRecpey _IRecpey;
       
        public recepies_bll(IRecpey iRecpey)
        {
            _IRecpey = iRecpey;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<myprofil>();
            });
            _Mapper = config.CreateMapper();
        }

        public int add(recepiy_dto l)
        {
            try
            {
                Recepy re = _Mapper.Map<recepiy_dto, Recepy>(l);
                _IRecpey.add(re);
                return re.Code;
            }
            catch
            {
               return -1;
            }
        }

        public List<recepiy_dto> Get(int id)
        {
           List<Recepy>l= _IRecpey.GetAll ();
            List<Recepy> lu=new List<Recepy>();

            for(int i = 0; i < l.Count; i++)
            {
                if (l[i].Code==id)
                    lu.Add (l[i]);
            }
            return _Mapper.Map<List<Recepy>, List<recepiy_dto>>(lu);



        }

        public List<recepiy_dto> GetAll()
        {
            List<Recepy> list = _IRecpey.GetAll();
            return _Mapper.Map<List<Recepy>, List<recepiy_dto>>(list);
        }
    }
}
