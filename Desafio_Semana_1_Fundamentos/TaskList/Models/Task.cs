namespace Semaa_2_CRUD.Models;

public class Task
{
    public int Id { get; set; }
    public string Titulo { get; set; } = String.Empty;
    public DateTime CriadaEm { get; set; } = DateTime.UtcNow;
    public bool Concluido { get; set; } = false;
}