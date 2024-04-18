using Module2CodingChallenge;

//create a new polygon and a new square object
Polygon polygon = new Polygon(3); //a triangle
Square square = new Square(4.5f); //a square
Hexagon hexagon = new Hexagon(4.2f); //a hexagon with side legnth

//Create a new player with one life and add points toe the player's score
Player player = new Player("Frankenstein", 1);
player.AddPoints(100);

//Display the player's score
Console.WriteLine("Welcome to the game! Your score is: " + player.GetScore() + " You have " 
    + player.GetLivesLeft() + " lives left!");

//Kill off the player's character
player.Kill();

//Let the player know their character was killed
Console.WriteLine("An orc attacks you. Sorry, you were killed. You have " 
    + player.GetLivesLeft() + " lives left!");