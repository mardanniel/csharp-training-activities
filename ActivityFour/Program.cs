using System.Text;

namespace ActivityFour
{
    class Program
    {
        static void Main()
        {
            string path = @"File Path";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            string strFromFile = rd.ReadToEnd();
            string[] wordsList = strFromFile.Split(
                new string[] {" ", Environment.NewLine}, 
                StringSplitOptions.None
                );

            int evenLengthWords = 0;
            foreach (string str in wordsList)
            {
                if (str.Length % 2 == 0)
                {
                    
                    evenLengthWords++;
                }
            }

            Console.WriteLine($"String from file: ");
            Console.WriteLine(strFromFile);
            Console.WriteLine($"Number of even length words: {evenLengthWords}");

            rd.Close();
            fs.Close();
        }
    }
}