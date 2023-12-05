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
=======================


CREATE PROCEDURE [LOGIN]
@LOGIN NVARCHAR(MAX), @PASSWORD NVARCHAR(MAX) AS
BEGIN
IF exists(SELECT [LOGIN], [PASSWORD] FROM [USERS] WHERE [LOGIN] =@LOGIN AND [PASSWORD] =  @PASSWORD)
BEGIN
SELECT *
FROM [INFOUSER]
WHERE ЛОГИН =@LOGIN AND ПАРОЛЬ =  @PASSWORD;
END
ELSE
BEGIN
PRINT 'GYLYAI DYADYA';
END
END
GO

EXECUTE [LOGIN] 'user1', '123456'
GO


CREATE PROCEDURE [UPDATE]
@IDS INT, @CODES NVARCHAR(40), @NAMES NVARCHAR(150), @PREDS NVARCHAR(MAX)
AS
IF exists(SELECT * FROM COUNTRYS WHERE [ID] = @IDS)
BEGIN
update COUNTRYS set CODE = replace(@CODES, '',''),
[NAME] = replace(@NAMES, '',''),
[PRED] = replace(@PREDS, '','')
where [ID] = @IDS;
END
ELSE
BEGIN
PRINT 'Код не существует'
END
GO




============================



