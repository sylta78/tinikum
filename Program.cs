/*
Stack<string> Stack = new Stack<string>();

Stack.Push("E");
Stack.Push("K");
Stack.Push("A");
Stack.Push("N");
Stack.Push("S");

foreach (String letter in Stack)
{
    Console.WriteLine(letter);
}
*/








/*
string input = "{[)](})[{]";

Stack<char> stack = new Stack<char>();
bool balanserad = true;

foreach (char c in input)
{
    if (c == '(' || c == '{' || c == '[')
    {
        stack.Push(c);
    }
    else if (c == ')' || c == '}' || c == ']')
    {
        if (stack.Count == 0)
        {
            balanserad = false;
            break;
        }

        char öppning = stack.Pop();
        if ((öppning == '(' && c != ')') ||
            (öppning == '{' && c != '}') ||
            (öppning == '[' && c != ']'))
        {
            balanserad = false;
            break;
        }
    }
}

if (stack.Count > 0) balanserad = false;

Console.WriteLine(balanserad ? "Balanserad" : "Ej balanserad");
*/


/*
string item = "*+12-34";
Stack<int> stack = new Stack<int>();

foreach(char i in item)
{
    if ();
}
*/

/*
Stack.push("4")
Stack.push("-")
Stack.push("3")
stack.puch("*")
Stack.push("2")
stack.puch("+")
Stack.push("1");
*/





int[] tal = { 1, 6, 4, 1, 4, 2, 7, 4, 6 };
HashSet<int> a = new HashSet<int>();
foreach (int number in tal)
{
    if (a.Contains(number))
    {
        Console.WriteLine($"{number} upprepas först");
        break;
    }
    a.add(number);
}




/*
Dictionary<string, int> dictionary = new Dictionary<string, int>();
*/


/*
dictionary.add("ett", 1);
dictionary.add("sex", 6);
dictionary.add("fyra", 4);
dictionary.add("ett", 1);
dictionary.add("fyra", 4);
dictionary.add("två", 2);
dictionary.add("sju", 7);
dictionary.add("fyra", 4);
dictionary.add("sex", 6);
*/
