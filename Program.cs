using Hash_Tables;
Console.WriteLine("Welcome to the basic Hash Table problem of Freq. of words");
Console.WriteLine("Enter a sentence");
string[] sentence = (Console.ReadLine()).Split();
int l=sentence.Length;
WordsFreq<string> word = new WordsFreq<string>();
for (int i=0; i<l; i++) //inserting different words in hash table
{
    word.Insert(sentence[i]);
}
Console.WriteLine("Enter a word whose frequency you want");
string wordFreq=Console.ReadLine();
long hashcode = wordFreq.GetHashCode();
if(word.get(hashcode) !=0)
{
    word.freq(hashcode,)
}

