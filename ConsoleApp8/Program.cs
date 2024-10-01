// Guess number

int secret_number = 66;
int guess;
int guess_count = 0; // 猜測次數
int guess_limit = 3; // 猜測限制
bool win = false;

do
{
    System.Console.Write("Input a guess number: ");
    guess = System.Convert.ToInt32(System.Console.ReadLine());
    guess_count ++;

    if (guess > secret_number)
    {
        System.Console.WriteLine("Please input a small guess number");
    }
    else if (guess < secret_number)
    {
        System.Console.WriteLine("Please input a big guess number");
    }
    else
    {
        System.Console.WriteLine("Correct, you win!");
        win = true;
    }
}
while (guess!=secret_number && guess_count < guess_limit);

if (!win)
{
    System.Console.WriteLine("Sorry, you lose the game");
}