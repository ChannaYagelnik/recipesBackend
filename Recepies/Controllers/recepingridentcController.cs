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
    public class recepingridentcController : ControllerBase
    { 
        Iingredientcrecepie_bll _Iingredientcrecepie_bll;
        IngrientRecepies _IngrientRecepies;
        public recepingridentcController(Iingredientcrecepie_bll iingredientcrecepie_bll)
        {
            _Iingredientcrecepie_bll = iingredientcrecepie_bll;
        }

            [HttpGet("mygetall")]
        public ActionResult<List<recepiyingridentc_dto>> getall()
        {
            return Ok(_Iingredientcrecepie_bll.GetAll());
        }
        [HttpPost("myadd")]
        public ActionResult<int> funcadd(recepiyingridentc_dto ik)
        {
            return Ok(_Iingredientcrecepie_bll.add(ik));
        }
        [HttpDelete("mydell")]

        public ActionResult<bool> funcdel(IngridentcRecpey i)
        {
            return Ok(_IngrientRecepies.myremove(i));
        }
        [HttpGet("idRecipy_by_Get/{id}")]
        public ActionResult<List<recepiyingridentc_dto>> idRecipy_by_Get(int id)
        {

            return Ok(_Iingredientcrecepie_bll.Gety_by_idRecipy(id));
        }
        [HttpPost("addRechivim/{id}")]
        public ActionResult<bool> addRechivim(int id, List<recepiyingridentc_dto> lr)
        {
            return Ok(_Iingredientcrecepie_bll.AddAllIngridiens(id,lr));
        }
    }
}
