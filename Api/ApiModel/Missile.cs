

namespace ApiModel
{
    public class Missile
    {
        public int Patriotmissile { get; set; }//שם טיל
    
        public Location Location { get; set; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return $"id: {Patriotmissile}" + base.ToString();
        }

    }
}
