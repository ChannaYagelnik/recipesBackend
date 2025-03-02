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
    public class ingredientce_bll : Iingredientc_bll
    {
        //IMapper שם שמור 
        //גם בהצהרה משנים לDTO
        //static IMapper _Mapper;
        static IMapper _Mapper;
        Iingriduentce _Iingriduentce;
        public ingredientce_bll(Iingriduentce r)
        {
            _Iingriduentce=r;                                                                        
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<myprofil>();
            });
            _Mapper = config.CreateMapper();

        }

        public int add(ingridentce_dto i)
        {
            try
            {
                Ingriduentce j= _Mapper.Map<ingridentce_dto, Ingriduentce>(i);
                _Iingriduentce.add(j);


                return i.CodeIngrid;
            }
            catch
            {
                return -1;
            }
        }

        public List<ingridentce_dto> GetAll()
        {
            List<Ingriduentce> list = _Iingriduentce.GetAll();
            return _Mapper.Map<List<Ingriduentce>, List<ingridentce_dto>>(list);
        }

        
    }
}
