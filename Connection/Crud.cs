using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using System.Diagnostics;
using Connection.Entity;
using System.Data.Common;
namespace Connection
{
    public class Crud
    {
        public void InserirUsuario(int id, string nome, string email)
        {
            using (var db = new Ligacao())
            {
                db.Usuarios.Add(new Usuario { Id = id, nome = nome, email = email });
                db.SaveChanges();
            }
        }

        public void ListarUsuarios()
        {
            using (var db = new Ligacao())
            {
                var usuarios = db.Usuarios.ToList(); // Aqui a gente pega todos os registros da tabela usuario, que esta como lista
                foreach (var usuario in usuarios)
                {
                    Console.WriteLine($"Id: {usuario.Id} Nome: {usuario.nome} Email: {usuario.email}");
                }
            }
        }

        public void AtualizarUsuario(int id, string novoNome)
        {
            using (var db = new Ligacao())
            {
                var usuario = db.Usuarios.Find(id); // Aqui ele pesquisa pelo id
                if (usuario != null)
                {
                    usuario.nome = novoNome;
                    db.SaveChanges(); // Aqui ele salva as alterações no banco de dados
                    System.Console.WriteLine("Usuário atualizado com sucesso");
                }
                else
                {
                    System.Console.WriteLine("Usuário não encontrado");
                }
            }
        }

        public void DeletarUsuario(int id)
        {
            using (var db = new Ligacao())
            {
                var usuario = db.Usuarios.Find(id); // Aqui ele pesquisa pelo id
                if (usuario != null)
                {
                    db.Usuarios.Remove(usuario);
                    db.SaveChanges(); // Aqui ele salva as alterações no banco de dados
                    System.Console.WriteLine("Usuário deletado com sucesso");
                }
                else
                {
                    System.Console.WriteLine("Usuário não encontrado");
                }
            }
        }













































        // string connection = "Host=localhost; Database=testeconnection; Username=postgres; Password=3@56Casa;";

        // public void InsertData(string nome, string email)
        // {
        //     string query = $"insert into usuario (nome, email) values ('{nome}', '{email}' )";

        //     using ( NpgsqlConnection conn = new NpgsqlConnection(connection))
        //     {
        //         conn.Open();
        //         using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
        //         {
        //             cmd.Parameters.AddWithValue("nome", nome);
        //             cmd.Parameters.AddWithValue("email", email);
        //             cmd.ExecuteNonQuery();
        //         }
        //     }
        // }

        // public void ReadData()
        // {
        //     string query = "select * from usuario";

        //     using(NpgsqlConnection conn = new NpgsqlConnection(connection))
        //     {
        //         conn.Open();
        //         using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
        //         {
        //             using(NpgsqlDataReader dr = cmd.ExecuteReader())
        //             {
        //                 while(dr.Read())
        //                 {
        //                      System.Console.WriteLine("id: " + dr["id"] + " - Nome: " + dr["nome"] + " - Email: " + dr["email"]);
        //                 }
        //             }
        //         }


        //     }
        // }

        // public void UpdateData(int id, string newData)
        // {
        //     string queryUpdate = $"update usuario set nome = '{newData}' where id = {id}";
        //     using(NpgsqlConnection conn = new NpgsqlConnection(connection)){

        //         conn.Open();
        //         using(NpgsqlCommand cmd = new NpgsqlCommand(queryUpdate, conn))
        //         {
        //             cmd.Parameters.AddWithValue("newData", newData);
        //             cmd.Parameters.AddWithValue("id", id);
        //             cmd.ExecuteNonQuery();
        //         }
        //     }
            
        // }

        // public void DeleteData(int id)
        // {
        //     string queryDelete = $"delete from usuario where id = {id}";
        //     using(NpgsqlConnection conn = new NpgsqlConnection(connection))
        //     {
        //         conn.Open();
        //         using(NpgsqlCommand cmd = new NpgsqlCommand(queryDelete, conn))
        //         {
        //             cmd.Parameters.AddWithValue("id", id);
        //             cmd.ExecuteNonQuery();
        //         }
        //     }
        // }

        // static void Main(string[] args)
        // {
        //     Crud crud = new Crud();

           
            
        //     crud.DeleteData(7);
        //     crud.ReadData();
            

            // Stopwatch sw = new Stopwatch();
            // TimeSpan tempoTotal;

            // sw.Start();
            // crud.InsertData("Engenheiro", "Olsevisk@gmail.com");
            // sw.Stop();
            // System.Console.WriteLine($"Tempo total: {sw.ElapsedMilliseconds}ms");
            // TimeSpan tempoInsert = sw.Elapsed; 

            // sw.Restart();
            // System.Console.WriteLine("Leitura...");
            // crud.ReadData();
            // sw.Stop();
            // System.Console.WriteLine($"Tempo total: {sw.ElapsedMilliseconds}ms");
            // TimeSpan tempoRead = sw.Elapsed;

            // sw.Restart();
            // System.Console.WriteLine("Update...");
            // crud.UpdateData(1, "Engenheiro");
            // sw.Stop();
            // System.Console.WriteLine($"Tempo total: {sw.ElapsedMilliseconds}ms");
            // TimeSpan tempoUpdate = sw.Elapsed;

            // sw.Restart();   
            // System.Console.WriteLine("Delete...");
            // crud.DeleteData(1);
            // sw.Stop();
            // System.Console.WriteLine($"Tempo total: {sw.ElapsedMilliseconds}ms");
            // TimeSpan tempoDelete = sw.Elapsed;

            // tempoTotal = tempoInsert + tempoRead + tempoUpdate + tempoDelete;

            // System.Console.WriteLine($"Tempo total: {tempoTotal.TotalMilliseconds}ms");

            // System.Console.WriteLine($"Tempo Insert: {tempoInsert.TotalMilliseconds}ms");
            // System.Console.WriteLine($"Tempo Read: {tempoRead.TotalMilliseconds}ms");
            // System.Console.WriteLine($"Tempo Update: {tempoUpdate.TotalMilliseconds}ms");
            // System.Console.WriteLine($"Tempo Delete: {tempoDelete.TotalMilliseconds}ms");


        
        
    }
}