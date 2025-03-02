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
    public class ingredientcrecepiy_bll : Iingredientcrecepie_bll
    {
        static IMapper _Mapper;
        IngrientRecepies _IngrientRecepies;
        //dal
        Iingriduentce _Iingriduentce;
        public ingredientcrecepiy_bll(IngrientRecepies ingrientRecepies, Iingriduentce _Iingriduentce)
        {
            _IngrientRecepies = ingrientRecepies;
            this._Iingriduentce= _Iingriduentce;    
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<myprofil>();
            });
            _Mapper = config.CreateMapper();
        }

        public int add(recepiyingridentc_dto l)
        {
            try
            {
                IngridentcRecpey i = _Mapper.Map<recepiyingridentc_dto, IngridentcRecpey>(l);
                _IngrientRecepies.add(i);
                return i.CodeIingridRecpie;


            }
            catch
            {
                return -1;
            }
        }

         
            public bool AddAllIngridiens(int id,List<recepiyingridentc_dto> lingrid)
        {
            try { 
          
            for(int i = 0; i < lingrid.Count; i++)
            {
                if (lingrid[i].CodeIngrid==0)
                {
                    Ingriduentce inj = new Ingriduentce() { NameIngrid = lingrid[i].NameIngrid };
                    
                    int codRechivnew=_Iingriduentce.add(inj);
                        lingrid[i].CodeIngrid = codRechivnew;
                       

                }
                    IngridentcRecpey ir = _Mapper.Map<recepiyingridentc_dto,IngridentcRecpey>(lingrid[i]);
                    _IngrientRecepies.add(ir);
            }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public List<recepiyingridentc_dto> GetAll()
        {
            List<IngridentcRecpey> list = _IngrientRecepies.GetAll();
            return _Mapper.Map<List<IngridentcRecpey>, List<recepiyingridentc_dto>>(list);
        }

        public List<recepiyingridentc_dto> Gety_by_idRecipy(int id)
        {
            List<IngridentcRecpey> ll = _IngrientRecepies.GetAll().Where(k => k.Coderecpiey == id).ToList();
            return _Mapper.Map<List<IngridentcRecpey>, List<recepiyingridentc_dto>>(ll);


        }

        
    }
}