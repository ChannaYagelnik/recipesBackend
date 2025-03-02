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
    public class userController : ControllerBase
    {
        Iuser_bll _Iuser_bll;
        IUser _IUser;
        public userController(Iuser_bll iuser_bll)
        {
            _Iuser_bll = iuser_bll;
        }

        [HttpGet("mygetall")]
        public ActionResult<List<user_dto>> getall()
        {
            return Ok(_Iuser_bll.GetAll());
        }
        [HttpPost("myadd")]
        public ActionResult<bool> funcadd(user_dto ik)
        {
            return Ok(_Iuser_bll.add(ik));
        }
        [HttpDelete("mydell")]
        public ActionResult<bool> del(User r)
        {
            return Ok(_IUser.myremove(r));
        }
        [HttpGet("mygetid/{id}/{mail}")]
        public ActionResult<List<user_dto>> mygetid(string id,string mail)
        {
            return Ok(_Iuser_bll.MYGetUser(id,mail));
        }

    }
}
