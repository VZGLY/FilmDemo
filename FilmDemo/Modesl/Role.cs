namespace FilmDemo.Modesl;

public class Role
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public enum Roles
{
    Acteur,
    Scenariste,
    Realisateur
}