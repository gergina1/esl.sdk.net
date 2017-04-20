using System;
using NUnit.Framework;
using Silanis.ESL.SDK;

namespace SDK.Examples
{
    [TestFixture()]
    public class ExternalSigningAuthExampleTest
    {
        [Test()]
        public void VerifyResult()
        {
            ExternalSigningAuthExample example = new ExternalSigningAuthExample();
            example.Run();

            DocumentPackage documentPackage = example.RetrievedPackage;
            Assert.IsNull(documentPackage.GetSigner(example.email1).ExternalSigningAuth);

            Signer signer = documentPackage.GetSigner(example.email2);
            Assert.IsNotNull(signer.ExternalSigningAuth);
            Assert.AreEqual(signer.ExternalSigningAuth.ProviderKey, ExternalSigningAuthExample.PROVIDER_KEY);
            Assert.AreEqual(signer.ExternalSigningAuth.IdentityInfo, ExternalSigningAuthExample.IDENTITY_INFO);
        }
    }
}
