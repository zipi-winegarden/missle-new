using Api.Serivce;
using ApiModel;

namespace ApiSerivce
{
    public class MissileService
    {
        readonly Data missileService;
    
        public MissileService(Data _missileService)
        {
            missileService = _missileService;
        }
        public IEnumerable<Missile> GetData()
        {
            return missileService.missileList;
        }
        
        public  bool add(Missile missile)
        {
            Missile m= missileService.missileList.Find(x=>x.Patriotmissile.Equals(missile.Patriotmissile));
            if (m != null)
                return false;
            //if (missile.)
            //{
               missileService.missileList.Add(missile);
            //}
                
            return true;
        }
        public IEnumerable<Missile> GetbyPlace(string c)
        {
            return missileService.missileList.Where(t => t.Location.city == c).ToList();
        }
        public IEnumerable<string> GetPlace()
        {
            //string s="";
            //foreach (var item in DB.missileList)
            //{
            //    s += item.Location.City.ToString() + ",";
            //}
            return missileService.missileList.Select(t => t.Location.city).ToList();
        }

    }
}
