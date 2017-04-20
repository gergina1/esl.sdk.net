
using Newtonsoft.Json;

namespace Silanis.ESL.API
{
    internal class ExternalSigningAuth
	{
		// Accessors	    
        [JsonProperty("providerKey")]
        public string ProviderKey
        {
            get;set;
        }

        [JsonProperty("identityInfo")]
        public string IdentityInfo
        {
            get; set;
        }
	}
}
