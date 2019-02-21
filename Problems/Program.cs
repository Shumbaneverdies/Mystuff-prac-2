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
        }
    }
}
