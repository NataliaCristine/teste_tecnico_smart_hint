using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using smartHint.Models;
using smartHint.Repositories;
using System.Net;
using System.Web.Http;


namespace smartHint.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase
{


    private readonly ILogger<ClientController> _logger;

    public ClientController(ILogger<ClientController> logger)
    {
        _logger = logger;
        CadastraLojaMock();
    }

    private void CadastraLojaMock()
    {
        ClientRepository.InsertMockLoja();
    }

    [HttpGet(Name = "client")]
    public List<User> Get([FromQuery] FiltersDTO filter)
    {
        var output = ClientRepository.GetUsers(filter);
        return output;
    }

    [HttpPost]
    public ActionResult<Models.User> Post(ClientDTO client)
    {
        try
        {

            var user = ClientRepository.InsertData(client, 1);


            return Created("User", null);
        }
        catch (DbUpdateException sqlex)
        {
            if (sqlex.InnerException is MySqlException)
            {
                var ex = sqlex.InnerException as MySqlException;
                if (ex.ErrorCode == MySqlErrorCode.DuplicateKeyEntry)
                {
                    if (ex.Message.Contains("Email"))
                        return StatusCode(406, "Email já cadastrado para outro Cliente");
                    if (ex.Message.Contains("Cpf"))
                        return StatusCode(406, "Este CPF/CNPJ já está vinculado a outro Comprador");
                    if (ex.Message.Contains("Cnpj"))
                        return StatusCode(406, "Este CPF/CNPJ já está vinculado a outro Comprador");
                    if (ex.Message.Contains("InscricaoEstadual"))
                        return StatusCode(406, "Esta InscricaoEstadual já está cdastrada para outro Cliente");
                }
            }
            throw;
        }
        catch (System.Exception)
        {

            throw;
        }

    }

}
