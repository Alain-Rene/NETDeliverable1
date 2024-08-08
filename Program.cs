
/*
Store restock program that keeps track of how many items have been purchased and
determines if each item needs to be restocked
*/

//Varaible declaration
int numSoda = 100;
int numChips = 40;
int numCandy = 60;
int restockSoda = 40;
int restockChips = 20;
int restockCandy = 40;

int newSoda = 100;
int newChips = 40;
int newCandy = 60;

System.Console.WriteLine($"Hello! How many sodas have been sold today? {numSoda} are in stock");

int userInput = int.Parse(Console.ReadLine());

/*
If the amount sold exceeds the number available in stock, 
display error message and do not calculate
*/
if (userInput > 100){
    System.Console.WriteLine("the value inputted is too high. Stock not adjusted");
} 
else{
    newSoda = numSoda - userInput;
    System.Console.WriteLine("The current value of Sodas is " + (newSoda));
    
}

//repeat for chips sold
System.Console.WriteLine($"How many chips have been sold today? {numChips} are in stock");

userInput = int.Parse(Console.ReadLine());

if (userInput > 40){
    System.Console.WriteLine("the value inputted is too high. Stock not adjusted");
} 
else{
    newChips = numChips - userInput;
    System.Console.WriteLine("The current value of Chips is " + (newChips));
    
}

//repeat for candy sold
System.Console.WriteLine($"How much Candy has been sold today? {numCandy} are in stock");

userInput = int.Parse(Console.ReadLine());

if (userInput > 60){
    System.Console.WriteLine("the value inputted is too high. Stock not adjusted");
} 
else{
    newCandy = numCandy - userInput;
    System.Console.WriteLine("The current value of Candy is " + (newCandy));
    
}

//Displays if a value needs to be restocked
System.Console.WriteLine("Thank you. Here's what needs to be restocked:");

if(newSoda <= restockSoda){
        System.Console.WriteLine("Sodas need to be restocked");
} 

if(newChips <= restockChips){
        System.Console.WriteLine("Chips need to be restocked");
} 

if(newCandy <= restockCandy){
        System.Console.WriteLine("Candy need to be restocked");
} 