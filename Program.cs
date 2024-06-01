namespace AnimatedText
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Alphabet alphabet = new Alphabet(); // Create an instance of the Alphabet class
            Console.WriteLine("Input your sentance:");
            string Text = Console.ReadLine();
            alphabet.EndlessPrinter(Text); 
        }
    }

    internal class Alphabet // class with Alphabet <List> creation
    {
        public List<char> Letters { get; private set; }

        public Alphabet()
        {
            Letters = new List<char>(); // creation of <List>
            AlphabetBuilder();
        }

        public void AlphabetBuilder() // add letters in alphabetical order in list
        {
            int i = 0;
            Letters.Add(' '); // adding one 'space' to <List>
            do
            {
                for (char c = 'a'; c <= 'z'; c++) // adding small letters to <List>
                {
                    Letters.Add(c); 
                }
                i++;
            } while (i < 2); // make so 2 times in row
            i = 0;
            do
            {
                for (char C = 'A'; C <= 'Z'; C++) // adding CAPITAL letters to <List>
                {
                    Letters.Add(C);
                }
                i++;
            } while (i < 2); // make so 2 times in row
        }

        public void EndlessPrinter(string Text)
        {
            List<char> TempLetters = new List<char> { }; // buffer list, used for animation purpise only
            Random random = new Random();
            int length = Text.Length;
            int j = length;
            do
            {
                TempLetters.Add(' '); // add blank spaces in <List> to make it match lenght with users input
                j--;
            } while (j != 0);

            for (int i = 0; i < 125; i++) // amount of cicles
            {
                int pluscn = 0;
                do
                {
                    int count = random.Next(0, Letters.Count - 1);
                    TempLetters[pluscn] = Letters[count]; // addint random letter from <Letters> to <TempLetters>
                    pluscn++;
                } while (pluscn != length);
                Console.Clear(); // clearing all text
                Console.SetCursorPosition(0, 0); // cursor sent in upper-left position
                string convert = string.Concat(TempLetters); // convert <TempLetters> chars in string
                Console.WriteLine(convert); // showing string
                Thread.Sleep(15);
            }
            Console.Clear();
            Console.WriteLine(Text);

            //foreach (char c in Letters)
            //{
            //    Console.WriteLine(count + " == " + c + " "); // debug purpose only, print all <List>
            //    count++;
            //}
        }
    }
}