using Newtonsoft.Json;

namespace NpmForever
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Author
    {
        public string name { get; set; }
        public string email { get; set; }
    }

    public class Bin
    {
        public string forever { get; set; }
    }

    public class Bugs
    {
        public string url { get; set; }
    }

    public class Dependencies
    {
        public string async { get; set; }
        public string cliff { get; set; }
        public string clone { get; set; }
        public string colors { get; set; }
        public string configstore { get; set; }
        public string eventemitter2 { get; set; }
        public string flatiron { get; set; }

        [JsonProperty("forever-monitor")]
        public string forevermonitor { get; set; }
        public string mkdirp { get; set; }
        public string nssocket { get; set; }

        [JsonProperty("object-assign")]
        public string objectassign { get; set; }
        public string prettyjson { get; set; }
        public string shush { get; set; }
        public string winston { get; set; }
    }

    public class DevDependencies
    {
        public string chai { get; set; }

        [JsonProperty("cli-testlab")]
        public string clitestlab { get; set; }
        public string eslint { get; set; }

        [JsonProperty("eslint-config-prettier")]
        public string eslintconfigprettier { get; set; }

        [JsonProperty("eslint-plugin-prettier")]
        public string eslintpluginprettier { get; set; }
        public string getopts { get; set; }
        public string mocha { get; set; }
        public string moment { get; set; }
        public string prettier { get; set; }
        public string request { get; set; }
        public string vows { get; set; }
    }

    public class Directories
    {
    }

    public class Dist
    {
        public string integrity { get; set; }
        public string shasum { get; set; }
        public string tarball { get; set; }
        public int fileCount { get; set; }
        public int unpackedSize { get; set; }

        [JsonProperty("npm-signature")]
        public string npmsignature { get; set; }
        public List<Signature> signatures { get; set; }
    }

    public class Engines
    {
        public string node { get; set; }
    }

    public class Maintainer
    {
        public string name { get; set; }
        public string email { get; set; }
    }

    public class NpmOperationalInternal
    {
        public string host { get; set; }
        public string tmp { get; set; }
    }

    public class NpmUser
    {
        public string name { get; set; }
        public string email { get; set; }
    }

    public class Repository
    {
        public string type { get; set; }
        public string url { get; set; }
    }

    public class NpmInfo
    {
        public string name { get; set; }
        public string preferGlobal { get; set; }
        public string description { get; set; }
        public string version { get; set; }
        public Author author { get; set; }
        public List<Maintainer> maintainers { get; set; }
        public Repository repository { get; set; }
        public List<string> keywords { get; set; }
        public Dependencies dependencies { get; set; }
        public DevDependencies devDependencies { get; set; }
        public Bin bin { get; set; }
        public string main { get; set; }
        public Scripts scripts { get; set; }
        public Engines engines { get; set; }
        public string license { get; set; }
        public string gitHead { get; set; }
        public Bugs bugs { get; set; }
        public string homepage { get; set; }
        public string _id { get; set; }
        public string _nodeVersion { get; set; }
        public string _npmVersion { get; set; }
        public Dist dist { get; set; }
        public NpmUser _npmUser { get; set; }
        public Directories directories { get; set; }
        public NpmOperationalInternal _npmOperationalInternal { get; set; }
        public bool _hasShrinkwrap { get; set; }
    }

    public class Scripts
    {
        public string lint { get; set; }
        public string test { get; set; }

        [JsonProperty("test:mocha")]
        public string testmocha { get; set; }

        [JsonProperty("test:vows")]
        public string testvows { get; set; }

        [JsonProperty("test:ci")]
        public string testci { get; set; }
        public string prettier { get; set; }
    }

    public class Signature
    {
        public string keyid { get; set; }
        public string sig { get; set; }
    }


}
