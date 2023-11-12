// a method that counts the number of words in a sentence
// take in string, the sentence
// return the number of words as an integer

// Prompt to input a sentence and store as a string
Console.WriteLine("Input sentence:");
string sentence = Console.ReadLine();

// use getWordCount method that is below
int result = getWordCount(sentence);

// Return how many words the sentence has
Console.WriteLine($"Your sentence has {result} words.");

//close with key
Console.ReadKey();

// getWordCount method
static int getWordCount(string sentence)
{

    // splits after every space to count words then puts into an array
    string[] words = sentence.Split(' ');
    // count the array length
    int wordCount = words.Length;
    // return wordCount
    return wordCount;

}