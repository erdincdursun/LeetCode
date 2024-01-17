namespace ParenthesesBalanced;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsValid("(((())))")); 
    }
    public static bool IsValid(string s)
    {
        Stack<char> temp = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[') temp.Push(s[i]);
            else if (s[i] == ')' || s[i] == '}' || s[i] == ']')
            {
                if (temp.Count > 0)
                {
                    char t = temp.Peek();
                    if (t == '(' && s[i] == ')' || t == '[' && s[i] == ']' || t == '{' && s[i] == '}') temp.Pop();
                    else return false;
                }
                else return false;
            }
            else continue;
        }
        if (temp.Count == 0) return true;
        else return false;
    }
}