using System.Collections;


 namespace Hashtableattempt
 {
    internal class Program
    {
       static void Main(string[] args)
       {
            Hashtable hashtable = new Hashtable();

            hashtable.Add("Name","Dan");
            hashtable.Add("Age", 25);
            hashtable.Add("IsStudent", false);
           // hashtable.Add("Gender", "Male");

            Console.WriteLine($"Name:{hashtable["Name"]}");
            Console.WriteLine($"Age:{hashtable["Age"]}");
            Console.WriteLine($"IsStudent:{hashtable["IsStudent"]}");

            //hashtable["Age"] = 28;

            if (hashtable.ContainsKey("Gender"))
            {
                Console.WriteLine($"Gender:{hashtable["Gender"]}");
            }
            else
            {
                Console.WriteLine("Gender does not exist in the hashtable");
            }
            hashtable["Age"] = 28;

            Console.WriteLine("Hashtable Contents:");
            foreach (DictionaryEntry entry in hashtable)
            {
               Console.WriteLine($"{entry.Key}:{entry.Value}");
            }
            
         
       }
    }
 }
