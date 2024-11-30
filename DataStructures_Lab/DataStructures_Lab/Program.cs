// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Please enter a word you would like to reverse");

string userWord=Console.ReadLine();

//Console.WriteLine(Reverse(userWord));
Console.WriteLine(Reverse(userWord));






//string Reverse(string input)
//{
//    char[] charArray = input.ToCharArray();
//    Array.Reverse(charArray);
//    return new string(charArray);
//}

string Reverse(string input)
{
    Stack<char> stack = new Stack<char>(input);
    string temp = "";
    while (stack.Count > 0)
    {
        temp += stack.Pop();
    }
    return temp;
}
