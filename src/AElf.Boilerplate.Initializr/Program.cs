using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AElf.Boilerplate.Initializr.Core;

[assembly: InternalsVisibleTo("AElf.Boilerplate.Initializr.Tests")]

namespace AElf.Boilerplate.Initializr
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            // Print args.
            args.ToList().ForEach(Console.WriteLine);

            if (args.FirstOrDefault() == "create")
            {
                var contractInformation = ExtraContractInformationFromProtoFile(args.Skip(1).FirstOrDefault());
                await CreateBoilerplateProject(contractInformation);
            }
        }

        internal static async Task CreateBoilerplateProject(ContractInformation contractInformation)
        {
            var templateService = new MustacheTemplateService();
            var result = await templateService.GenerateProjectArchiveAsync(contractInformation);

            await using var writeOutputFileStream =
                File.Create(AppDomain.CurrentDomain.BaseDirectory + $"{contractInformation.ContractName}.zip");
            writeOutputFileStream.Write(result);
        }

        internal static ContractInformation ExtraContractInformationFromProtoFile(string protoFilePath)
        {
            var contractInformation = new ContractInformation();

            // Copy proto file to src/template/protobuf in order to compile.
            if (protoFilePath == null)
            {
                protoFilePath = AppDomain.CurrentDomain.BaseDirectory;
            }

            contractInformation.ProtoFileName = Path.GetFileName(protoFilePath);
            foreach (var line in File.ReadAllLines(protoFilePath))
            {
                if (line.Trim().StartsWith("option csharp_namespace"))
                {
                    contractInformation.ContractNameSpace = line.Split('=').Skip(1).First().Remove('"').Remove(';');
                }

                if (line.Trim().StartsWith("option (aelf.csharp_state)"))
                {
                    contractInformation.ContractStateClassName =
                        line.Split('=').Skip(1).First().Remove('"').Remove(';');
                }
            }

            return contractInformation;
        }
    }
}