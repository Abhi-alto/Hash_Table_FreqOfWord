
System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Tables
{
    public class WordsFreq<gtype> where gtype : IComparable
    {
        linked_list<gtype>[] key_row = new linked_list<gtype>[11];    //array of linked list type data type with size 11
        public WordsFreq()
        {
            for (int x = 0; x < 11; x++)                               //taking the predefined size of array as 11
            {
                linked_list<gtype> list = new linked_list<gtype>();
                key_row[x] = list;
            }
        }
        public void Insert(gtype data)          //inserting a data into  hash table
        {
            long hashcode = data.GetHashCode();
            long index = Math.Abs(hashcode % 11);
            linked_list<gtype> temporary;
            temporary = key_row[index];
            temporary.add(data);
        }
        public long get(long key)        //using the entered key we find if the key is present in the hash table & and then print it
        {
            if ((key % 11) <= 10)
            {
                linked_list<gtype> temp;
                temp = key_row[key % 11];
                //temp.print();
                return (key % 11);
            }
            else
            {
                Console.WriteLine("kEY NOT PRESENT IN THE HASH TABLE");
                return 0;
            }

        }
        public void remove(gtype data, int position)             //removing a data from the hash table
        {
            linked_list<gtype> temp;
            temp = key_row[position];
            temp.delete(data, position);
        }
        public int getsize()                                //getting the size of the hash table
        {
            int size = 0;
            for (int x = 0; x < 11; x++)
            {
                linked_list<gtype> temp;
                temp = key_row[x];
                size = size + temp.size();
            }
            Console.WriteLine(size + " is the size of the hash table");
            return size;
        }
        public void frequencyOfword(long hashcode, gtype wordFreq)
        {
            ///for getting the frequency, we first go that particular 
            ///linked list using the hash code and then call the frequency function for that linked list
            linked_list<gtype> temp;
            temp = key_row[hashcode % 11];
            Console.WriteLine("frequency of " + wordFreq + " is " + temp.frequency(wordFreq));
        }
        public bool isEmpty()                       //checking if the hash table is empty or not
        {
            WordsFreq<gtype> obj = new WordsFreq<gtype>();
            if (obj.getsize() > 0)
                return false;
            else
                return true;
        }

    }
}