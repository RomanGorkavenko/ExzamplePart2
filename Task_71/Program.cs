int n = 2;
string letter = "аисв";

FindWord(letter, new char[n]);

void FindWord(string let, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.Write($"{new String(word)} ");
        return;
    }

    for (int i = 0; i < let.Length; i++)
    {
        word[length] = let[i];
        FindWord(let, word, length + 1);
    }

}