using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Maker
{
    public class ChangeParams
    {
        private static string[] letters = new string[27]
        {
            "e","f","g","h","i","j","k","l","m","a","b","c","d","n","o","p","q","r","s","t","r","u","v","w","x","y","z"
        };

        private static string[] Bigletters = new string[27]
        {
            "F","G","S","T","U","V","W","A","B","C","D","E","X","Y","Z","H","I","J","K","L","M","N","O","P","Q","R","W"
        };

        private static string[] Character = new string[27]
        {
            "/",@"\","!","@","#","$","%","^","&","*","(","]","}","|","?",">",")","-","_","=","+","{","[","<" ,".","~","`"
        };
        private static string[] numbers = new string[27]
        {
            "1","9","1","4","2,","5","3","5","5","0","4","9","5","0","2","4","5","6","9","1","8","5","6","7","8","1","0"
        };
        public static string Change(string param)
        {
            string hashparam = "";

            int paramlen = param.Length;
            for (int i = 0; i < paramlen; i++)
            {

                if (paramlen == 27)
                {
                    switch (param[i])
                    {
                        case 'a':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'b':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'c':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'd':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'e':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'f':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'g':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'h':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'i':
                            {
                                hashparam += letters[i].ToString().ToUpper();
                                break;
                            }
                        case 'j':
                            {
                                hashparam += Character[i] ;
                                break;
                            }
                        case 'k':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'l':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'm':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'n':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'o':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'p':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'q':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'r':
                            {
                                hashparam += letters[i].ToUpper();
                                break;
                            }
                        case 's':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 't':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'u':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'v':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'w':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'x':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'y':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'z':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }

                        case 'A':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'B':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'C':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'D':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'E':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'F':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'G':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'H':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'I':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'J':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'K':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'L':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'M':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'N':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'O':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'P':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'Q':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'R':
                            {
                                hashparam += numbers[i] + " ";
                                break;
                            }
                        case 'S':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'T':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'U':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'V':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'W':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'X':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'Y':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'Z':
                            {
                                hashparam += letters[i].ToUpper();
                                break;
                            }
                        case ' ':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case '0':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '1':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '2':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case '3':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case '4':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '5':
                            {
                                hashparam += Bigletters[i].ToLower();
                                break;
                            }
                        case '6':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '7':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '8':
                            {
                                hashparam += letters[i].ToUpper();
                                break;
                            }
                        case '9':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }

                        case '`':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '@':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '#':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '$':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '%':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '^':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case '&':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '*':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '(':
                            {
                                hashparam += Bigletters[i].ToLower();
                                break;
                            }
                        case ')':
                            {
                                hashparam += letters[i].ToUpper();
                                break;
                            }
                        case '_':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '-':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '=':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case '+':
                            {
                                hashparam += letters[i];
                                break;
                            }

                        case '[':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case ']':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '{':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '}':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case '/':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '?':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case '>':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '<':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                    }
                }
                else if (paramlen >= 21)
                {
                    switch (param[i])
                    {
                        case 'a':
                            {
                                hashparam +=
                                             numbers[i];
                                break;
                            }
                        case 'b':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'c':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'd':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'e':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'f':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'g':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'h':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'i':
                            {
                                hashparam += letters[i].ToString().ToUpper();
                                break;
                            }
                        case 'j':
                            {
                                hashparam += Character[i] + "/";
                                break;
                            }
                        case 'k':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'l':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'm':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'n':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'o':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'p':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'q':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'r':
                            {
                                hashparam += Bigletters[i].ToLower();
                                break;
                            }
                        case 's':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 't':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'u':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'v':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'w':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'x':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'y':
                            {
                                hashparam += letters[i] + "?";
                                break;
                            }
                        case 'z':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }

                        case 'A':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'B':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'C':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'D':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'E':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'F':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'G':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'H':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'I':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'J':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'K':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'L':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'M':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'N':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'O':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'P':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'Q':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'R':
                            {
                                hashparam += numbers[i] + " ";
                                break;
                            }
                        case 'S':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'T':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'U':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'V':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'W':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'X':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'Y':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'Z':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case ' ':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '0':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '1':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '2':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case '3':
                            {
                                hashparam += Character[i] + letters[i];
                                break;
                            }
                        case '4':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '5':
                            {
                                hashparam += Bigletters[i].ToLower();
                                break;
                            }
                        case '6':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '7':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '8':
                            {
                                hashparam += letters[i].ToUpper();
                                break;
                            }
                        case '9':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }

                        case '`':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '@':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '#':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '$':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '%':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case '^':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '&':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '*':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '(':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case ')':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case '_':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '-':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '=':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case '+':
                            {
                                hashparam += letters[i];
                                break;
                            }

                        case '[':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case ']':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '{':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '}':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case '/':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '?':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case '>':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '<':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                    }
                }
                else if (paramlen >= 10)
                {
                    switch (param[i])
                    {
                        case 'a':
                            {
                                hashparam +=
                                             numbers[i];
                                break;
                            }
                        case 'b':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'c':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'd':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'e':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'f':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'g':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'h':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'i':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'j':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'k':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'l':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'm':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'n':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'o':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'p':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'q':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'r':
                            {
                                hashparam += letters[i].ToUpper();
                                break;
                            }
                        case 's':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 't':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'u':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'v':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'w':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'x':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'y':
                            {
                                hashparam += letters[i] + "?";
                                break;
                            }
                        case 'z':
                            {
                                hashparam += Character[i];
                                break;
                            }

                        case 'A':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'B':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'C':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'D':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'E':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'F':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'G':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'H':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'I':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'J':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'K':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'L':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'M':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'N':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'O':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'P':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'Q':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'R':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'S':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'T':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'U':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'V':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'W':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'X':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'Y':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'Z':
                            {
                                hashparam += letters[i].ToUpper();
                                break;
                            }
                        case ' ':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case '0':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '1':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '2':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '3':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '4':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case '5':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case '6':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case '7':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '8':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case '9':
                            {
                                hashparam += letters[i];
                                break;
                            }

                        case '`':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case '@':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '#':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case '$':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '%':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case '^':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '&':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '*':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '(':
                            {
                                hashparam += Bigletters[i].ToLower();
                                break;
                            }
                        case ')':
                            {
                                hashparam += letters[i].ToUpper();
                                break;
                            }
                        case '_':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '-':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '=':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case '+':
                            {
                                hashparam += letters[i];
                                break;
                            }

                        case '[':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case ']':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '{':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '}':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case '/':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '?':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case '>':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '<':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                    }
                }
                else if (paramlen <= 10)
                {
                    switch (param[i])
                    {
                        case 'a':
                            {
                                hashparam +=
                                             numbers[i];
                                break;
                            }
                        case 'b':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'c':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'd':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'e':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'f':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'g':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'h':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'i':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'j':
                            {
                                hashparam += Character[i] + "/";
                                break;
                            }
                        case 'k':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'l':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'm':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'n':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'o':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'p':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'q':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'r':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 's':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 't':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'u':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'v':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'w':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'x':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'y':
                            {
                                hashparam += letters[i] + "?";
                                break;
                            }
                        case 'z':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }

                        case 'A':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'B':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'C':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'D':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'E':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'F':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'G':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'H':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'I':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'J':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'K':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'L':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'M':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'N':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'O':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'P':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'Q':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'R':
                            {
                                hashparam += numbers[i] + " ";
                                break;
                            }
                        case 'S':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'T':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'U':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'V':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case 'W':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case 'X':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case 'Y':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case 'Z':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case ' ':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '0':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '1':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '2':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case '3':
                            {
                                hashparam += Character[i];
                                break;
                            }
                        case '4':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '5':
                            {
                                hashparam += Bigletters[i].ToLower();
                                break;
                            }
                        case '6':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '7':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '8':
                            {
                                hashparam += letters[i].ToUpper();
                                break;
                            }
                        case '9':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }

                        case '`':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '@':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '#':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '$':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '%':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '^':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case '&':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '*':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '(':
                            {
                                hashparam += Bigletters[i].ToLower();
                                break;
                            }
                        case ')':
                            {
                                hashparam += letters[i].ToUpper();
                                break;
                            }
                        case '_':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '-':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '=':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '+':
                            {
                                hashparam += numbers[i];
                                break;
                            }

                        case '[':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case ']':
                            {
                                hashparam += letters[i];
                                break;
                            }
                        case '{':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '}':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '/':
                            {
                                hashparam += Bigletters[i];
                                break;
                            }
                        case '?':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case '>':
                            {
                                hashparam += numbers[i];
                                break;
                            }
                        case '<':
                            {
                                hashparam += Character[i];
                                break;
                            }
                    }
                }
            }

            return hashparam;
        }
    }
}
