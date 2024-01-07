for (statement 1; statement; statement 3)
{
    //code block to be executed
}
/* Statement 1 is executed once  before the execution of the code block
   Statement 2 defines the condition for executing the code block
   Statement 3 is executed every time after the code block has been executed */

// The example below  will print 0 to 4:
for (int i = 0; < 5; i++)
{
    Console.Writeline(i);
}

/* Statement 1 sets a variable before the loops starts (int i = 0)
   Statement 2 defines the condition for the loop to run (i must be less than 5)
   Statement 3 increases a value (i++) each time the code block in the loop has been executed */

// This example will only print even values between 0 and 10
   for (int i = 0; i <= 10; i = i + 2)
   {
    Console.Writeline(i);
   }

//Nested Loops

// The inner loop will be executed one time for each iteration of the outer loop

// Outer loop
for (int i = 1; i <= 2; ++i) 
{
  Console.WriteLine("Outer: " + i);  // Executes 2 times

  // Inner loop
  for (int j = 1; j <= 3; j++) 
  {
    Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
  }
}

//The foreach Loop

//The forEach loop which is used exclusively to loop through elements in an array:

foreach (type variablName in arrayName)
{
    //code block to be executed

}

//The example outputs elements in the cars array
string[] cars = {"Volve","BMW","Ford","Mazda"};
foreach (string i in cars)
{
    Console.WriteLine(i);
}
