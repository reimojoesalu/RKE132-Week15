
List<Movie> myMovies = new List<Movie>();
string[] data = GetDataFromFile();
//ReadDataFromArry(data);

foreach(string line in data)
{
    string[] temArry = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
   
    Movie newMovie = new Movie(tempArray[0], temArry[2]);
    myMovies.Add(newMovie);
}

foreach(Movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was released in {movie.Year}.");
}




static string[] GetDataFromFile()
{
    string filePath = @"C:\Users\reimo\source\repos\Week13SQLiteD8";
    return File.ReadAllLines(filePath);

}

static void ReadDataFromArry(string[] someArry)
{
    foreach(string line in someArry)
    {
        Console.WriteLine(line);
    }
}


class Movie
{
    string title; //fields
    string year;

    public string Title
    {
        get { return title; }

    public string Year
    {
        get { return year; }
        

    public Movie(string _title, string _year)
    {
        title = _title;
        year = _year;
    }
}