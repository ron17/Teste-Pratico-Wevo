namespace TestePraticoWevo.Repository.Configurations
{
    public class DbConnection
    {
        private static string ConnectionString = "Data source=.\\SQLEXPRESS;Initial Catalog=DbTesteWevo;Integrated Security=true;";

        public static string GetConn(){
            return ConnectionString;
        }
    }
}