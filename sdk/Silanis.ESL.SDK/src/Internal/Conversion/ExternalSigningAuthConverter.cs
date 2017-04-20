using System;

using Silanis.ESL.SDK.Builder;

namespace Silanis.ESL.SDK
{
    internal class ExternalSigningAuthConverter
    {
        private Silanis.ESL.SDK.ExternalSigningAuth sdkExternalSigningAuth = null;
        private Silanis.ESL.API.ExternalSigningAuth apiExternalSigningAuth = null;

        public ExternalSigningAuthConverter(Silanis.ESL.API.ExternalSigningAuth apiExternalSigningAuth)
        {
            this.apiExternalSigningAuth = apiExternalSigningAuth;
        }

        public ExternalSigningAuthConverter(Silanis.ESL.SDK.ExternalSigningAuth sdkExternalSigningAuth)
        {
            this.sdkExternalSigningAuth = sdkExternalSigningAuth;
        }

        public Silanis.ESL.API.ExternalSigningAuth ToAPIExternalSigningAuth()
        {
            if (sdkExternalSigningAuth == null)
            {
                return apiExternalSigningAuth;
            }

            Silanis.ESL.API.ExternalSigningAuth result = new Silanis.ESL.API.ExternalSigningAuth();
            result.ProviderKey = sdkExternalSigningAuth.ProviderKey;
            result.IdentityInfo = sdkExternalSigningAuth.IdentityInfo;

            return result;
        }

        public Silanis.ESL.SDK.ExternalSigningAuth ToSDKExternalSigningAuth()
        {
            if (apiExternalSigningAuth == null)
            {
                return sdkExternalSigningAuth;
            }

            Silanis.ESL.SDK.ExternalSigningAuth result = ExternalSigningAuthBuilder.ForProvider(apiExternalSigningAuth.
                ProviderKey).WithIdentityInfo(apiExternalSigningAuth.IdentityInfo).Build();
            return result;
        }
    }
}
