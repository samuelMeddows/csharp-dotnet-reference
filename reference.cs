// C# Syntax Reference

// Variables //
// 1 byte is made up of 8 bits 00000000 - these bits can be used to store a number as follows
//// Each bit can be worth 0 or 1 of the value it is placed in
////// From the right we start with a value of 1 and double for each digit to the left
//// 00000000 = 0
//// 00000001 = 1
//// 00000010 = 2
//// 00000011 = 3
//// 00000100 = 4
//// 00000101 = 5
//// 00000110 = 6
//// 00000111 = 7
//// 00001000 = 8

// 1 byte (8 bit) unsigned, where signed means it can be negative
byte myByte = 255;
byte mySecondByte = 0;

// 1 byte (8 bit) signed, where signed means it can be negative
sbyte mySbyte = 127;
sbyte mySecondSbyte = -128;

// 2 byte (16 bit) unsigned, where signed means it can be negative
ushort myUshort = 65535;

// 2 byte (16 bit) signed, where signed means it can be negative
short myShort = -32768;

// 4 byte (32 bit) signed, where signed means it can be negative
int myInt = 2147483647;
int mySecondInt = -2147483648;

// 8 byte (64 bit) signed, where signed means it can be negative
long myLong = -9223372036854775808;

// 4 byte (32 bit) floating point number
float myFloat = 0.751f;
float mySecondFloat = 0.75f;

// 8 byte (64 bit) floating point number
double myDouble = 0.751;
double mySecondDouble = 0.75d;

// 16 byte (128 bit) floating point number
decimal myDecimal = 0.751m;
decimal mySecondDecimal = 0.75m;

// Console.WriteLine(myFloat - mySecondFloat);
// Console.WriteLine(myDouble - mySecondDouble);
// Console.WriteLine(myDecimal - mySecondDecimal);

string myString = "Hello World";
// Console.WriteLine(myString);
string myStringWithSymbols = "!@#$@^$%%^&(&%^*__)+%^@##$!@%123589071340698ughedfaoig137";
// Console.WriteLine(myStringWithSymbols);

bool myBool = true;


// Arrays //
string[] myGroceryArray = new string[2];
myGroceryArray[0] = "Guacamole";
myGroceryArray[1] = "Ice Cream";

Console.WriteLine(myGroceryArray[0]);
Console.WriteLine(myGroceryArray[1]);

string[] mySecondGroceryArray = {"Apples", "Eggs"};
Console.WriteLine(mySecondGroceryArray[0]);
Console.WriteLine(mySecondGroceryArray[1]);

string[,] myTwoDimensionArray = new string[,] {
    {"Bread", "Tomatoes"},
    {"Steak", "Potatoes"}
};

Console.WriteLine(myTwoDimensionArray[0,0]);
Console.WriteLine(myTwoDimensionArray[0,1]);


// Lists //
List<string> myGroceryList = new List<string>() {"Milk", "Cheese"};
Console.WriteLine(myGroceryList[0]);
Console.WriteLine(myGroceryList[1]);

myGroceryList.Add("Pasta");
Console.WriteLine(myGroceryList[2]);

IEnumerable<string> myGroceryIEnumberable = myGroceryList;
Console.WriteLine(myGroceryIEnumberable.First());


// Dictionary //
Dictionary<string, string> myGroceryDictionary = new Dictionary<string, string>{
    {"Dairy", "Cream"}
};
Console.WriteLine(myGroceryDictionary["Dairy"]);

Dictionary<string, string[]> mySecondGroceryDictionary = new Dictionary<string, string[]>(){
    {"Dairy", new string[]{"Cheese", "Yogurt", "Cream"}}
};
Console.WriteLine(mySecondGroceryDictionary["Dairy"][1]);

Dictionary<string, decimal> itemPrices = new Dictionary<string, decimal>{
    {"cheese", 4.95m},
    {"carrots", 1.20m}
};


// Operators //
int myInt = 5;
int mySecondInt  = 10;
Console.WriteLine(myInt);

myInt++;
Console.WriteLine(myInt);

myInt+= 2;
Console.WriteLine(myInt);

myInt-= 3;
Console.WriteLine(myInt);

Console.WriteLine(myInt * mySecondInt);
Console.WriteLine(mySecondInt / myInt);
Console.WriteLine(mySecondInt + myInt);
Console.WriteLine(myInt - mySecondInt);

//Order of Operations
//- Parenthesis ()
//- Exponents Note: Irrelevant in Csharp as exponents are done through a function eg Math.Pow(5,2)
//- Multiplication + Division * / Which ever comes first 
//- Addition + Subtraction + - Which ever comes first 

string myString = "test";
Console.WriteLine(myString);
myString += ". second part.";
Console.WriteLine(myString);
myString = myString +". \"third\\ part.";
Console.WriteLine(myString);

string[] myStringArr = myString.Split(". ");
Console.WriteLine(myStringArr[0]);
Console.WriteLine(myStringArr[1]);
Console.WriteLine(myStringArr[2]);

Console.WriteLine(myInt.Equals(mySecondInt));
Console.WriteLine(myInt.Equals(mySecondInt / 2));

Console.WriteLine(myInt == mySecondInt / 2);
Console.WriteLine(myInt != mySecondInt / 2);

Console.WriteLine(myInt >= mySecondInt);
Console.WriteLine(myInt > mySecondInt);
Console.WriteLine(myInt <= mySecondInt);
Console.WriteLine(myInt < mySecondInt);

Console.WriteLine(5 < 10 && 5 > 10);
Console.WriteLine(5 < 10 || 5 > 10);


// Conditionals //
int conInt = 5;
int conSecondInt = 10;

if (conInt > conSecondInt){
    conInt += 10;
}
Console.WriteLine(conInt);


// Condition Statements //
string myCow = "cow";
string myCapitalizedCow = "Cow";

if (myCow == myCapitalizedCow){
    Console.WriteLine("Equal");
}else if (myCow == myCapitalizedCow.ToLower()){
    Console.WriteLine("Equal after case lower function");
}else{
    Console.WriteLine("Not Equal");
}

switch (myCow){
    case "cow":
        Console.WriteLine("Lowercase");
        break;
        case "Cow":
        Console.WriteLine("Uppercase");
        break;
    default:
        Console.WriteLine("Default Ran");
        break;
}

// Loops //

int[] intsToCompress = new int[]{10, 15, 20, 25, 30, 12, 34};

int totalValue = intsToCompress[0] + intsToCompress[1] 
+ intsToCompress[2] + intsToCompress[3] + intsToCompress[4] 
+ intsToCompress[5] + intsToCompress[6];

Console.WriteLine(totalValue);
