# Word Count Program

This is a simple console application written in C# that counts the number of words in a sentence.

## How to Run

1. Clone the repository to your local machine.
2. Open the solution in JetBrains Rider.
3. Run the program.

## Program Flow

1. The program will first prompt you to input a sentence.
2. It will then count the number of words in the sentence.
3. The result will be displayed.

## Code Snippet

```csharp
Console.WriteLine("Input sentence:");
string sentence = Console.ReadLine();

int result = getWordCount(sentence);

Console.WriteLine($"Your sentence has {result} words.");

Console.ReadKey();

static int getWordCount(string sentence)
{
    string[] words = sentence.Split(' ');
    int wordCount = words.Length;
    return wordCount;
}
