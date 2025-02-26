using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using Npgsql;
// - Uma das formas de fazer conexão com o banco de dados
// -1. ADO.NET (activeX Data Objects) Faz conexão direta com o banco de dados, sem a necessidade de um servidor intermediario
namespace Connection
{
    public class Executar
    {
        static void Main(string[] args)
        {

            Crud crud = new Crud();
            crud.ListarUsuarios();
            System.Console.WriteLine("-------------------");

            System.Console.WriteLine("Inserindo um novo usuário");
            crud.InserirUsuario(7, "Fulnao", "fulano@gmail.com");
            crud.ListarUsuarios();
            System.Console.WriteLine("-------------------");

            System.Console.WriteLine("Atualizando um usuário");
            crud.AtualizarUsuario(7, "Fulano da Silva");
            crud.ListarUsuarios();
            System.Console.WriteLine("-------------------");

            System.Console.WriteLine("Deletando um usuário");
            crud.DeletarUsuario(7);
            crud.ListarUsuarios();
            System.Console.WriteLine("-------------------");

            // string connection = "Host=localhost; Database=testeconnection; Username=postgres; Password=3@56Casa;";

            // using (NpgsqlConnection conn = new NpgsqlConnection(connection))
            // {
            //     try
            //     {
            //         conn.Open();
            //         System.Console.WriteLine("Conexão aberta com sucesso!");

            //         string query = "SELECT * FROM usuario;";

            //         string insertquery = "insert into usuario (nome, email) values ('FelipeGueixo', 'GueixoFelipe@gmail.com');";

            //         string deletequery = "delete from usuario where id = 3;";

            //         string updatequery = "update usuario set nome = 'KauaGuei' where id = 2";

            //         using (NpgsqlCommand cmd = new NpgsqlCommand(updatequery, conn))
            //         {
            //             int row = cmd.ExecuteNonQuery();
            //             System.Console.WriteLine("Linhas afetadas: " + row);
            //         }


            //         using (NpgsqlCommand cmd = new NpgsqlCommand(deletequery, conn))
            //         {
            //             int row = cmd.ExecuteNonQuery();
            //             System.Console.WriteLine("Linhas afetadas: " + row);

            //         }

            //         using (NpgsqlCommand cmd = new NpgsqlCommand(insertquery, conn))
            //         {
            //             int row = cmd.ExecuteNonQuery();
            //             System.Console.WriteLine("Linhas afetadas: " + row);
            //         }

            //         using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            //         {
                        
            //             using (NpgsqlDataReader dr = cmd.ExecuteReader())
            //             {
            //                 System.Console.WriteLine("Tabela do banco de dados");
            //                 while(dr.Read())
            //                 {
            //                     // System.Console.WriteLine(dr.GetString(0));
            //                     System.Console.WriteLine("id: " + dr["id"] + " - Nome: " + dr["nome"] + " - Email: " + dr["email"]);
            //                 }

            //             }

            //         }


            //     }
            //     catch (System.Exception ex)
            //     {
            //         System.Console.WriteLine("Erro:" + ex.Message);
            //     }
            // }
            
        }

        
    }
}