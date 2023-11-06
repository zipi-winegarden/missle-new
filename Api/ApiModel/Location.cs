namespace ApiModel
{
    public class Location
    {
        public string city { get; set; }
     //   public DateTime date { get; set; }
     //   public DateTime endDate { get; set; }
        public string location { get; set; }

        public override string? ToString()
        {
            return $"city: {city} "
                 +$"location:{location}";
            //+$"dateS:{date}"
            //+ $"dateE:{endDate}"
        }
    }
}