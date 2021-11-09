using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;

namespace LibraryToWorkAccess
{
    public class ConnectDBAccess
    {
        public OleDbConnection oleDbConnection;
        public string ConnectionString { get; private set; }
        public List<string> outputList = new List<string>( );
        public ConnectDBAccess( string dataSourceString )
        {
            Connect( dataSourceString );
        }
        private void Connect( string dataSourceString )
        {
            //Создать строку соединения для OLE DB
            OleDbConnectionStringBuilder cnStrBilder = new OleDbConnectionStringBuilder( );
            cnStrBilder.DataSource = dataSourceString;
            cnStrBilder.Provider = @"Microsoft.Jet.OLEDB.4.0";
            cnStrBilder.Add( "Jet OLEDB:Database Password", "@@@" );
            ConnectionString = cnStrBilder.ConnectionString;

            /*
                        //Создать и открыть подключение
                        using (OleDbConnection cn = new OleDbConnection( ))
                        {
                            cn.ConnectionString = ConnectionString;
                            cn.Open( );

                            // Создать объект команды
                            //string strAccess = "CREATE TABLE WWW (Id int, CustomersId int)";
                            // string strAccess = "DROP TABLE WWW ";
                            // OleDbCommand myCommand = new OleDbCommand( strAccess, cn );



                            // Создать объект команды
                            string strAccess = "Select * From PROJS";
                            OleDbCommand myCommand = new OleDbCommand( strAccess, cn );
                            //Получить объект чтения с помощью Exectereader
                            using (OleDbDataReader myDataReader = myCommand.ExecuteReader( ))
                            {
                                outputList.Add( $"Field count = { myDataReader.FieldCount,-10}" );

                                outputList.Add( $"{"Наименование",-50}{"PRODS",-20}{"PRODJ",-20}" );

                                while (myDataReader.Read( ))
                                {

                                    outputList.Add( $"{myDataReader[ "NAIM" ],-50}" );
                                    // $"{myDataReader[ "PRODS" ],20}, " +
                                    // $"{myDataReader[ "PROJ" ],20}" );
                                }
                            }

                        }*/
        }
    }
}
