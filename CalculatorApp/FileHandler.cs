using Calculator.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace CalculatorApp
{
    public class FileHandler
    {
        public string[] GetFileData(string filePath)
        {
            ThrowIfNotExists(filePath);
            string[] list = File.ReadAllLines(filePath);
            return list;
        }

        public void SetFileData(double[] results)
        {
            string path = @"OutputFile\ExpressionsResults.txt";
            string[] strings = Convert(results);
            File.WriteAllLines(path, strings);
        }

        private void ThrowIfNotExists(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }
        }

        private string[] Convert(double[] doubles)
        {
            string[] strings = new string[doubles.Length];
            for(int i = 0; i < doubles.Length; i++)
            {
                if (doubles[i] == null)
                {
                    strings[i] = "Exception. Wrong input.";
                    continue; 
                }
                strings[i] = doubles[i].ToString();
            }
            return strings;
        }
    }
}
