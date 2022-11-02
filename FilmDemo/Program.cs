using FilmDemo.Modesl;

List<Film> films = new List<Film>()
{
    new Film
    {
        Id = 0,
        Name = "Star Wars"
    },
    new Film
    {
        Id = 1,
        Name = "Seigneur des anneaux"
    }
};

List<Personne> personnes = new List<Personne>()
{
    new Personne
    {
        Id = 0,
        Name = "Harrison Ford"
    },
    new Personne
    {
        Id = 1,
        Name = "Ian McKellen"
    }
};

List<Casting> castings = new List<Casting>()
{
    new Casting
    {
        Id = 0,
        film = films.FirstOrDefault(x => x.Name == "Star Wars"),
        Person = personnes.FirstOrDefault(x => x.Name == "Harrison Ford"),
        Role = Roles.Acteur,
        RoleName = "Han Solo",
        Anecdote = "Il a pas eu Leia... Mais bien Chewbacca !"
    }
};


Film film = films.FirstOrDefault(x => x.Id == 0);



List<Casting> castingDeMonFilm = castings.Where(x => x.film.Id == film.Id).ToList();

foreach (Casting cast in castingDeMonFilm)
{
    Console.WriteLine($"{cast.Person.Name} - {cast.RoleName}");
}

