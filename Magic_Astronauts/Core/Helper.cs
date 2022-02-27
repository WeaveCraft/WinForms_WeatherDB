using System.Configuration;

namespace Magic_Astronauts.DataAccess
{
    public static class Helper
    {
        public static string Conn(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
