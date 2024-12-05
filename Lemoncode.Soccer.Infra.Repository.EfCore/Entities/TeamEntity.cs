using System.Collections.Generic;

namespace Lemoncode.Soccer.Infra.Repository.EfCore.Entities
{
    public class TeamEntity
    {
        public int Id { get; set; }
        public required string Code { get; set; }

        // Navigation properties
        public List<GoalEntity> Goals { get; set; } = new();
    }
}