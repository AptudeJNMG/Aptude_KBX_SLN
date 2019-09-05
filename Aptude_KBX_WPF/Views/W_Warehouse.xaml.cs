using Aptude_KBX_MDL.Exceptions;
using Aptude_KBX_MDL.Models;
using Aptude_KBX_MDL.Repositories;
using Aptude_KBX_WPF.Statics;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Aptude_KBX_WPF.Views
{
    /// <summary>
    /// Lógica de interacción para W_Warehouse.xaml
    /// </summary>
    public partial class W_Warehouse : Window
    {
        private ViewType _vista;
        private M_WareHouse _item;
        private bool sololectura;
        IDatabase cache = App.Connection.GetDatabase();
        public bool SoloLectura
        {
            get { return sololectura; }
            set { sololectura = value; }
        }
        public W_Warehouse()
        {
            InitializeComponent();
        }
        internal W_Warehouse(ViewType vista, M_WareHouse item) : this()
        {
            _vista = vista;
            _item = item;
            this.DataContext = _item;
        }
        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (_vista)
                {
                    case ViewType.CREATE:
                        new R_WareHouse(Config.conexion).Create(_item);
                        Ext_Mensajes.Exito(Messages.Insertado);
                        break;
                    case ViewType.READ:
                        this.Close();
                        break;
                    case ViewType.UPDATE:
                        new R_WareHouse(Config.conexion).Update(_item);
                        Ext_Mensajes.Exito(Messages.Actualizado);
                        break;
                    case ViewType.DELETE:
                        if (Ext_Mensajes.Pregunta(string.Concat(Messages.mensajeEliminar, _item.ToString())) == MessageBoxResult.OK)
                        {
                            new R_WareHouse(Config.conexion).Delete(_item.Id);
                            Ext_Mensajes.Exito(Messages.Eliminado);
                        }
                        break;
                }
            }
            catch (EX_Datos ex)
            {
                Ext_Mensajes.Error(ex.Message);
            }
            catch (Exception ex)
            {
                Ext_Mensajes.Error(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            M_WareHouse e007 = new M_WareHouse();
            e007.Active = true;
            e007.Address = "JNM";
            e007.Id = 1;
            e007.Name = "JNMG";

            Console.WriteLine("Cache response from storing Employee .NET object : " +
                cache.StringSet("e007", JsonConvert.SerializeObject(e007)));

            // Retrieve .NET object from cache
            M_WareHouse e007FromCache = JsonConvert.DeserializeObject<M_WareHouse>(cache.StringGet("e007"));
            Console.WriteLine("Deserialized Employee .NET object :\n");
            Console.WriteLine("\tEmployee.Name : " + e007FromCache.Name);
            Console.WriteLine("\tEmployee.Id   : " + e007FromCache.Id);
        }
    }
}
