var frames = new List<int>();
// still need a  () as it initalizes it as a constructor
var rnd = new Random();

var Highscore = 300;

var total = 0;
long games = 0;


while (total < Highscore)
    {
    frames.Clear();
    total = 0;
    games++;

    for (int i = 1; i <= 10; i++)
        {
        var score = rnd.Next(31);
        frames.Add(score);
        }
    foreach (var frame in frames)
        {
        total = total + frame;
        }
    }
Console.WriteLine($"{total} took {games} took");
