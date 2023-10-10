using System.Data;
using System.Data.SqlClient;

namespace teatre
{
    class DataBase
    {
        public static SqlConnection SqlConnection()
        { return new SqlConnection(@"Data Source=localhost; Initial Catalog =teatre; Integrated Security=True"); }
        
       /// <summary>
       /// Запросы в бвзу
       /// </summary>
       /// <param name="stroke">Запрос</param>
        public static void toDB(string stroke)
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(stroke, SqlConnection());
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
            }
            catch { kaurcev.Alerts("Ошибка работы SQL", Alerts.enmType.Success); }
        }

        /// <summary>
        /// Вывод таблицы из базы данных
        /// </summary>
        /// <param name="stroke"> Тут вводится запрос </param>
        public static DataTable fromDB(string stroke)
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(stroke, SqlConnection());
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                DataTable dataTable = dataSet.Tables[0];
                return dataTable;
            }
            catch
            {
                kaurcev.Alerts("Ошибка работы SQL", Alerts.enmType.Alert);
                DataTable currentTable = new DataTable("Customers");
                return currentTable;
            }
        }
    }
}
