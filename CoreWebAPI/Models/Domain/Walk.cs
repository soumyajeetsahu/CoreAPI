using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Length { get; set; }
        public string Name { get; set; }

        public Guid RegionId { get; set; }
        public Guid WalkDifficultyId { get; set; }

        public Region region { get; set; }
        public WalkDifficulty walkDifficulty { get; set; }
    }
}
