using System.Collections.Immutable; 
namespace TestProjectCommon1.Domain1
{
    public enum TeamType
    {
        Team = 0,
        Player = 1,
        Pair = 2
    }
    public class Team
    {
        public int Id { get; private set; }

        public int SportId { get; private set; }
        public TeamType TeamType { get; private set; }

        private ImmutableDictionary<string, string> Names;

        private List<string> PlayerIds = new List<string>();

        bool IsActive;
        public Team(int id, int sportId, TeamType teamType, ImmutableDictionary<string, string>? names, DateTime startTime, List<string> playerIds, bool isActive)
        {
            Id = id;
            SportId = sportId;
            TeamType = teamType;
            Names = names?.ToImmutableDictionary() ?? ImmutableDictionary<string, string>.Empty;
            PlayerIds = playerIds;
            IsActive = isActive;


        }

    }
}
