using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[2] { "Adam", "Eva" };

            names = AddName(names, "Lo");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            //names = RemoveName(names, "Håkan");
           
        }

        private static string[] AddName(string[] names, string newName)
        {
            string[] temp = new string[names.Length +1];
            for (int i = 0; i < names.Length + 1; i++)
            {
                temp[i] = names[i -1];
            }
            temp[temp.Length - 1] = newName;
            return temp;
           
        }
        //private static string[] RemoveName(string[] names, string name)
        //{
        //    //string[] temp = // 
        //    //return temp;
        //}

    }
}
