using System.Collections.Generic;

namespace AElf.Boilerplate.Initializr.Core
{
    public class ContractInformation
    {
        public string ContractName { get; set; }
        public string ContractNameSpace { get; set; }
        public string ContractStateClassName { get; set; }
        public List<string> ContractBases { get; set; }
    }
}