using System.Threading.Tasks;

namespace AElf.Boilerplate.Initializr.Core
{
    public interface ITemplateService
    {
        Task<byte[]> GenerateProjectArchiveAsync(ContractInformation information);
    }
}