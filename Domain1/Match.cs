using System.Collections.Immutable;

namespace TestProjectCommon1.Domain1
{
    public class Match
    {
        public int Id { get; private set; }

        public int SportId { get; private set; }
        public int TournamentId { get; private set; }
        public MatchType MatchType { get; private set; }

        private ImmutableDictionary<string, string>? Names;

        public DateTime StartTime;

        private List<string> TeamIds;

        public Match(int id, int sportId, int tournamentId, MatchType matchType, ImmutableDictionary<string, string>? names,DateTime startTime, List<string>teamIds)   
        {

            Id = id;
            SportId = sportId;
            TournamentId = tournamentId;
            Names = names?.ToImmutableDictionary() ?? ImmutableDictionary<string, string>.Empty;
            StartTime = startTime;
            TeamIds = teamIds;
        }
    }
}
