using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stubble.Core;
using Stubble.Core.Builders;
using Stubble.Extensions.JsonNet;

namespace AElf.Boilerplate.Initializr.Core
{
    public class MustacheTemplateService : ITemplateService
    {
        private readonly StubbleVisitorRenderer _stubble;

        public MustacheTemplateService()
        {
            _stubble = new StubbleBuilder()
                .Configure(settings => settings.AddJsonNet())
                .Build();

            var templatePath = AppDomain.CurrentDomain.BaseDirectory + "template";
        }

        public async Task<byte[]> GenerateProjectArchiveAsync(ContractInformation information)
        {
            byte[] bytes;
            var fileList = await GenerateProjectFileListAsync(information);
            await using (var memoryStream = new MemoryStream())
            {
                using (var archive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                {
                    foreach (var (key, value) in fileList)
                    {
                        var ef = archive.CreateEntry(key, CompressionLevel.Optimal);
                        await using var entryStream = ef.Open();
                        await using var fileToCompress = new MemoryStream(Encoding.UTF8.GetBytes(value));
                        fileToCompress.CopyTo(entryStream);
                    }
                }

                bytes = memoryStream.ToArray();
            }

            return bytes;
        }

        /// <summary>
        /// Generate a list of files:
        /// file name -> file context.
        /// </summary>
        /// <param name="information"></param>
        /// <returns></returns>
        private Task<List<KeyValuePair<string, string>>> GenerateProjectFileListAsync(ContractInformation information)
        {
            var fileList = new List<KeyValuePair<string, string>>();

            foreach (var sourceFile in GetUsefulSourceFiles())
            {
                if (sourceFile.Name.EndsWith(".csproj"))
                {
                    var fileName =
                        sourceFile.Name.Replace("ContractName", information.ContractName ?? "ContractExample");
                    var output = _stubble.Render(sourceFile.Name, sourceFile.Text);
                    fileList.Add(new KeyValuePair<string, string>(fileName, output));
                }
                else
                {
                    var output = _stubble.Render(sourceFile.Name, sourceFile.Text);
                    fileList.Add(new KeyValuePair<string, string>(sourceFile.Name, output));
                }
            }

            return Task.FromResult(fileList);
        }

        private IEnumerable<SourceFile> GetUsefulSourceFiles()
        {
            var templatePath = AppDomain.CurrentDomain.BaseDirectory + "template";
            var templateFiles = Directory.EnumerateFiles(templatePath, "*", SearchOption.AllDirectories).ToList();

            var sourceFiles = templateFiles.Select(templateFile => new SourceFile
            {
                Name = templateFile.Replace(Path.GetFullPath(templatePath), string.Empty)
                    .TrimStart(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar),
                Path = templateFile,
                Text = File.ReadAllText(templateFile),
            }).ToList();

            return sourceFiles;
        }

        private class SourceFile
        {
            public string Name { get; set; }
            public string Path { get; set; }
            public string Text { get; set; }
        }
    }
}