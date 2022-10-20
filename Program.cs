//Reed Goodwin
//10-18-2022
//Mini Challenge #2 "add 2 Numbers"
//A program to add numbers!
//Peer Review 

Console.Clear();
string userInput;
string userInput2;
bool isconverted = true;
bool isNumber;
bool isNumber2;
long validNum = 0;


string fullstop = "";
while(isconverted){
    while(fullstop != "no"){
        Console.WriteLine("Please enter your first number!");
        userInput = Console.ReadLine();
        isNumber = Int64.TryParse(userInput, out validNum);
        Console.WriteLine();
        Console.WriteLine("Please enter your second number!");
        userInput2 = Console.ReadLine();
        isNumber2 = Int64.TryParse(userInput2, out validNum);
        Console.WriteLine();
        Console.WriteLine();
        if(isNumber == true && isNumber2 == true){
            isconverted = false;
            int numone = Convert.ToInt32(userInput);
            int numtwo = Convert.ToInt32(userInput2);
            Console.WriteLine("Your sum is..." + (numone + numtwo));
        }else{
            Console.WriteLine("Invalid entry, Please Try again!");
        }
        Console.WriteLine("");
        Console.WriteLine("---------");
        Console.WriteLine("Do you want to play again?");
        Console.WriteLine("Enter anything to restart || Type \"no\" to exit! :)");
        fullstop = fullstop.ToUpper();
        fullstop = Console.ReadLine();
    }






}