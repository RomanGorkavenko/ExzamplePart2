
string charWords = "аисв";
int countChar = 2;

PrintWord(charWords, countChar, String.Empty);

void PrintWord(string alphabet, int length, string prefix)
{
    if (length == 0)
    {
        Console.Write(prefix + " ");
    }
    else
    {
        foreach (char c in alphabet)
        {
            PrintWord(alphabet, length - 1, prefix + c);
        }
    }
}
