using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using LibraryToWorkAccess;

namespace LibraryToWorkAccess
{
    public class RegistryDALDisLayer
    {
        private string cnString = string.Empty;
        private OleDbDataAdapter dbAdapter = null;


        public DataSet dataSetAccess { get; private set; }
        public RegistryDALDisLayer( )
        {

        }
        public RegistryDALDisLayer( string name )
        {
            cnString = name;
            dataSetAccess = new DataSet( name );

            ConfigurateAdapter( out dbAdapter );
            dataSetAccess.ExtendedProperties[ "TimeStamp" ] = DateTime.Now;
            dataSetAccess.ExtendedProperties[ "DataSetID" ] = Guid.NewGuid( );
            dataSetAccess.ExtendedProperties[ "Company" ] = "Piskunov Brothers";
        }

        private void ConfigurateAdapter( out OleDbDataAdapter dbAdapter )
        {
            //Создать адаптер и настроить SelectCommand
            dbAdapter = new OleDbDataAdapter( "SELECT * FROM REGISTRY ", cnString );

            //Динамически получить остальные объекты команд
            // во время выполнения, используя OleDbCommandBuilder

            OleDbCommandBuilder builder = new OleDbCommandBuilder( dbAdapter );

        }

        public DataTable GetAllRegistry( )
        {
            DataTable registry = new DataTable( "Registry" );
            dbAdapter.Fill( registry );
            return registry;
        }

        public void UpdateRegistry( DataTable modifiedTable )
        {
            dbAdapter.Update( modifiedTable );
        }
    }
}
