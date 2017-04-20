using System;
using Silanis.ESL.SDK.Internal;

namespace Silanis.ESL.SDK.Builder
{
    public class ExternalSigningAuthBuilder
	{
        private string providerKey;
        private string identityInfo;

        private ExternalSigningAuthBuilder(string providerKey) {
            this.providerKey = providerKey;
        }

        public static ExternalSigningAuthBuilder ForProvider(string providerKey) {
            return new ExternalSigningAuthBuilder(providerKey);
        }

        public ExternalSigningAuthBuilder WithIdentityInfo(string identityInfo)
        {
            this.identityInfo = identityInfo;
            return this;
        }

        public ExternalSigningAuth Build()
		{
            Asserts.NotEmptyOrNull (providerKey, "providerKey");
            ExternalSigningAuth result = new ExternalSigningAuth (providerKey);
            result.IdentityInfo = identityInfo;
			return result;
		}
	}
}
