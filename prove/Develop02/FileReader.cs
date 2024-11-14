public class FileReader
{   
    public string _path = "";
    public void Reader(){

      string[] readText = File.ReadAllLines(_path);
                foreach (string s in readText)
                {
                    Console.WriteLine(s);
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
    }    
}
