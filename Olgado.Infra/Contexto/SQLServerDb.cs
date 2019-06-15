using System.Data;
using System.Data.SqlClient;

namespace Olgado.Infra.Contexto
{
    public class SQLServerDb : IDb
    {
        IDbConnection _Db;
        
      
        public void Dispose()
        {
            _Db.Close();
            _Db.Dispose();

        }

        public IDbConnection GetCon()
        {
            return _Db = new SqlConnection(@"Server=; Database=Vandeco; User Id=root; Password=123;");
        }
    }
}
