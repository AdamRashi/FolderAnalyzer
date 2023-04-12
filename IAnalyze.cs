using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryAnalyzer
{
    internal interface IAnalyze
    {
        public string FindMostFrequentExtension(string path);

        public string[] GetNRecentFiles(string path, int n);

        public List<List<string>> GetDuplicateFolders(string path);

        public string[] SortFilesByName(string path);
    }
}
