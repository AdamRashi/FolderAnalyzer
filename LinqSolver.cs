using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryAnalyzer
{
    public class LinqSolver : IAnalyze
    {
        public string FindMostFrequentExtension(string path)
        {
            var extensions = Directory.GetFiles(path)
                              .Select(file => Path.GetExtension(file))
                              .GroupBy(ext => ext)
                              .OrderByDescending(group => group.Count());

            return extensions.First().Key;
        }

        public List<List<string>> GetDuplicateFolders(string path)
        {
            var folders = Directory.GetDirectories(path);

            var duplicates = folders
                .Select((folder, index) => new
                {
                    Index = index,
                    Name = Path.GetFileName(folder),
                    Size = new DirectoryInfo(folder).GetFiles("*.*", SearchOption.AllDirectories).Sum(f => f.Length),
                    FileCount = new DirectoryInfo(folder).GetFiles("*.*", SearchOption.AllDirectories).Count(),
                    Files = new DirectoryInfo(folder).GetFiles("*.*", SearchOption.AllDirectories).Select(f => f.Name).ToArray()
                })
                .GroupBy(folder => new { folder.Size, folder.FileCount, Files = string.Join(",", folder.Files.OrderBy(f => f)) })
                .Where(group => group.Count() > 1)
                .Select(group => group.Select(f => folders[f.Index]).ToList())
                .ToList();

            return duplicates;
        }

        public string[] GetNRecentFiles(string path, int n)
        {
            var files = new DirectoryInfo(path).GetFiles()
                                       .OrderByDescending(file => file.CreationTime)
                                       .Take(n)
                                       .Select(file => file.Name)
                                       .ToArray();
            return files;

        }

        public string[] SortFilesByName(string path)
        {
            var files = Directory.GetFiles(path);
            var sortedFiles = files.OrderBy(f => f.Length).ToArray();
            return sortedFiles.Select(f => Path.GetFileName(f)).ToArray();
        }
    }
}
