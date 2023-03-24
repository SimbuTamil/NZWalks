namespace NZWalks.Api.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public Guid RegionId { get; set; }
        public Guid Walkdifficultyid { get; set; }
        public Region Region { get; set; }
        public Walkdifficulty walkdifficulty { get; set; }
    }
}
