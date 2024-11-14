public class Tester{
    public string _input = "";
    public int _output;
    
    public int Machine(){
        Console.WriteLine("Please insert your input");
        _input = Console.ReadLine();

        if (_input == "red"){
            _output = 2;
        }
        else if (_input == "blue"){
            _output = 3;
        }
        return _output;

    }
}