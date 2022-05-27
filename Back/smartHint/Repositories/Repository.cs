
using smartHint.Models;
using smartHint.Controllers;
using Microsoft.EntityFrameworkCore;

namespace smartHint.Repositories;


public class ClientRepository
{

    public static void InsertMockLoja()
    {
        using (var context = new MyDbContext())
        {

            var loja = new Loja { LojaId = 1, Nome = "Ree" };
            var lojaConsulta = context.Lojas.Where(l => l.LojaId == loja.LojaId).FirstOrDefault();

            if (lojaConsulta == null)
            {

                context.Lojas.Add(loja);

                context.SaveChanges();
            }


        }
    }
    public static User InsertData(ClientDTO client, int lojaId)
    {
        using (var context = new MyDbContext())
        {

            var loja = context.Lojas.Include(l => l.Users).Where(l => l.LojaId == lojaId).FirstOrDefault();


            var user = new User()
            {
                NomeRazaoSocial = client.nomeRazaoSocial,
                Email = client.email,
                Telefone = client.telefone,
                DataCadastro = client.dataCadastro,
                Password = client.password,
                TipoPessoa = client.tipoPessoa
            };


            if (client.tipoPessoa == 1)
            {
                user.Fisica = new Fisica()
                {
                    Cpf = client.cpf,
                    Genero = client.genero,
                    DataNascimento = client.dataNascimento,
                };


            }
            else if (client.tipoPessoa == 2)
            {
                user.Juridico = new Juridico()
                {
                    Cnpj = client.cnpj,
                    InscricaoEstadual = client.inscricaoEstadual,
                };
            }

            loja.Users.Add(user);

            context.Users.Add(user);

            context.SaveChanges();


            return user;
        }
    }
    public static List<User> GetUsers(FiltersDTO filter)
    {
        using (var context = new MyDbContext())
        {
            var loja = context.Lojas.Include(l => l.Users).Where(l => l.LojaId == 1).FirstOrDefault();

            var usuarios = loja.Users;

            if (filter.DataCadastro != null)
            {
                usuarios = usuarios.Where(u => u.DataCadastro.ToShortDateString() == filter.DataCadastro).ToList();
            }
            if (filter.NomeRazaoSocial != null)
            {
                usuarios = usuarios.Where(u => u.NomeRazaoSocial == filter.NomeRazaoSocial).ToList();
            }

            if (filter.Bloqueado != null)
            {
                usuarios = usuarios.Where(u => u.Bloqueado == Convert.ToBoolean(filter.Bloqueado.Value)).ToList();
            }

            if (filter.Email != null)
            {
                usuarios = usuarios.Where(u => u.Email == filter.Email).ToList();
            }
            if (filter.Telefone != null)
            {
                usuarios = usuarios.Where(u => u.Telefone == filter.Telefone).ToList();
            }

            return usuarios;

        }

    }

}

