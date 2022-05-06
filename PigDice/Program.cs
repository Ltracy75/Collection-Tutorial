using PigDice;  

var pigdice = new PigDiceGame();

const int highScore = 1200;

long game = 0;

var score = pigdice.Play();

var max = 0;

while (score < highScore)
    {
    game++;
    if (game % 100000000 == 0)
        {
        Console.WriteLine($"Nbr of games so far is {game:n0} and highscore is {max}");
        }
    if (score > max) 
        {
        max = score;
        Console.WriteLine(max);
        }
     score = pigdice.Play();
    }

Console.WriteLine(score);