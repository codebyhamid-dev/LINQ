// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using LINQ;

var games = new List<Games>
{
    new Games { Title = "The Witcher 3", Genre = "RPG", ReleaseYear = 2015, Rating = 9.5, Price = 15 },
    new Games { Title = "Stardew Valley", Genre = "Simulation", ReleaseYear = 2016, Rating = 9.0, Price = 15 },
    new Games { Title = "Celeste", Genre = "Platformer", ReleaseYear = 2018, Rating = 9.2, Price = 20 },
    new Games { Title = "Hades", Genre = "RPG", ReleaseYear = 2020, Rating = 9.4, Price = 25 },
    new Games { Title = "Hollow Knight", Genre = "Metroidvania", ReleaseYear = 2017, Rating = 9.3, Price = 15 },
    new Games { Title = "Red Dead Redemption 2", Genre = "Action", ReleaseYear = 2018, Rating = 9.8, Price = 30 },
    new Games { Title = "God of War", Genre = "Action", ReleaseYear = 2018, Rating = 9.7, Price = 30 },
    new Games { Title = "Among Us", Genre = "Party", ReleaseYear = 2018, Rating = 8.5, Price = 5 },
    new Games { Title = "Minecraft", Genre = "Sandbox", ReleaseYear = 2011, Rating = 9.0, Price = 20 },
    new Games { Title = "Terraria", Genre = "Sandbox", ReleaseYear = 2011, Rating = 8.8, Price = 10 },
    new Games { Title = "Portal 2", Genre = "Puzzle", ReleaseYear = 2011, Rating = 9.6, Price = 10 },
    new Games { Title = "Ori and the Blind Forest", Genre = "Platformer", ReleaseYear = 2015, Rating = 9.1, Price = 15 },
    new Games { Title = "Inside", Genre = "Puzzle", ReleaseYear = 2016, Rating = 8.7, Price = 10 },
    new Games { Title = "Cuphead", Genre = "Run and Gun", ReleaseYear = 2017, Rating = 8.9, Price = 20 },
    new Games { Title = "Disco Elysium", Genre = "RPG", ReleaseYear = 2019, Rating = 9.6, Price = 30 }
};
//var allGames = games.Select(g => g.Title);
//foreach (var game in allGames)
//{
//    Console.WriteLine(game);
//}

//var rpg = games.Where(g => g.Genre == "RPG");
//foreach(var game in rpg)
//{
//    Console.WriteLine(game.ReleaseYear);
//}

//var highRatedGames = games.Where(g => g.Rating > 9.0)
//                           .OrderByDescending(g => g.Rating)
//                           .Select(g => new { g.Title, g.Rating });
//foreach (var game in highRatedGames)
//{
//    Console.WriteLine($"Title: {game.Title}, Rating: {game.Rating}");
//}

//var modrenGames=games.Any(games => games.ReleaseYear > 2017);
//Console.WriteLine($"Are there any modern games? {modrenGames}");

//var sortedByYear = games.OrderBy(g => g.ReleaseYear);
//foreach (var game in sortedByYear)
//{
//    Console.WriteLine($"Title: {game.Title}, Release Year: {game.ReleaseYear}");
//}

//var sortedByYearDesc = games.OrderByDescending(g => g.ReleaseYear);
//foreach (var game in sortedByYearDesc)
//{
//    Console.WriteLine($"Title: {game.Title}, Release Year: {game.ReleaseYear}");
//}

//var gamesCount = games.Count();
//Console.WriteLine($"Total Number of games are: {gamesCount}");

//var maxPrice=games.Max(x => x.Price);
//Console.WriteLine($"Max price:{maxPrice}");

//var minRating=games.Min(x => x.Rating);
//Console.WriteLine(minRating);

//var gameGroup = games.GroupBy(g => g.Genre);
//foreach (var group in gameGroup)
//{
//    Console.WriteLine($"Genre: {group.Key}");
//    foreach (var game in group)
//    {
//        Console.WriteLine($"  Title: {game.Title}, Release Year: {game.ReleaseYear}, Rating: {game.Rating}");
//    }
//}

//var lowBudgetGames=games
//    .Where(g=>g.Genre=="RPG" && g.Price < 30)
//    .OrderBy(g => g.ReleaseYear)
//    .Select(g => new { g.Title, g.ReleaseYear, g.Price });

//foreach (var game in lowBudgetGames)
//{
//    Console.WriteLine($"Title: {game.Title}, Release Year: {game.ReleaseYear}, Price: {game.Price}");
//}

//var paginatedGames = games.Skip(1).Take(2);
//foreach (var game in paginatedGames)
//{
//    Console.WriteLine(game.Title);
//}


//var rpg = games.Where(x => x.Genre == "RPG").ToList();
//foreach (var item in rpg)
//{
//    Console.WriteLine(item.Title);
//}

//var gameTitle=games.Select(g=>g.Title).ToList();
//foreach (var item in gameTitle)
//{
//    Console.WriteLine(item);
//}

//var sortedbyRating=games.OrderBy(g=>g.Rating).ToList();
//foreach (var item in sortedbyRating)
//{
//    Console.WriteLine($"Title: {item.Title} Rating: {item.Rating}");
//}

//var groupGames=games.GroupBy(g=>g.Genre).ToList();
//foreach (var group in groupGames)
//{
//    Console.WriteLine($"Genre: {group.Key}");
//    foreach (var game in group)
//    {
//        Console.WriteLine($"  Title: {game.Title}, Release Year: {game.ReleaseYear}, Rating: {game.Rating}, Price: {game.Price}");
//    }
//}

//var totalgames = games.Count();
//Console.WriteLine(totalgames);
//var totalPrice=games.Sum(g=>g.Price);
//Console.WriteLine(totalPrice);

//var maxRating=games.Max(g=>g.Rating);
//Console.WriteLine(maxRating);

//bool hasplatform=games.Any(g=>g.Genre == "Platformer");
//Console.WriteLine(hasplatform);
//bool allAbove8 = games.All(g => g.Rating > 8.0);
//Console.WriteLine($"All games have a rating above 8.0: {allAbove8}");
////CONTAIN
//var containsGame = games.Any(g => g.Title == "Celeste");
//Console.WriteLine($"Does the list contain 'Celeste'? {containsGame}");

//var game = games
//    .Where(g => g.Genre == "RPG" && g.Price < 30)
//    .OrderBy(o => o.ReleaseYear)
//    .Select(s => new { s.Title, s.Genre, s.ReleaseYear });
//foreach(var item in game)
//{
//    Console.WriteLine($"Title: {item.Title}, Genre: {item.Genre} ,Release: {item.ReleaseYear}");
//}

//var firstGame = games.First();
//Console.WriteLine(firstGame);

//var first=games.First(games => games.Genre == "Adventure");
//Console.WriteLine($"First RPG Game: {first.Title}, Release Year: {first.ReleaseYear}, Rating: {first.Rating}, Price: {first.Price}");
//var firstordefault=games.FirstOrDefault(games => games.Genre == "Adventure");
//if (firstordefault != null)
//{
//    Console.WriteLine($"First Adventure Game: {firstordefault.Title}, Release Year: {firstordefault.ReleaseYear}, Rating: {firstordefault.Rating}, Price: {firstordefault.Price}");
//}
//else
//{
//    Console.WriteLine("No Adventure games found.");
//}

//var game = games.Single(g => g.Title == "Celeste");
//Console.WriteLine($"Single Game: {game.Title}, Release Year: {game.ReleaseYear}, Rating: {game.Rating}, Price: {game.Price}");
//var singleOrDefaultGame = games.SingleOrDefault(g => g.Title == "Celestes");
//if (singleOrDefaultGame != null)
//{
//    Console.WriteLine($"First Adventure Game: {singleOrDefaultGame.Title}, Release Year: {singleOrDefaultGame.ReleaseYear}, Rating: {singleOrDefaultGame.Rating}, Price: {singleOrDefaultGame.Price}");

//}
//else
//{
//    Console.WriteLine("No Record Found");
//}

//var lastRpg = games.Last(g => g.Genre == "RPG");
//Console.WriteLine($"Last RPG Game: {lastRpg.Title}, Release Year: {lastRpg.ReleaseYear}, Rating: {lastRpg.Rating}, Price: {lastRpg.Price}");
//var lastOrDefaultGame = games.LastOrDefault(g => g.Genre == "Adventure");
//if (lastOrDefaultGame != null)
//{
//    Console.WriteLine($"Last Adventure Game: {lastOrDefaultGame.Title}, Release Year: {lastOrDefaultGame.ReleaseYear}, Rating: {lastOrDefaultGame.Rating}, Price: {lastOrDefaultGame.Price}");
//}
//else
//{
//    Console.WriteLine("No Adventure games found.");
//}

//var distinctgames=games.Select(g=>g.Genre).Distinct();
//foreach (var genre in distinctgames)
//{
//    Console.WriteLine(genre);
//}

//var top3Games = games
//    .OrderByDescending(o => o.Rating)
//    .Take(3)
//    .ToList();
//foreach (var game in top3Games)
//{
//    Console.WriteLine(game.Title);

//}
//Console.WriteLine();
//var remainingGames = games
//    .OrderBy(g => g.Rating)
//    .Take(5)
//    .ToList();

//foreach(var game in remainingGames)
//{
//    Console.WriteLine(game.Title);
//}

//var gameReviews = new List<GameReview>
//{
//    new GameReview { Title = "The Witcher 3", Reviewer = "IGN" },
//    new GameReview { Title = "Hades", Reviewer = "Gamespot" },
//};

//var joined = games.Join(
//    gameReviews,
//    g => g.Title,
//    r => r.Title,
//    (g, r) => new { g.Title, g.Rating, r.Reviewer }
//).ToList();
//foreach (var item in joined)
//{
//    Console.WriteLine($"Title: {item.Title}, Rating: {item.Rating}, Reviewer: {item.Reviewer}");
//}

//var skippedrecored = games
//    .Skip(3)
//    .Take(5)
//    .Select(g => new { g.Title, g.Genre, g.ReleaseYear })
//    .ToList();
//foreach (var item in skippedrecored)
//{
//    Console.WriteLine($"Title: {item.Title}, Genre: {item.Genre}, Release Year: {item.ReleaseYear}");
//}

//var lastTwo = games.TakeLast(3).ToList();
//foreach (var game in lastTwo)
//{
//    Console.WriteLine($"Title: {game.Title}, Release Year: {game.ReleaseYear}");
//}


