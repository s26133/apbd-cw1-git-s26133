class Program
{
    static void Main()
    {
        Random random = new Random();

        int liczba = random.Next(1, 11);

        if (liczba <= 8)
        {
            Console.WriteLine("Hello, you are a wonderful person!"); //wypisze sie 8 na 10 przypadków, losowo
            Console.WriteLine(@"
     .ooooo.
   .oP""   ""bo.
  oP'  ^   ^  `Yo
 oP'  (o) (o)  `Yo
oP'           `Yo
oP'   \___/   `Yo
oP'           `Yo
`Yo.         .oP'
 `Yo.       .oP'
   `""YoooooY""' ");
        }
        else if (liczba == 9)
        {
            Console.WriteLine("Hello, you are NOT a wonderful person!");
            Console.WriteLine(@"
      .ooooo.
   .oP""   ""bo.
  oP'       `Yo
 oP'  o   o  `Yo
oP'           `Yo
oP'  -------  `Yo
oP'           `Yo
`Yo.         .oP'
 `Yo.       .oP'
   `""YoooooY""'");

        }
        else if (liczba == 10)
        {
            Console.WriteLine("Hello, you are the worst!");
            Console.WriteLine(@"
      .ooooo.
   .oP""   ""bo.
  oP'  _   _  `Yo
 oP'  (o) (o)  `Yo
oP'      ^      `Yo
oP'    .---.    `Yo
oP'   /     \   `Yo
`Yo.         .oP'
 `Yo.       .oP'
   `""YoooooY""'");
        }
    }
}