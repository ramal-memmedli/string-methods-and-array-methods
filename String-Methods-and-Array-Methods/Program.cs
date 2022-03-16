using System;

namespace String_Methods_and_Array_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        #region Trim
        public static string NewTrimStart(string inputString)
        {
            return NewTrimStart(inputString, ' ');
        }
        public static string NewTrimStart(string inputString, char inputChar)
        {
            string newString = "";
            int startIndex = 0;


            if (inputString[0] == ' ')
            {
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (inputString[i] == ' ')
                    {
                    }
                    else
                    {
                        startIndex = i;
                        break;
                    }
                }
            }
            else if (inputString[0] == inputChar)
            {
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (inputString[i] == inputChar)
                    {
                    }
                    else
                    {
                        startIndex = i;
                        break;
                    }
                }
            }

            for (int i = startIndex; i < inputString.Length; i++)
            {
                newString += inputString[i];
            }
            return newString;
        }
        public static string NewTrimEnd(string inputString)
        {
            return NewTrimEnd(inputString, ' ');
        }
        public static string NewTrimEnd(string inputString, char inputChar)
        {
            string newString = "";
            int endIndex = 0;

            if (inputString[inputString.Length - 1] == ' ')
            {
                for (int i = inputString.Length - 1; i >= 0; i--)
                {
                    if (inputString[i] == ' ')
                    {
                    }
                    else
                    {
                        endIndex = i;
                        break;
                    }
                }
            }
            else if (inputString[inputString.Length - 1] == inputChar)
            {
                for (int i = inputString.Length - 1; i >= 0; i--)
                {
                    if (inputString[i] == inputChar)
                    {
                    }
                    else
                    {
                        endIndex = i;
                        break;
                    }
                }
            }

            for (int i = 0; i <= endIndex; i++)
            {
                newString += inputString[i];
            }
            return newString;
        }
        public static string NewTrim(string inputString)
        {
            return NewTrim(inputString, ' ');
        }
        public static string NewTrim(string inputString, char inputChar)
        {
            string firstStep = NewTrimStart(inputString, inputChar);
            string result = NewTrimEnd(firstStep, inputChar);
            return result;
        }
        #endregion
        #region IndexOf
        public static int NewIndexOf(string inputString, char inputChar, int startIndex = 0)
        {
            int index = 0;
            for (int i = startIndex; i < inputString.Length; i++)
            {
                if(inputString[i] == inputChar)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public static int NewIndexOf(string inputString, string inputIndexString, int startIndex = 0)
        {
            int index = 0;
            int indexOfString = 0;
            int counter = 0;

            for (int i = startIndex; i < inputString.Length - inputIndexString.Length + 1; i++)
            {
                for (int j = 0; j < inputIndexString.Length; j++)
                {
                    if (inputString[i] == inputIndexString[j])
                    {
                        if (inputIndexString[inputIndexString.Length - 1] == inputString[i + (inputIndexString.Length - 1)])
                        {
                            for (int z = i; z < i + inputIndexString.Length; z++)
                            {
                                if (inputString[z] == inputIndexString[j])
                                {
                                    counter++;
                                }
                                else
                                {
                                    indexOfString = counter;
                                    break;
                                }
                                j++;
                            }
                            indexOfString = i;
                        }
                    }
                }
            }
            if (counter == inputIndexString.Length)
            {
                index = indexOfString;
            }
            else
            {
                index = -1;
            }
            return index;
        }

        public static int NewLastIndexOf(string inputString, char inputChar)
        {
            int index = 0;
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                if (inputString[i] == inputChar)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public static int NewLastIndexOf(string inputString, string inputIndexString)
        {
            int index = 0;
            int indexOfString = 0;
            int counter = 0;


            for (int i = inputString.Length - inputIndexString.Length; i >= 0 ; i--)
            {
                for (int j = 0; j < inputIndexString.Length; j++)
                {
                    if (inputString[i] == inputIndexString[j])
                    {
                        if (inputIndexString[inputIndexString.Length - 1] == inputString[i + (inputIndexString.Length - 1)])
                        {
                            for (int z = i; z < i + inputIndexString.Length; z++)
                            {
                                if (inputString[z] == inputIndexString[j])
                                {
                                    counter++;
                                }
                                else
                                {
                                    break;
                                }
                                j++;
                            }
                            indexOfString = i;
                        }
                    }
                    if(inputIndexString.Length == counter)
                    {
                        break;
                    }
                }
                if (inputIndexString.Length == counter)
                {
                    break;
                }
            }
            if (counter == inputIndexString.Length)
            {
                index = indexOfString;
            }
            else
            {
                index = -1;
            }
            return index;
        }
        #endregion
        #region Contains
        public static bool NewContains(string inputString, char inputChar)
        {
            bool checkChar = false;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == inputChar)
                {
                    checkChar = true;
                    break;
                }
                else
                {
                    checkChar = false;
                }
            }
            return checkChar;
        }
        public static bool NewContains(string inputString, string containsString)
        {
            bool checkString = false;
            for (int i = 0; i < inputString.Length - containsString.Length + 1; i++)
            {
                for (int j = 0; j < containsString.Length; j++)
                {
                    if(inputString[i] == containsString[j])
                    {
                        if (containsString[containsString.Length - 1] == inputString[i + (containsString.Length - 1)])
                        {
                            for (int z = i; z < i + containsString.Length; z++)
                            {
                                if (inputString[z] == containsString[j])
                                {
                                    checkString = true;
                                }
                                else
                                {
                                    checkString = false;
                                    break;
                                }
                                j++;
                            }
                        }
                    }
                }
            }
            return checkString;
        }
        #endregion
    }
}
