using System;
using Xunit;

namespace AElf.Boilerplate.Initializr
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            const string path =
                @"/Users/eanzhao/Documents/Code/AElf.Boilerplate.Initializr/template/protobuf/aedpos_contract.proto";
            var contractInformation = Program.ExtraContractInformationFromProtoFile(path);
            Assert.NotNull(contractInformation);
        }
    }
}