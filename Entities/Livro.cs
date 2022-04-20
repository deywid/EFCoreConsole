namespace EFCoreConsole.Entities
{
  public class Livro
  {
    public Livro(string titulo, string autor, int anoPublicacao)
    {
      this.Titulo = titulo;
      this.Autor = autor;
      this.AnoPublicacao = anoPublicacao;

    }
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }
  }
}