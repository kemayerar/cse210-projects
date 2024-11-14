using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Password frontDoor = new Password();
        frontDoor.Door();
        if (frontDoor._output == 1){
            JournalApp trigger = new JournalApp();
            trigger.App();
        }
        else if (frontDoor._output == 2){
            Console.WriteLine("GET OUT OF HERE INTRUDER");
        }
        
    }
}
