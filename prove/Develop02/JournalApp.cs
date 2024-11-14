public class JournalApp{
    public void App(){
         List<string> questions = new List<string>();
          List<string> journal = new List<string>();


          questions.Add("How have been your day so far? ");
          questions.Add("What did your bestie told you today? ");
          questions.Add("Marco? ");
          questions.Add("What's new on Instagram? ");
          questions.Add("What are the plans for tomorrow? ");
          questions.Add("Cougars are killing it ");
          questions.Add("should not you be studying right now? ");
          questions.Add("Arcane season 2 in on Netflix now, you should check it out ");


          
          int response = -1;
          while (response != 5)
          {
            Console.WriteLine();
            Console.WriteLine("#################################################################");
            Console.WriteLine("Hello! What would you like to do today? ");
            Console.WriteLine("1- Write to local journal");
            Console.WriteLine("2- Display local journal");
            Console.WriteLine("3- Load journal file");
            Console.WriteLine("4- Save into the journal file");
            Console.WriteLine("5- Quit");

            string valueInText = Console.ReadLine();
            response = int.Parse(valueInText);
            if (response == 1){
                Random rnd = new Random();
                int num = rnd.Next(questions.Count);
                Console.WriteLine();
                Console.WriteLine($"{questions[num]}");
                string answer = Console.ReadLine();
                DateTime printTime = DateTime.Now;
                string dateText = printTime.ToShortDateString();
                journal.Add($"{printTime}-----> {questions[num]}-----> {answer}");
            }

            if (response == 2){
                Console.WriteLine();
                Console.WriteLine("#################################################################");
                foreach (string entry in journal)
                {
                    Console.WriteLine(entry);
                }
                Console.WriteLine();
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
            }
            if (response == 3){
                FileReader option3 = new FileReader();
                Console.WriteLine();
                Console.WriteLine("Please insert the name of the text file (Journal.txt)");
                option3._path = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("#################################################################");
                option3.Reader();
                
            }
            if (response == 4){
                FileExporter option4 = new FileExporter();
                Console.WriteLine();
                Console.WriteLine("Please insert the name of the text file (Journal.txt)");
                option4._path = Console.ReadLine();
                for (int i = 0; i < journal.Count; i++){
                option4._entry = journal[i];
                option4.Exporter();
                }
                option4.FirstAlert();
                option4._deleter = Console.ReadLine();
                if (option4._deleter == "yes"){
                    for (int k = journal.Count - 1; k > -1; k--){
                    journal.RemoveAt(k);
                }
                option4.SecondAlert();
                }
                if (option4._deleter == "no"){
                    option4.ThirdAlert();
                }
            }
            }
            Console.WriteLine();
            Console.WriteLine("#################################################################");
            Console.WriteLine("Come back soon with more secrets!");
            Console.WriteLine();

    }
}