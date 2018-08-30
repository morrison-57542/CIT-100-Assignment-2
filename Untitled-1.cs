using System;

public class Legolas
{
	public static void Main()
	{
        
		int arrows = 3;
		int enemies = 3;
		int percent = 0;
		bool LeglasLives = false;

		for(int numberOfArrows = 1; numberOfArrows <= 3; numberOfArrows++)
		{
			arrows--;
			enemies--;

			Console.WriteLine("How many enemies are left?" + enemies);
			if(enemies == 0) {
			LeglasLives=true;
		}else{
            LeglasLives=false;
        }
		}
        if (LeglasLives){
            Console.WriteLine("Leglas Lives");
        }else{
            Console.WriteLine("Leglas Dies");
        }
	}
}