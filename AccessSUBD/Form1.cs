using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryToWorkAccess;

namespace AccessSUBD
{
    public partial class Form1 : Form
    {
        // Экземпляр класса для работы автономного уровня
        RegistryDALDisLayer dal = null;
        ConnectDBAccess connectDB = null;

        public Form1( )
        {
            InitializeComponent( );
        }

        private void buttonConnect_Click( object sender, EventArgs e )
        {
            connectDB = new ConnectDBAccess( $@"{textBoxPathMDB.Text}" );
            // Создать объект доступа к данным
            dal = new RegistryDALDisLayer( connectDB.ConnectionString );
            // Отобразить таблицу данных
            dataGridViewRegisty.DataSource = dal.GetAllRegistry( );
        }
    }
}
