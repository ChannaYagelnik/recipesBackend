using BLLL.interfaces;
using DAL.interfaces;

using Dto.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Recepy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class recepiyController : ControllerBase
   {
        Irecepie_bll _Irecepie_bll;
        IRecpey _IRecpey;


        public recepiyController(Irecepie_bll r)
       {
            _Irecepie_bll = r;
        }
        [HttpGet("getall")]
        public ActionResult<List<recepiy_dto>> GetAll()
        {
            return Ok(_Irecepie_bll.GetAll());
        }
        [HttpPost("myadd")]
        public ActionResult<int> funcadd(recepiy_dto ik)
        {
            return Ok(_Irecepie_bll.add(ik));
        }
        //[HttpDelete("mydell")]
        //public ActionResult<bool> del(Recepy r)
        //{
        //    return Ok(_IRecpey.myremove(r));
        //}
        [HttpGet("GET/{id}")]
        public ActionResult<recepiy_dto>funcget(int id)
        {
            return Ok(_Irecepie_bll.Get(id));
        }

    }
}
