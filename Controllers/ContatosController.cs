using Microsoft.AspNetCore.Mvc;

namespace ContatosApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ContatosController : ControllerBase
{
    private static readonly Contato[] Contatos =
    [
        new Contato { Id = "015fa5fc-1eee-4fe8-9bc8-c17a9ff3a461", Nome = "Gabriel", Sobrenome = "Pagotto", Telefone = "64999593511" },
        new Contato { Nome = "Maria", Sobrenome = "Silva", Telefone = "64998877444" },
        new Contato { Nome = "João", Sobrenome = "Santos", Telefone = "64997733665" },
        new Contato { Nome = "Ana", Sobrenome = "Ferreira", Telefone = "64995555123" },
        new Contato { Nome = "Pedro", Sobrenome = "Oliveira", Telefone = "64994444222" },
        new Contato { Nome = "Juliana", Sobrenome = "Souza", Telefone = "64993333999" },
        new Contato { Nome = "Lucas", Sobrenome = "Pereira", Telefone = "64992222666" },
        new Contato { Nome = "Mariana", Sobrenome = "Almeida", Telefone = "64991111333" },
        new Contato { Nome = "Carlos", Sobrenome = "Mendes", Telefone = "64990000900" },
        new Contato { Nome = "Fernanda", Sobrenome = "Gomes", Telefone = "64998888777" },
        new Contato { Nome = "Rafael", Sobrenome = "Martins", Telefone = "64997777666" },
        new Contato { Nome = "Larissa", Sobrenome = "Carvalho", Telefone = "64996666555" },
        new Contato { Nome = "Thiago", Sobrenome = "Ribeiro", Telefone = "64995555444" },
        new Contato { Nome = "Amanda", Sobrenome = "Costa", Telefone = "64994444333" },
        new Contato { Nome = "Vinicius", Sobrenome = "Nascimento", Telefone = "64993333222" }
    ];

    private readonly ILogger<ContatosController> _logger;

    public ContatosController(ILogger<ContatosController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(Contatos);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(string id)
    {      
        Contato? contato = Contatos.FirstOrDefault(c => c!.Id == id, defaultValue: null);
        if (contato == null)
        {
            return NotFound();
        }
        return Ok(contato);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Contato contato)
    {
        return Ok(contato);
    }
}
