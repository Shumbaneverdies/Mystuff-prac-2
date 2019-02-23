using System;

namespace Problems
{
        public class Program
    {
        static void Main(string[] args)
        {
           

            string Prefix (string input)
            {
                
                string output; 
                int length = input.Length;
                int numofwords = (input.Split(' ')).Length;
                
                
                if(input==null)
                {
                    return output = "0,0:";
                }
                else
                {
                    output = $"{length},{numofwords}:{input}";
                }
               
                return  output;
                
            }
            Prefix("hello");
        }

        public string Prefix(string v)
        {
            
            
                string output; 
                int length = v.Length;
                int numofwords = (v.Split(' ')).Length;
                
                
                if(v==null)
                {
                    return output = "0,0:";
                }
                else
                {
                    output = $"{length},{numofwords}:{v}";
                }
               
                return  output;
                
           
        }
    }
}
