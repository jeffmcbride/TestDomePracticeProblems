using System;
using System.Linq;
using System.Collections.Generic;

public class MergeNames
{
    public static string[] UniqueNames(string[] names1, string[] names2)
    {
        //Kind of a roundabout way to do it, but since I much prefer working with lists, to array, 
        //I start with a list then return change it back into an array
        List<string> list = new List<string>();
        foreach (string name in names1){
              list.Add(name);
        }
         foreach(string name2 in names2)
         {
             list.Add(name2);
         }
        
        return list.Distinct().ToList().ToArray();
    
    }
    
    
    public static void Main(string[] args)
    {
        string[] names1 = new string[] {"Ava", "Emma", "Olivia"};
        string[] names2 = new string[] {"Olivia", "Sophia", "Emma"};
        Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
    }
}