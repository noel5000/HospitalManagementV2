
namespace PointOfSalesV2.Repository
{
    public interface ILanguageKeyRepository : IBase<LanguageKey>
    {
        public Task<Result<object>> UploadI18nDictionaries(string path, ServerDirectoryType serverDirectoryType= ServerDirectoryType.Folder);
    }
}
