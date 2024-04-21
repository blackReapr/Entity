using ConsoleApp3.DAL;

DataContext dataContext = new DataContext();

dataContext.Movies.Add(new () { Name="Kingdom of Heaven", DirectorId=2, ImdbScore=10, Duration=120});
dataContext.SaveChanges();
