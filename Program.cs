using System;
using System.Windows.Input;
namespace app__1
{
    class Program {
        static  int scor = 0;
        static string SNAKE_BODY = "$";
        static int WIDTH = 20;
        static int HEIGHT = 10;
        static string BORDER = "#";
        static string SPACE_BORDER = " ";
        static int positionX=3;
         static int positionY=4;
        static bool runGame = true;
        //random position fruit;
        static int randomPositionX;
        static int randomPositionY;

          static    bool generateRandomPosition = false;
       
        static void Main(string[] args)
        {
            HowToPlayGame();
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            point();
            Random rnd = new Random();
            string line;
            int value;
            
            while (runGame)
            {
                if (generateRandomPosition)
                {
                    randomPositionX = rnd.Next(2, 10);
                    randomPositionY = rnd.Next(2, 10);
                }
                generateRandomPosition = false;

                string input = Console.ReadLine();
                switch (input)
                {
                    case "d":
                        positionX++;
                        break;
                    case "s":
                        positionY++;
                        break;
                    case "a":
                        positionX--;
                        break;
                    case "w":
                        positionY--;
                        break;
                }
                point();
            }
            stopGame();
            

        }
        static void stopGame()
        {
            Console.WriteLine("YOU WIN THE GAME!!!!");
        }
        static void HowToPlayGame()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("you have w,a,s,d for control dollar, every time you press w/a/s/d you press enter\n dollar don't increase size only score\n collision is disable by default \n possible update will make effort to increase speed of the game \n v1.0 (open  beta) \n donate  paypal:mariusalexandru091@yahoo.com");

        }
static void point() {
            
    //bordura sus
    for (int i = 0; i < WIDTH + 2; i++) {
        Console.Write("#");
      
    }
            Console.Write($"      score: {scor}");
            Console.WriteLine();
            int lenghtSnake = 1;
    for (int i = 0; i < HEIGHT; i++) {
        Console.Write("#");
        for (int j = 0; j < WIDTH; j++) {
                      if ((j == randomPositionX) && (i == randomPositionY))
                    {
                        Console.Write("A");
                    }
                    
                    if ((j == positionX)&&(i==positionY))
                    {
                       for(int a = 1; a <=lenghtSnake; a++)
                        {
                            Console.Write(SNAKE_BODY);

                        }

                        if ((positionX == randomPositionX) && (positionY == randomPositionY)){
                            
                            generateRandomPosition = true;
                            scor = scor + 1;
                        }

                    }
                    else
                    {
                        Console.Write(SPACE_BORDER);
                    }
        }
        Console.Write(BORDER);
        Console.WriteLine();
                if (scor == 3)
                {
                    runGame = false;
                    Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
                    
                   
                }
    }
    //bordura jos
    for (int i = 0; i < WIDTH + 2; i++) {
        Console.Write("#");
    }
    Console.WriteLine();
   }
  }
}
  
