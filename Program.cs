using System;
using dio_poo_filmes;

internal class Program
{
    static SeriesRepository repository = new SeriesRepository();
    private static void Main(string[] args)
    {
        string userOption = GetUserOption();

        while(userOption.ToUpper() !=  "X")
        {
            switch (userOption)
            {
                case "1":
                ListSeries();
                break;
                case "2":
                InsertSerie();
                break;
                case "3":
                UpdateSerie();
                break;
                case "4":
                DeletSerie();
                break;
                case "5":
                SelectSerie();
                break;
                case "C":
                Console.Clear();
                break;
                default:
                throw new ArgumentOutOfRangeException();
            }
            userOption = GetUserOption();
        }

        Console.WriteLine("Thank you!!!");
        Console.ReadLine();
    }

    private static void ListSeries()
    {
        Console.WriteLine("List series");
        var list = repository.List();
        if(list.Count == 0 )
        {
            Console.WriteLine("The list is empity.");
            return;
        }
        foreach(var serie in list)
        {
            var deleted = serie.getDeleted();
            if(!deleted)
            {
                Console.WriteLine("#Id: {0}: - {1}", serie.getId(), serie.getTittle());
            }
            
        }
    }

    private static void InsertSerie()
    {
        Console.WriteLine("Insert new serie");
        foreach (int i in Enum.GetValues(typeof(Genre)))
        {
            Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
        }

        Console.Write("Insert the genre: ");
			int idGenre = int.Parse(Console.ReadLine());

			Console.Write("Insert the serie tittle: ");
			string insertTittle = Console.ReadLine();

			Console.Write("Insert the sinopse: ");
			string insertSinopse = Console.ReadLine();

            Console.Write("Insert the release year: ");
			int insertYear = int.Parse(Console.ReadLine());

			Serie newSerie = new Serie(Id: repository.nextId(), Genre: (Genre)idGenre, Tittle: insertTittle, Sinopse: insertSinopse, ReleaseYear: insertYear);

			repository.Insert(newSerie);
    }

    private static void UpdateSerie()
		{
			Console.Write("Insert the serie id: ");
			int idSerie = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Genre)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
			}
			Console.Write("Insert the genre: ");
			int insertGenre = int.Parse(Console.ReadLine());

			Console.Write("Insert the serie tittle: ");
			string insertTittle = Console.ReadLine();

			Console.Write("Insert the release year: ");
			int insertYear = int.Parse(Console.ReadLine());

			Console.Write("Insert the sinopse: ");
			string insertSinopse = Console.ReadLine();

			Serie updateSerie = new Serie(Id: idSerie, Genre: (Genre)insertGenre, Tittle: insertTittle, Sinopse: insertSinopse, ReleaseYear: insertYear);
			repository.Update(idSerie, updateSerie);
		}

        private static void DeletSerie()
		{
			Console.Write("Insert the serie Id: ");
			int insertSerie = int.Parse(Console.ReadLine());

			repository.Delete(insertSerie);
		}

        private static void SelectSerie()
		{
			Console.Write("Insert serie Id: ");
			int insertSerie = int.Parse(Console.ReadLine());

			var serie = repository.getById(insertSerie);

			Console.WriteLine(serie);
		}

    private static string GetUserOption()
    {
        Console.WriteLine();
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1- Show series;");
        Console.WriteLine("2- Add new serie;");
        Console.WriteLine("3- Update serie;");
        Console.WriteLine("4- Delet serie;");
        Console.WriteLine("5- Select serie;");
        Console.WriteLine("C- Clear;");
        Console.WriteLine("X- Exit.");
        Console.WriteLine();

        string userOption = Console.ReadLine().ToUpper();
        Console.WriteLine();
        return userOption;
    }
}