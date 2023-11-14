using System;
using Org.Mentalis.Utilities;

class TestApp {
	static void Main(string[] args) {
		// create a new StopWatch
		StopWatch s = new StopWatch();
		// when we create a StopWatch, Reset() is automatically called,
		// so we do not need to do that again.
		int j = 0;
		for(int i = 0; i < 10000000; i++) {
			j++;
		}
		// print out the results
		Console.WriteLine("Your system took " + (s.Peek() / (float)10).ToString() + " milliseconds to process the loop.");
		// Make sure the users gets a chance to read the output
		Console.WriteLine("Press enter to continue...");
		Console.ReadLine();
	}
}