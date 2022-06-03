using System.Collections.Immutable; 


namespace TestProjectCommon1.Domain1
{
    public class Category
    {

        public int Id { get; private set; }

        public int SportId { get; private set; }

        private  ImmutableDictionary<string, string> Names; 
        public Category(int id, int sportId, ImmutableDictionary<string, string>?names)
        {
            Id = id;
            SportId = sportId;
            Names = names?.ToImmutableDictionary() ?? ImmutableDictionary<string, string>.Empty;
        }


    }
}
