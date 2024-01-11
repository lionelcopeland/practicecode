//While Loop

//The while loop loops through a block of code as long as a specified condition is True:

while (condition)
{
  //code block to be executed
}

//Example

//In the example below, the code in the loop will run, over and over again, as long as a variable (i) is less than 5:

i = 0
while(i < 5)
{
  Console.WriteLine(i);
  i++;
}


//The Do/While Loop

/* The do/while loop is a variant of the while loop. This loop will execute the code block once, before checking if the condition is true, then it will repeat the loop as long as condition is true */

do
{
  //code block to be executed
}
while (condition);

/* The example below uses a do/while loop will always be executed at least once, even if the condition is false, because the code block is executed before the condition is tested: */

int i = 0;
do
{
  Console.Writeline(i);
  i++;
}
while (i < 5);
