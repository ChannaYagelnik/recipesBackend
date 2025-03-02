using BLLL.interfaces;
using DAL.interfaces;
using DAL.models;
using Dto.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Recepy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ingridentceController : ControllerBase
    {
        Iingredientc_bll _Iingredientc_bll;
        Iingriduentce _Iingriduentce;
        public ingridentceController(Iingredientc_bll iingredientc_bll)
        {
            _Iingredientc_bll = iingredientc_bll;
        }   

        [HttpGet("mygetall")]
        public ActionResult<List<ingridentce_dto>> getall()
        {
            return Ok(_Iingredientc_bll.GetAll());
        }
        [HttpPost("myadd")]
        public ActionResult<int> funcadd(ingridentce_dto ik)
        {
            return Ok(_Iingredientc_bll.add(ik));
        }
        [HttpDelete("mydelete")]
        public ActionResult<bool> funcdel(Ingriduentce i)
        {
            return Ok(_Iingriduentce.myremove(i));
        }


    }
}

