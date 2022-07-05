using Hash_Tables;
Console.WriteLine("Welcome to the basic Hash Table problem of Freq. of words");
Console.WriteLine("Enter a sentence");
string[] sentence = (Console.ReadLine()).Split();
int l = sentence.Length;
WordsFreq<string> word = new WordsFreq<string>();
for (int i = 0; i < l; i++) //inserting different words in hash table
{
    Console.WriteLine(sentence[i]);
    word.Insert(sentence[i]);
}
Console.WriteLine("Enter a word whose frequency you want");
string wordFreq = Console.ReadLine();

long hashcode = wordFreq.GetHashCode();
if (word.get(Math.Abs(hashcode)) != 0)         //checks if the word is present by checking if its index value comes under the array index by using get function
{
    word.frequencyOfword(Math.Abs(hashcode), wordFreq);                 //Math.Abs used as some times we get negative hash codes
}
else
{
    Console.WriteLine("Word not found");
}

