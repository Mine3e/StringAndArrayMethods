using System.Text.RegularExpressions;

namespace StringAndArrayMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilteredString("salam,   dunya");

            Console.WriteLine(Check("123Sagol"));
           
            Console.WriteLine(FirstWord("salam  dunya"));

            int[] array = { 1,2, 3, 4 };
            AddValue(ref array,5) ;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine(CheckWords("Salam  Sagol  Filan"));

        }

        #region 1
        public static void FilteredString( string str)
        {   
            bool chech = false;
            string newstr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' )
                {
                    if (!chech)
                    {
                        continue;
                    }
                    else
                    {
                        newstr += ' ';
                        chech = false;
                    }

                }
                else
                {
                    newstr += str[i];
                    chech = true;
                }
                
            }
            Console.WriteLine(newstr);

        }
        #endregion

        #region 2 
        public static bool Check(string str)
        {
            bool cdigit = false;
            bool clower=false;
            bool cupper=false;
            for (int i =0; i < str.Length; i++)
            {
                if (str[i]>= '0' && str[i]<='9') { 
                    cdigit = true;
                }
                else if (str[i]>= 'a' && str[i]<='z')
                {
                    clower = true;
                }
                else if (str[i]>= 'A' && str[i]<='Z')
                {
                    cupper = true;
                }
                if (cdigit && clower && cupper)
                {
                    break;
                }
            }
            
            return cdigit && clower && cupper;
        }
        #endregion

        #region 3
        public static string FirstWord(string str)
        {
            string newstr = "";
            bool check=false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] ==' ')
                {
                    if (!check)
                    {
                        continue;
                    }
                    else 
                    {
                        break;
                    }
                }
                else
                {
                    newstr += str[i];
                    check = true;
                }
            }
            return newstr;
        }
        #endregion


        #region 4
        public static bool CheckWords(string str)
        {
            bool first = false;
            bool second = false;
            int wordCount = 0;
            bool isSpace = true;
            for (int i = 0;i < str.Length;i++)
            {
                if ((str[i] >= 'A'&& str[i]<='Z') || (str[i]>='a' && str[i] <= 'z'))
                {
                    if (isSpace)
                    {
                        wordCount++;
                        isSpace = false;
                        if (wordCount == 1)
                        {
                            first= IsUpper(str[i]);
                        }
                        else if (wordCount == 2)
                        {
                            second = IsUpper(str[i]);
                        }
                    }
                }
                else if (str[i] ==' ')
                {
                    isSpace= true;
                }
            }
            return wordCount == 2 && first && second;
        }
        static bool IsUpper(char c)
        {
            return c >= 'A' && c <= 'Z';
        }
        #endregion

        #region 5
        public static void AddValue(ref int[] array, int value)
        {
            int [] arr = new int [array.Length+1];
            for (int i = 0;i < array.Length;i++)
            {
                arr[i] = array[i];
                
            }
            arr[arr.Length-1] = value;
            array = arr;
            
        }
        #endregion

    }
}
