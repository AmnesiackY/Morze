using System.Collections.Generic;

namespace Morze
{
    class Transformation
    {
        public static Dictionary<string, string> encr_morze = new Dictionary<string, string>
            {
                { "a", ". -   " },
                { "b", "- . . .   " },
                { "c", "- . - .   " },
                { "d", "- . .   " },
                { "e", ".   " },
                { "f", ". . - .   " },
                { "g", "- - .   " },
                { "h", ". . . .   " },
                { "i", ". .   " },
                { "j", ". - - -   " },
                { "k", "- . -   " },
                { "l", ". - . .   " },
                { "m", "- -   " },
                { "n", "- .   " },
                { "o", "- - -   " },
                { "p", ". - - .   " },
                { "q", "- - . -   " },
                { "r", ". - .   " },
                { "s", ". . .   " },
                { "t", "- " },
                { "u", ". . -   " },
                { "v", ". . . -   " },
                { "w", ". - -   " },
                { "x", "- . . -   " },
                { "y", "- . - -   " },
                { "z", "- - . .   " },
                { " ","      " }
            };
        public static Dictionary<char, string> time_units = new Dictionary<char, string>
        {
            { '.', "11" },
            { '-', "111111" },
            { ' ' , "00" }
        };

    }
}
