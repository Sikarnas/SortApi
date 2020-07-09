using System;
using System.IO;
using SortApi.Models;

namespace SortApi.Services{
     public class BubbleSortService: IBubbleSortService
    {
        private string[] BubbleSort(string[] input) 
        {
            string t;                    
            for (int j = 0; j <= input.Length - 2; j++)
            {
                for (int i = 0; i <= input.Length - 2; i++)
                {
                    if (int.Parse(input[i]) > int.Parse(input[i + 1]))
                    {
                        t = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = t;
                    }
                } 
            }
            return input;        
        }

        private void SaveArrayToFile(string[] array)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            File.WriteAllText(Path.Combine(docPath, "results.txt"), string.Join(",", array));
        }

         public SortResponse GetSortedArray(string numbersToSort) 
         {
             string[] arrayToSort = numbersToSort.Split(',');
             string[] sortedArray = BubbleSort(arrayToSort);
             SaveArrayToFile(sortedArray);
             return new SortResponse{
                    message = "Sorted numbers is saved on your Desktop in results.txt file.",
                    before = numbersToSort,
                    after = string.Join(",", sortedArray),
            };
         }
        public SortResponse GetSortedFile(string fileName)
        {

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(desktopPath, fileName + ".txt");
            using (StreamReader sr = new StreamReader(path))
            {
                string line = sr.ReadToEnd();
                string[] arrayToSort = line.Split(",");
                string[] sortedArray = BubbleSort(arrayToSort);
                SaveArrayToFile(sortedArray);
                return new SortResponse{
                    message = "File was sucessfully read and results are saved on your Desktop in results.txt file.",
                    before = string.Join(",", line),
                    after = string.Join(",", sortedArray),
                };
            }
        }
    }
}

  