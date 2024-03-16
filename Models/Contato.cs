namespace ContatosApi;

public class Contato
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string Nome { get; set; }
    public required string Sobrenome { get; set; }
    public required string Telefone { get; set; }
    public string? Apelido { get; set; }
    public DateOnly DataCadastro { get; set; } = DateOnly.FromDateTime(DateTime.Today);
}
