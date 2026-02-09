// datatype diceroll (parameters) //
// codeblock //
// optional return //




int diceRoll ()
{
    Random rnd = new Random ();
    return rnd.Next (6) + 1;
}

// run 10 times
for (int i = 0; i < 10; i += 1)
{
    Console.WriteLine (diceRoll()) ;
}







// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



