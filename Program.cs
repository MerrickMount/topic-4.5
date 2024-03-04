namespace topic_4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.WriteLine("This program is made for you to choose something to draw (Type the name of one and it will appear), here are your options:");
            Console.WriteLine("CocaCola, Frog, Rat.");
            userInput = Console.ReadLine();
            
                if (userInput.ToLower() == "cocacola")
            {
                CocaCola();
            }
                else if (userInput.ToLower() == "frog")
            {
                Frog();
            }
                else if (userInput.ToLower() == "rat")
            {
                Rat();
            }
                else
            {
                Console.WriteLine("That is not a valid input");
            }
        }
        public static void CocaCola()
        {
            Console.WriteLine("          .e$.                           z$$e.d$$$.      z$b   z\r\n         d$’ .d                        .$$’ d’F ^*$$$e  z$’ $ .$\r\n       e$P   $%                       d$P .’  F    ‘$$’d$  .e$’\r\n      $$F                           .$$’  F  J       ‘$$z$$$’\r\n    .$$’   .$’3   .$’’  .$P $$  $$ 4$$’  $  4’       $$  .\r\n   .$$F   d$  4  d$ d$ z$’ J$%    4$$’   $.d’       $$  .’\r\n   $$P   $$ ‘.$z$$  ^ z$’ .$P    .$$F              $$’ .’\r\n  $$$   d$F  J $$F   z$$  $$ .   $$$   ze     .c  J$F z  .e.ze\r\n 4$$F   $$  4’ $$   z$$  $$’.’  d$$  d$’ $  z$’ $ $$ @  $$’.$F\r\n $$$   4$$.'’ 4$$ .$3$$.$$$e%   $$P J$P  P d$*  %$$$’  $$  $$\r\n $$$    $$*    $$$’ ^$$’'$$    4$$% $$’ . d$’ ‘$’$$   $$  $$\r\n $$$                           $$$  ‘   P4$P  z 4$F  $$’ J$% %\r\n '$$c          .e$$$$$$$$e     $$$F    $ $$  z’ $$  $$$ 4$$ P\r\n  ‘$$b.   .e$*’     ‘$$$$$$$   '$$$c.dP  $$$$’  $$$’$$$$$$$P\r\n    ‘*$$$*’           ‘          *$$*’   ‘$*    ‘$’ ^$* ‘$’\r\n");

        }
        static void Frog()
        {
            Console.WriteLine("            _     _\r\n           (')-=-(')\r\n         __(   \"   )__\r\n        / _/'-----'\\_ \\\r\n     ___\\\\ \\\\     // //___\r\n     >____)/_\\---/_\\(____<");
        }
        static void Rat()
        {
            Console.WriteLine("              ..----.._    _\r\n            .' .--.    \"-.(O)_\r\n'-.__.-'\"'=:|  ,  _)_ \\__ . c\\'-..\r\n             ''------'---''---'-\"\r\n");
        }
    }
}