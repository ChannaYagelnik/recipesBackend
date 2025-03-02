
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
    public class user_bll : Iuser_bll
    {
        IUser _IUser;
        static IMapper _Mapper;
        public user_bll(IUser iUser)
        {
            _IUser = iUser;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<myprofil>();
            });
            _Mapper = config.CreateMapper();
        }

        public List<user_dto> GetAll()
        {
            List<User> list= _IUser.GetAll();
            return _Mapper.Map<List<User>, List<user_dto>>(list);
        }

        public bool add(user_dto user)
        {
            try
            {
               
                _IUser.add(_Mapper.Map<user_dto, User>(user));
                return true;
            }
            catch
            {
            return false;
            }
        }

        public user_dto MYGetUser(String password, string mail)
        {
            User u=new User();
            List<User> list= _IUser.GetAll();
            for(int i = 0; i < list.Count; i++)
            {
                if ((list[i].PassWord.ToString() == password) && list[i].Mail== mail)
                {
                    u=list[i];
                    
                    return _Mapper.Map<User,user_dto>(u);
                   
                }
            }

            return null;
        }
    }
}
