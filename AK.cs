Random numberGen = new Random();

int input;
int numberRolled;
int numberInput = 2;

numberRolled = numberGen.Next(1,101);

Console.WriteLine("Press 1 if you want to play a game!");
input = Convert.ToInt32(Console.ReadLine());

if (input == 1){
    Console.WriteLine("Sure lets play a game, guess the number im thinking of! It is between 1-100!");
    while (numberInput != numberRolled){
       numberInput = Convert.ToInt32(Console.ReadLine());  
       if (numberRolled == numberInput){
        Console.WriteLine("Congrats! You got it!");
       }
       else if (numberRolled > numberInput) {
        Console.WriteLine("This is too low. Try again!");
       }
       else {
        Console.WriteLine("This is too high. Try again!");
       }
    }
} else { 
    Console.WriteLine("Ok maybe next time.");
}

Console.ReadKey();
