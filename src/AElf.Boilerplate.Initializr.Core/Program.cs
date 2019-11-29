using System;
using System.IO;
using System.Threading.Tasks;

namespace AElf.Boilerplate.Initializr.Core
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            // Write proto file to src/template/protobuf in order to compile.
            var protoFilePath = args[0];
            var protoFileName = Path.GetFileName(protoFilePath);
            var protoFile = File.ReadAllBytes(protoFilePath);
            await using var writeInputFileStream =
                File.Create(
                    $"{AppDomain.CurrentDomain.BaseDirectory}template{Path.DirectorySeparatorChar}" +
                    $"protobuf{Path.DirectorySeparatorChar}{protoFileName}");
            writeInputFileStream.Write(protoFile);

            // TODO: Compile proto file.

            // TODO: Compile *.c.cs and *.g.cs to get FileDescriptor instance.(Is this possible?)

            // TODO: Convert FileDescriptor instance to ContractInformation instance.
            var contractInformation = new ContractInformation();

            var templateService = new MustacheTemplateService();
            var result = await templateService.GenerateProjectArchiveAsync(contractInformation);

            await using var writeOutputFileStream =
                File.Create(AppDomain.CurrentDomain.BaseDirectory + $"{contractInformation.ContractName}.zip");
            writeOutputFileStream.Write(result);
        }
    }
}