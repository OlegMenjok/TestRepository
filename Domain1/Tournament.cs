using System.Collections.Immutable;

namespace TestProjectCommon1.Domain1
{
    public class Tournament
    {
        public int Id { get; private set; }

        public int SportId { get; private set; }
        public int CategoryId { get; private set; }

        private  ImmutableDictionary<string, string> Names;

        bool _isActive;
        public Tournament(int id, int sportId, int categoryId, ImmutableDictionary<string, string>? names, bool isActive)
        {
            Id = id;
            SportId = sportId;
            CategoryId = categoryId;
            Names = names?.ToImmutableDictionary() ?? ImmutableDictionary<string, string>.Empty;
            _isActive = isActive;
        }
    }
    
}
