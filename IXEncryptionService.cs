namespace XTemplateV2.SourceCode.DependencyServices
{
    public interface IXEncryptionService
    {
        string Encrypt(string plainValue);
        string Decrypt(string encryptedValue);
    }
}
