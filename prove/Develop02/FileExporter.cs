public class FileExporter
{
    public string _entry = "";
    public string _path = "";

    public string _deleter = "";

    public void Exporter(){
        using (StreamWriter outputFile = File.AppendText(_path))
        {
        outputFile.WriteLine(_entry);
        }
    }

    public void FirstAlert(){
        Console.WriteLine();
        Console.WriteLine("#################################################################");
        Console.WriteLine("All entries of local journal had been exported to the file.");
        Console.WriteLine();
        Console.WriteLine("Would you like to clean all entries of local journal? (yes/no) ");
    }
    public void SecondAlert(){
        Console.WriteLine();
        Console.WriteLine("#################################################################");
        Console.WriteLine("All entries of local journal had been deleted");
        Console.WriteLine();
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
    } 
    public void ThirdAlert(){
        Console.WriteLine();
        Console.WriteLine("#################################################################");
        Console.WriteLine("Entries of local journal had NOT been deleted.");
        Console.WriteLine();
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
    }
}