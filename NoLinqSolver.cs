using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryAnalyzer
{
    class NoLinqSolver : IAnalyze
    {
        public string FindMostFrequentExtension(string path)
        {
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

            Dictionary<string, int> extensionCounts = new Dictionary<string, int>();

            foreach (string file in files)
            {
                string extension = Path.GetExtension(file).ToLower();
                if (extensionCounts.ContainsKey(extension))
                {
                    extensionCounts[extension]++;
                }
                else
                {
                    extensionCounts[extension] = 1;
                }
            }

            int maxCount = 0;
            string mostFrequentExtension = "";
            foreach (KeyValuePair<string, int> pair in extensionCounts)
            {
                if (pair.Value > maxCount)
                {
                    maxCount = pair.Value;
                    mostFrequentExtension = pair.Key;
                }
            }

            return mostFrequentExtension;
        }

        public List<List<string>> GetDuplicateFolders(string path)
        {
            var folders = Directory.GetDirectories(path);
            var duplicates = new List<List<string>>();

            for (int i = 0; i < folders.Length - 1; i++)
            {
                var folder1 = folders[i];
                var files1 = Directory.GetFiles(folder1);
                var size1 = GetTotalFileSize(files1);
                var count1 = files1.Length;

                for (int j = i + 1; j < folders.Length; j++)
                {
                    var folder2 = folders[j];
                    var files2 = Directory.GetFiles(folder2);
                    var size2 = GetTotalFileSize(files2);
                    var count2 = files2.Length;

                    if (size1 == size2 && count1 == count2 && AreFilesEqual(files1, files2))
                    {
                        duplicates.Add(new List<string> { folder1, folder2 });
                    }
                }
            }

            return duplicates;
        }

        private static long GetTotalFileSize(string[] files)
        {
            long size = 0;
            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                size += fileInfo.Length;
            }
            return size;
        }

        private static bool AreFilesEqual(string[] files1, string[] files2)
        {
            List<string> fileNames1 = new List<string>();

            foreach (var file in files1)
            {
                fileNames1.Add(Path.GetFileName(file));
            }

            fileNames1.Sort();

            List<string> fileNames2 = new List<string>();

            foreach (var file in files2)
            {
                fileNames2.Add(Path.GetFileName(file));
            }

            fileNames2.Sort();

            if (fileNames1.Count != fileNames2.Count) return false;

            for (int i = 0; i < fileNames1.Count; i++)
            {
                if (fileNames1[i] != fileNames2[i]) return false;
            }

            return true;
        }

        public string[] GetNRecentFiles(string path, int n)
        {
            var directoryInfo = new DirectoryInfo(path);
            var files = directoryInfo.GetFiles();
            Array.Sort(files, (f1, f2) => f2.CreationTime.CompareTo(f1.CreationTime));
            int length = Math.Min(n, files.Length);
            var result = new string[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = files[i].Name;
            }
            return result;
        }

        public string[] SortFilesByName(string path)
        {
            var files = Directory.GetFiles(path);
            Array.Sort(files, (a, b) => a.Length.CompareTo(b.Length));
            var sortedFiles = new string[files.Length];
            for (int i = 0; i < files.Length; i++)
            {
                sortedFiles[i] = Path.GetFileName(files[i]);
            }
            return sortedFiles;
        }

       
    }
}
