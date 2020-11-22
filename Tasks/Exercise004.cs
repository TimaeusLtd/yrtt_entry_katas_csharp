using System;

// Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
// Leave punctuation marks untouched.

namespace TechReturners.Tasks
{
    public class Exercise004
    {
        public static string PigIt(string str)
    {
            string[] words = str.Split(' ');
            string[] ammendedWords = new string[words.Length];            
            string wordAmended;            

            for(int i=0; i<words.Length; i++){                

                wordAmended = words[i].Substring(GetWordFirstLetter(words[i]));

                if(!char.IsPunctuation(words[i], 0)){
                    
                    wordAmended = wordAmended.Insert(GetLetterShift(words[i]), words[i].Substring(0,1));                    
                }

                if(GetLetterShift(words[i]) == words[i].Length-1){

                    wordAmended = $"{wordAmended}ay";                   
                }
                else
                {
                    wordAmended = wordAmended.Insert(GetLetterShift(wordAmended)+1, "ay");
                }              

                ammendedWords[i] = wordAmended;
            }

            return String.Join(" ", ammendedWords);
        }
        private static int GetWordFirstLetter(string word){

            int stringPositon = 1;

            if(char.IsPunctuation(Convert.ToChar(word.Substring(0,1)))){
                stringPositon = 0;
            }

            return stringPositon;
        }

        private static int GetLetterShift(string word){

            int stringPositon = word.Length-1;            

            for(int i = (word.Length-1); i > -1; i--){

                if(!char.IsPunctuation(word, i)){
                    stringPositon = i;
                    break;
                }
            }      

            return stringPositon;
        }
    }
}

