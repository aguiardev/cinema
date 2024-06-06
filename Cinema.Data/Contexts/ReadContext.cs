using Microsoft.Data.Sqlite;
using System.Data;

namespace Cinema.Data.Contexts;
public class ReadContext(string connectionString) : IDisposable
{
    private readonly string _connectionString = connectionString;
    private SqliteConnection? _connection;

    public SqliteConnection Connection
    {
        get
        {
            _connection ??= new SqliteConnection(_connectionString);

            if (_connection.State != ConnectionState.Open)
                _connection.Open();

            return _connection;
        }
    }

    public void Dispose()
    {
        // Fecha a conexão quando o contexto for descartado
        if (_connection != null)
        {
            _connection.Dispose();
            _connection = null;
        }
    }
}