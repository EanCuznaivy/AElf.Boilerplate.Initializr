using System.IO;
using System.Linq;
using Acs0;
using AElf.Contracts.TestKit;
using AElf.Cryptography.ECDSA;
using AElf.Kernel;
using AElf.Types;
using Google.Protobuf;
using Volo.Abp.Threading;

namespace AElf.Contracts.{{ContractName}}
{
    public class {{ContractName}}ContractTestBase : ContractTestBase<{{ContractName}}ContractTestModule>
    {
        private Address {{ContractName}}ContractAddress { get; set; }

        private ACS0Container.ACS0Stub ZeroContractStub { get; set; }

        internal {{ContractName}}ContractContainer.{{ContractName}}ContractStub {{ContractName}}ContractStub { get; set; }

        protected {{ContractName}}ContractTestBase()
        {
            InitializeContracts();
        }

        private void InitializeContracts()
        {
            ZeroContractStub = GetZeroContractStub(SampleECKeyPairs.KeyPairs.First());

            {{ContractName}}ContractAddress = AsyncHelper.RunSync(() =>
                ZeroContractStub.DeploySystemSmartContract.SendAsync(
                    new SystemContractDeploymentInput
                    {
                        Category = KernelConstants.CodeCoverageRunnerCategory,
                        Code = ByteString.CopyFrom(File.ReadAllBytes(typeof({{ContractName}}Contract).Assembly.Location)),
                        Name = ProfitSmartContractAddressNameProvider.Name,
                        TransactionMethodCallList = new SystemContractDeploymentInput.Types.SystemTransactionMethodCallList()
                    })).Output;
            {{ContractName}}ContractStub = Get{{ContractName}}ContractStub(SampleECKeyPairs.KeyPairs.First());
        }

        private ACS0Container.ACS0Stub GetZeroContractStub(ECKeyPair keyPair)
        {
            return GetTester<ACS0Container.ACS0Stub>(ContractZeroAddress, keyPair);
        }

        private {{ContractName}}ContractContainer.{{ContractName}}ContractStub Get{{ContractName}}ContractStub(ECKeyPair keyPair)
        {
            return GetTester<{{ContractName}}ContractContainer.{{ContractName}}ContractStub>({{ContractName}}ContractAddress, keyPair);
        }
    }
}