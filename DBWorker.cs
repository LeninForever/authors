using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Data;
using HtmlAgilityPack;
using System.Net;

namespace RGR
{
    public class DBWorker
    {
        private static readonly string _logsPath = @"C:\Users\igor_2\Desktop\уЧеба_3курс\.net\лабы\RGR\Logs.txt";
        private static readonly string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=writersDB;Integrated Security=True;Connect Timeout=5;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private static SqlConnection _sqlConnection;

        private static readonly string _insertCommand = @"INSERT INTO [dbo].[writers]
(writer_first_name,writer_last_name,writer_image, writer_birthDate, writer_deathDate, writer_gender,writer_birthPlace,writer_jobTitle) 
VALUES(@FirstName, @LastName, @Image, @BirthDate, @DeathDate, @Gender, @BirthPlace, @JobTitle)";


        private static readonly string _selectCommand = @"SELECT [writers].[writer_first_name] FROM [writers] 
WHERE [writers].writer_birthDate = @BirthDate AND([writers].[writer_deathDate] = @DeathDate OR writer_deathDate IS NULL)";

        private static DBWorker _instance;

        public static int TextSize { get; } = 25;

        public static int GenderTextSize { get; } = 8;

        private DBWorker()
        {
            _sqlConnection = new SqlConnection(_connectionString);
        }

        public static DBWorker GetInstanse()
        {
            if (_instance == null)
                _instance = new DBWorker();

            return _instance;
        }
        ~DBWorker()
        {
            _sqlConnection.Close();
        }
        public void LoadInformamtion(object sender, DoWorkEventArgs eventArgs)
        {
            HtmlNodeCollection nodes;
            try
            {
                nodes = HtmlWorker.GetWritersCards();
            }
            catch (WebException exception)
            {
                File.AppendAllText(_logsPath, $"{DateTime.Now} {exception.Message}\r\n{exception.StackTrace}\r\n\r\n");
                throw new Exception(exception.Message, exception);
            }

            foreach (var node in nodes)
            {
                var jsonNode = node.FirstChild;

                var writerJson = JsonConvert.DeserializeObject<WriterJson>(jsonNode.InnerText);

                Writer writer = new Writer(writerJson);

                try
                {
                    InsertNewtWriter(writer);
                }
                catch (SqlException exception)
                {
                    File.AppendAllText(_logsPath, $"{DateTime.Now} {exception.Message}\r\n{exception.StackTrace}\r\n\r\n");
                    throw new Exception(exception.Message, exception);
                }
                catch (Exception exception)
                {
                    File.AppendAllText(_logsPath, $"{DateTime.Now} {exception.Message}\r\n{exception.StackTrace}\r\n\r\n");
                    throw new Exception(exception.Message, exception);
                }
            }
        }
        public int InsertNewtWriter(Writer writer)
        {
            string nameFromDB = SelectWriter(writer);

            if (!string.IsNullOrEmpty(nameFromDB))
                return 0;

            return InsertWriter(writer);
        }

        private int InsertWriter(Writer writer)
        {
            int result = 0;
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = _sqlConnection;
                    command.CommandText = _insertCommand;
                    command.CommandType = CommandType.Text;

                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 25).Value = writer.FirstName;
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar, 25).Value = writer.LastName;
                    command.Parameters.Add("@Image", SqlDbType.Image).Value = writer.Image ?? Convert.DBNull;
                    command.Parameters.Add("@BirthDate", SqlDbType.Date).Value = writer.BirthDate.Date;
                    command.Parameters.Add("@DeathDate", SqlDbType.Date).Value = writer.DeathDate.HasValue ? writer.DeathDate.Value.Date : Convert.DBNull;
                    command.Parameters.Add("@Gender", SqlDbType.NVarChar, 8).Value = writer.Gender;
                    command.Parameters.Add("@BirthPlace", SqlDbType.NVarChar, 25).Value = writer.BirthPlace;
                    command.Parameters.Add("@JobTitle", SqlDbType.NVarChar, 25).Value = writer.JobTitle;
                    _sqlConnection.Open();
                    result = command.ExecuteNonQuery();
                }
                catch (Exception exception)
                {
                    File.AppendAllText(_logsPath, $"{DateTime.Now} {exception.Message}\r\n{exception.StackTrace}\r\n\r\n");

                }
                finally
                {
                    if (_sqlConnection != null && _sqlConnection.State == ConnectionState.Open)
                        _sqlConnection.Close();
                }
            }
            return result;
        }
        private string SelectWriter(Writer writer)
        {
            string name = "";
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                try
                {

                    sqlCommand.Connection = _sqlConnection;
                    sqlCommand.CommandText = _selectCommand;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.Parameters.Add("@BirthDate", SqlDbType.Date).Value = writer.BirthDate.Date;
                    sqlCommand.Parameters.Add("@DeathDate", SqlDbType.Date).Value = writer.DeathDate.HasValue ? writer.DeathDate.Value.Date : Convert.DBNull;
                    _sqlConnection.Open();

                    SqlDataReader dataReader = sqlCommand.ExecuteReader();

                    while (dataReader.Read())
                    {
                        name = dataReader["writer_first_name"] as string;
                    }
                }
                finally
                {
                    if (_sqlConnection != null && _sqlConnection.State == ConnectionState.Open)
                        _sqlConnection.Close();
                }
            }

            return name;
        }


        public static bool IsUnique(Writer writer)
        {
            return false;

        }
    }
}
