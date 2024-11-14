public class Password{
        
        public string _guess = "";
        public string _password = "2009";
        public int _counter = 0;
        public int _output;


        public int Door(){
            Console.WriteLine();
            Console.WriteLine("Insert the 4-digits code to access the Journal app");
            Console.WriteLine("A seer and revelator was born this year");
            while(_guess != _password){
                _guess = Console.ReadLine();
                _guess = _guess.ToString();

                if (_guess == _password){
                    _output = 1;
                }
                if (_guess != _password){
                    Console.WriteLine();
                    Console.WriteLine("Wrong");
                    _counter += 1;
                    if (_counter == 3){
                        Console.WriteLine("He touches the heart of many people");
                        }
                    else if (_counter == 4){
                        _output = 2;
                        break;
                    }
                }
            } return _output;

        }
} 