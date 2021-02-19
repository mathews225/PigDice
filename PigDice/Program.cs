using System;

namespace PigDice {
	class Program {

		// Rules: Roll a die and add the amount to the running score. Turn continues until a 1 is rolled.
		
			static int RollDie() {
			var rand = new Random();
			return rand.Next(1, 7);
		}
		static int PlayPigDice() {
			var score = 0;
			var roll = RollDie();
			while (roll != 1) {
				score += roll;
				roll = RollDie();
			}
			return score;

		}

		static void Main(string[] args) {

			var hiscore = 0;

			for (int i = 0; i < 1000000; i++) {
				var score = PlayPigDice();
				if (score > hiscore) {
					hiscore = score;
				}
			}
			Console.WriteLine($"Score = {hiscore}");

			//var score = PlayPigDice();
			//Console.WriteLine($"Score = {score}");

		}


	}
}
