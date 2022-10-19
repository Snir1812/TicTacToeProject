using System;

namespace MyApp //Project-X_O
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello , welcome to tic tac toe game");

            //Player 1

            string player1Name;
            while (true)//לולאה מגדירה שם של שחקן ראשון
            {
                Console.WriteLine("You are player 1 , please enter your name");
                player1Name = Console.ReadLine();
                if (player1Name.Length <= 0)
                {
                    Console.WriteLine("We have a problem with your name , please try again");
                    continue;
                }
                else
                {
                    break;
                }
            }

            char player1Type, player2Type;

            while (true)//לולאה שמגדירה את הסימן של השחקן הראשון
            {
                Console.WriteLine("Hey '{0}' , Please enter your type (X/O)", player1Name);
                player1Type = char.Parse(Console.ReadLine());
                if (player1Type == 'x' || player1Type == 'o' || player1Type == 'X' || player1Type == 'O')
                {
                    player1Type = char.ToUpper(player1Type);
                    Console.WriteLine("Thank you '{0}' , your type is '{1}'", player1Name, player1Type);
                    if ((player1Type == 'x' || player1Type == 'X'))//לולאה שנותנת את הסימן השני לשחקן השני כי השחקן הראשון כבר בחר סימן
                    {
                        player2Type = 'O';
                    }
                    else
                    {
                        player2Type = 'X';
                    }
                    break;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("****************");

            //-------------------------
            //Player 2

            string player2Name;
            while (true)//לולאה שמגדירה שם לשחקן השני ומודיעה לו איזה סימן הוא
            {
                Console.WriteLine("You are player 2 , please enter your name");
                player2Name = Console.ReadLine();
                if (player2Name.Length <= 0 || player2Name == player1Name)
                {
                    Console.WriteLine("We have a problem with your name , please try again");
                    continue;
                }
                else
                {
                    //Console.WriteLine("Hey '{0}' , your type '{1}' because the second type is caught by '{2}'", player2Name, player2Type, player1Name);
                    break;
                }

            }

            //-------------------------
            //דיווח על שמות וסימנים וניקוי הטרמינל 

            Console.Clear();
            Console.WriteLine("{0} your type is {1}", player1Name, player1Type);
            Console.WriteLine("{0} your type is {1}", player2Name, player2Type);
            //Console.WriteLine("To start the game press enter");
            //Console.ReadLine();
            Console.Clear();

            //-------------------------
            //התחלת המשחק

            char start;

            while (true)
            {
                Console.WriteLine("Do you want to start a game ? (Y/N)");
                start = Char.Parse(Console.ReadLine());
                if (start == 'Y' || start == 'y')
                {
                    char A = '1';
                    char B = '2';
                    char C = '3';
                    char D = '4';
                    char E = '5';
                    char F = '6';
                    char G = '7';
                    char H = '8';
                    char I = '9';
                    char selection;
                    int currect = 0;
                    int i = 0;

                    while (true)
                    {
                        if (currect == 0)
                        {
                            if (i % 2 == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("*************");
                                Console.WriteLine("| {0} | {1} | {2} |", A, B, C);
                                Console.WriteLine("+---+---+---+");
                                Console.WriteLine("| {0} | {1} | {2} |", D, E, F);
                                Console.WriteLine("+---+---+---+");
                                Console.WriteLine("| {0} | {1} | {2} |", G, H, I);
                                Console.WriteLine("*************");
                                Console.WriteLine("");
                                Console.WriteLine("{0} is your turn", player1Name);
                                Console.WriteLine("");
                                selection = char.Parse(Console.ReadLine());

                                if (selection == '1' && A == '1')
                                {
                                    A = player1Type;
                                }
                                else if (selection == '2' && B == '2')
                                {
                                    B = player1Type;
                                }
                                else if (selection == '3' && C == '3')
                                {
                                    C = player1Type;
                                }
                                else if (selection == '4' && D == '4')
                                {
                                    D = player1Type;
                                }
                                else if (selection == '5' && E == '5')
                                {
                                    E = player1Type;
                                }
                                else if (selection == '6' && F == '6')
                                {
                                    F = player1Type;
                                }
                                else if (selection == '7' && G == '7')
                                {
                                    G = player1Type;
                                }
                                else if (selection == '8' && H == '8')
                                {
                                    H = player1Type;
                                }
                                else if (selection == '9' && I == '9')
                                {
                                    I = player1Type;
                                }
                                else if ((selection != '1') && (selection != '2') && (selection != '3') && (selection != '4') && (selection != '5') && (selection != '6') && (selection != '7') && (selection != '8') && (selection != '9'))
                                {
                                    Console.WriteLine("{0} You didn't enter a valid number and you lost your turn", player1Name);
                                    Console.ReadLine();
                                }

                                checkWin(player1Type, player2Type, A, B, C, D, E, F, G, H, I, player1Name
            , player2Name, ref currect, i);

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("*************");
                                Console.WriteLine("| {0} | {1} | {2} |", A, B, C);
                                Console.WriteLine("+---+---+---+");
                                Console.WriteLine("| {0} | {1} | {2} |", D, E, F);
                                Console.WriteLine("+---+---+---+");
                                Console.WriteLine("| {0} | {1} | {2} |", G, H, I);
                                Console.WriteLine("*************");
                                Console.WriteLine("");
                                Console.WriteLine("{0} is your turn", player2Name);
                                Console.WriteLine("");
                                selection = char.Parse(Console.ReadLine());

                                if (selection == '1' && A == '1')
                                {
                                    A = player2Type;
                                }
                                else if (selection == '2' && B == '2')
                                {
                                    B = player2Type;
                                }
                                else if (selection == '3' && C == '3')
                                {
                                    C = player2Type;
                                }
                                else if (selection == '4' && D == '4')
                                {
                                    D = player2Type;
                                }
                                else if (selection == '5' && E == '5')
                                {
                                    E = player2Type;
                                }
                                else if (selection == '6' && F == '6')
                                {
                                    F = player2Type;
                                }
                                else if (selection == '7' && G == '7')
                                {
                                    G = player2Type;
                                }
                                else if (selection == '8' && H == '8')
                                {
                                    H = player2Type;
                                }
                                else if (selection == '9' && I == '9')
                                {
                                    I = player2Type;
                                }
                                else if ((selection != '1') && (selection != '2') && (selection != '3') && (selection != '4') && (selection != '5') && (selection != '6') && (selection != '7') && (selection != '8') && (selection != '9'))
                                {
                                    Console.WriteLine("{0} You didn't enter a valid number and you lost your turn", player2Name);
                                    Console.ReadLine();
                                }

                                checkWin(player1Type, player2Type, A, B, C, D, E, F, G, H, I, player1Name
            , player2Name, ref currect, i);

                            }

                            i++;
                            continue;

                        }
                        else if (currect == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("draw");
                            break;
                        }
                        else
                        {

                            Console.Clear();
                            checkWin(player1Type, player2Type, A, B, C, D, E, F, G, H, I, player1Name
           , player2Name, ref currect, i);
                            break;

                        }
                    }
                    continue;
                }
                else if (start == 'N' || start == 'n')
                {
                    Console.Clear();
                    Console.WriteLine("Ok , thank you");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Error");
                    continue;
                }
            }



            //----end code
            Console.ReadLine();
        }

        static void checkWin(char player1Type, char player2Type, char A, char B, char C, char D, char E, char F, char G, char H, char I, string player1Name
, string player2Name, ref int currect, int i
)
        {
            if (((player1Type == A) && (player1Type == B) && (player1Type == C)) || ((player1Type == D) && (player1Type == E) && (player1Type == F)) || ((player1Type == G) && (player1Type == H) && (player1Type == I)) || ((player1Type == A) && (player1Type == D) && (player1Type == G)) || ((player1Type == B) && (player1Type == E) && (player1Type == H)) || ((player1Type == C) && (player1Type == F) && (player1Type == I)) || ((player1Type == A) && (player1Type == E) && (player1Type == I)) || ((player1Type == C) && (player1Type == E) && (player1Type == G)))
            {
                Console.WriteLine("{0} Win!!!!!!!", player1Name);
                currect++;
            }
            else if (((player2Type == A) && (player2Type == B) && (player2Type == C)) || ((player2Type == D) && (player2Type == E) && (player2Type == F)) || ((player2Type == G) && (player2Type == H) && (player2Type == I)) || ((player2Type == A) && (player2Type == D) && (player2Type == G)) || ((player2Type == B) && (player2Type == E) && (player2Type == H)) || ((player2Type == C) && (player2Type == F) && (player2Type == I)) || ((player2Type == A) && (player2Type == E) && (player2Type == I)) || ((player2Type == C) && (player2Type == E) && (player2Type == G)))
            {
                Console.WriteLine("{0} Win!!!!!!!", player2Name);
                currect++;
            }
            else if (i == 8)
            {
                currect = 2;
            }
        }
    }
}
