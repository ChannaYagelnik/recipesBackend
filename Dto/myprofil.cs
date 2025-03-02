
using AutoMapper;
using DAL.models;
using Dto.repository;


namespace Dto
{
    //Profile מילה שמורה 
    public class myprofil:Profile//מילה שמורה
    {
     public myprofil()
        {
            //לשתי הכיוונים אני כותבת כל אחד פעמיים בצורה הפוכה
            //קשרי גומלין
            CreateMap<IngridentcRecpey, recepiyingridentc_dto>().ForMember(k=>k.NameIngrid,l=>l.MapFrom(i=>i.CodeIngr.NameIngrid));
            CreateMap<recepiyingridentc_dto, IngridentcRecpey>();
            //לעשות לכל המחלקות
            CreateMap<Ingriduentce, ingridentce_dto>();
            CreateMap<ingridentce_dto, Ingriduentce>();

            CreateMap<Recepy, recepiy_dto>().ForMember(k => k.FirstName, l => l.MapFrom(i => i.CodeuserNavigation.FirstName)).ForMember(k => k.LastName, l => l.MapFrom(i => i.CodeuserNavigation.LastName)).ForMember(k => k.Mail, l => l.MapFrom(i => i.CodeuserNavigation.Mail)).ForMember(k => k.PassWord, l => l.MapFrom(i => i.CodeuserNavigation.PassWord));
            CreateMap<recepiy_dto, Recepy>();

            CreateMap<User, user_dto>();
            CreateMap<user_dto, User>();
        }
    }
}
