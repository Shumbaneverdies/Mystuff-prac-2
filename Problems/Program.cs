using System;

namespace Problems
{
        public class Program
    {
        static void Main(string[] args)
        {
           

            string Prefix (string input)
            {
                   if(input=="")
                {
                    return "0,0:";
                }
                string output; 
                int length = input.Length;
                int numofwords = (input.Split(' ')).Length;
                
                output = $"{length},{numofwords}:{input}";
                
            
                return  output;
                
            }
            Prefix("hello");
        }
      
       public string Prefix(string v)
        {
            
               if(v=="")
                {
                    return "0,0:";
                }
                
                string output; 
                int length = v.Length;
                int numofwords = (v.Split()).Length;
                
                output = $"{length},{numofwords}:{v}";
             
                return  output;
                
            
           
        }
     
    }
}
