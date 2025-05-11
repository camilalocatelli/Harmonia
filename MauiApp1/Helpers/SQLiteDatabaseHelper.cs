using SQLite;
using Harmonia.Models;
using System.IO;
using System.Threading.Tasks;

namespace Harmonia.Helpers
{
    public class SQLiteDatabaseHelper
    {
        private static SQLiteAsyncConnection connection;

        public static async Task Init()
        {
            if (connection != null)
                return;

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "Harmonia.db");
            connection = new SQLiteAsyncConnection(databasePath);

            await connection.CreateTableAsync<Pessoa>();
            await connection.CreateTableAsync<Administrador>();
            await connection.CreateTableAsync<Professor>();
            await connection.CreateTableAsync<Aluno>();
            await connection.CreateTableAsync<Instrumento>();
            await connection.CreateTableAsync<Caixa>();
            await connection.CreateTableAsync<Aula>();
            await connection.CreateTableAsync<ReservaInstrumento>();
        }

        public static SQLiteAsyncConnection GetConnection()
        {
            return connection;
        }
    }
}
