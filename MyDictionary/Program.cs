using System;
using System.Collections.Generic;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int> myDictionary = new MyDictionary<string,int>();

            myDictionary.Add("key1", 12);
            myDictionary.Add("key2", 0);
            myDictionary.Add("key3", 9999);
            myDictionary.Add("key4", 454);

            myDictionary.List();
        }
    }
}
