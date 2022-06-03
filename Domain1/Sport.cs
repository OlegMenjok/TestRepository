using System.Collections.Immutable;


namespace TestProjectCommon1.Domain1
{
    public class Sport
    {
        public int Id { get; private set; }
        private ImmutableDictionary<string, string>?Names;

        public Sport(int id, ImmutableDictionary<string, string>? names)
        {
            Id = id;
            Names = names?.ToImmutableDictionary() ?? ImmutableDictionary<string, string>.Empty;
        }

    }
}
