using System;
using System.IO;
using Silanis.ESL.SDK;
using Silanis.ESL.SDK.Builder;

namespace SDK.Examples
{
    public class ExternalSigningAuthExample : SDKSample
    {
        public static void Main(string[] args)
        {
            new ExternalSigningAuthExample().Run();
        }

        public static string PROVIDER_KEY = "DIGIPASS";
        public static string IDENTITY_INFO = "Xz3AwPp9xazJ0ku5CZnlmgAx2DlJJGw0k0kd8SHkAeT";

        override public void Execute()
        {
            DocumentPackage package = PackageBuilder.NewPackageNamed(PackageName)
                .WithSigner(SignerBuilder.NewSignerWithEmail(email1)
                    .WithFirstName("John1")
                    .WithLastName("Smith1"))
                .WithSigner(SignerBuilder.NewSignerWithEmail(email2)
                    .WithFirstName("John2")
                    .WithLastName("Smith2")
                    .WithExternalSigningAuth(ExternalSigningAuthBuilder.ForProvider(PROVIDER_KEY)
                        .WithIdentityInfo(IDENTITY_INFO)))
                .WithDocument(DocumentBuilder.NewDocumentNamed("Custom Consent Document")
                    .FromStream(fileStream1, DocumentType.PDF)
                    .WithSignature(SignatureBuilder.SignatureFor(email2)
                        .OnPage(0)
                        .AtPosition(100, 100)))
                .Build();

            packageId = eslClient.CreatePackage(package); 
            retrievedPackage = eslClient.GetPackage(packageId);
        }
    }
}

