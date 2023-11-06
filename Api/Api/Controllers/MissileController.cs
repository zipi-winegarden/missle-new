
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using System.Reflection;
using Api;
using ApiSerivce;
using ApiModel;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MissileController : ControllerBase
    {
        readonly MissileService missileList;
        public MissileController(MissileService _missileList)
        {
            missileList = _missileList;
        }

        [HttpGet]
        public IEnumerable<Missile> GetMissile()
        {
           return missileList.GetData();
        }
        
        [HttpPost]
        public bool post([FromBody] Missile missile)
        {   
            return missileList.add(missile);
        }

        [HttpGet]
        [Route("GetByPlace")]
        public IEnumerable<Missile> GetbyPlace(string c)
        {
            return missileList.GetbyPlace(c);
        }

        [HttpGet]
        [Route("GetPlace")]
        public IEnumerable<string> GetPlace()
        {
            return missileList.GetPlace();
        }
    }
}
