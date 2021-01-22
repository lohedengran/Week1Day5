using System;

namespace Week1Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] characters = new char[5] { 'b', 'e', 'a', 'c', 'd' };
            SelectionSort(characters);
        }

        private static void SelectionSort(char[] characters)
        {
            for (int i = 0; i < characters.Length -1; i++)
            {
                int lvi = i;
                for (int j = i + 1; j < characters.Length; j++)
                {

                }
            }
        }
    }
}
