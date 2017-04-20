
namespace Silanis.ESL.SDK
{
    public class ExternalSigningAuth
	{
        public ExternalSigningAuth(string providerKey)
        {
            ProviderKey = providerKey;
        }

        public string ProviderKey
        {
            get;set;
        }

        public string IdentityInfo
		{
			get;set;
		}
	}
}
