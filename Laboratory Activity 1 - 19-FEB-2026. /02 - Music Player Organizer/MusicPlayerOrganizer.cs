using System;
using System.Globalization;
					
class Song{
	public string Title;
	public string Artist;
	public double Duration;
	
	public Song() : this("Unknown", "Unknown", 0.0){
	}
	
	public Song(string title, string artist, double duration){
		Title = title;
		Artist = artist;
		Duration = duration;
	}
	
	public Song(string title, string artist) : this(title, artist, 0.0){
	}
	
	
	public void DisplaySong(){
		Console.WriteLine("{0, -15} {1, -10} {2, 5:F2}", Title, Artist, Duration);
	}
	
	
}

class Program
{
	static void Main()
	{
		Console.Write("Songs to add: ");
		int n;
		
		if (!int.TryParse(Console.ReadLine(), out n) || n < 1)
		{
			n = 1;
		}
		
		Song[] playlist = new Song[n];
		
		for(int i = 0; i < n;i++)
		{
			Console.WriteLine($"\nSong #{i +1}");
			
			Console.Write("Title: ");
			string title = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(title)) title = "Unknown";
			
			Console.Write("Artist: ");
			string artist = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(artist)) artist = "Unknown";
	
			Console.Write("Duration (minutes): ");
			string durationInput = Console.ReadLine();
			double duration;
			if (!double.TryParse(durationInput, NumberStyles.Float, CultureInfo.InvariantCulture, out duration)){
				duration = 0.0;
			}
			
			playlist[i] = new Song(title, artist, duration);
			
		}
		Console.WriteLine("\n=== || MY PLAYLIST || ===");
		Console.WriteLine("{0, -15} {1, -10} {2, 5:F2}", "Title", "Artist", "Time");
		Console.WriteLine(new string('-', 40));
		
		double totalDuration = 0;
		
		foreach (Song s in playlist){
			s.DisplaySong();
			totalDuration += s.Duration;
		}
		double averageDuration = (n > 0) ? totalDuration / n : 0;
		
		Console.WriteLine("\nTotal Duration: {0:F2} mins", totalDuration);
		Console.WriteLine("Average Duration: {0:F2} mins", averageDuration);
	}
}