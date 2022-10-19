//aisha mashrah
//9-13-22
//Mini Challenge # 6 - Odd Or Even
//Create a brand new console project that takes in an input and tells you if the number entered is odd or even.

Console.Clear();
string userInput;

bool isConverted = true;
bool isNumber; 
long validNum = 0;
bool playAgain = true;

while(playAgain){
   isConverted = true;
    while(isConverted){
            Console.WriteLine("Please enter a number");
            userInput = Console.ReadLine();
            
            isNumber = Int64.TryParse(userInput, out validNum);
            
            Console.WriteLine(isNumber);
            if(isNumber == true){
                isConverted = false;
                Console.WriteLine("You entered a number");
            }else{
                Console.WriteLine(" please try again");
            }
        }
        long mynumber = (validNum % 2);
        Console.WriteLine("");
        if(mynumber == 0 ){
            Console.WriteLine(validNum + " is even ");
        }
        if(mynumber == 1 ){
            Console.WriteLine(validNum + " is odd ");
        }

        Console.WriteLine("DO you want to play again? Yes or No?");
        string playGammeYes = Console.ReadLine();
        

        if(playGammeYes == "yes"){
            playAgain = true;
        } else {
            playAgain = false;
        }
    }
    



