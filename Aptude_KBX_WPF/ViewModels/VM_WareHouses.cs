using Aptude_KBX_MDL.Models;
using Aptude_KBX_MDL.Repositories;
using Aptude_KBX_WPF.Statics;
using Aptude_KBX_WPF.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Aptude_KBX_WPF.ViewModels
{
    public class VM_WareHouses : ModelBase
    {
        private M_WareHouse _seleccionado;
        private ObservableCollection<M_WareHouse> _lista;
        string _busqueda = string.Empty;
        public M_WareHouse Seleccionado
        {
            get { return _seleccionado; }
            set
            {
                _seleccionado = value;
                OnPropertyChanged(nameof(Seleccionado));
            }
        }
        public string Busqueda
        {
            get => _busqueda;
            set
            {
                _busqueda = value;
                OnPropertyChanged(nameof(Busqueda));
            }
        }
        public ICommand ComAgregar { get; set; }
        public ICommand ComEditar { get; set; }
        public ICommand ComEliminar { get; set; }
        public ICommand ComBuscar { get; set; }
        public ObservableCollection<M_WareHouse> Lista
        { get => _lista; set => _lista = value; }

        public VM_WareHouses()
        {
            ComAgregar = new GenericCommand(Agregar);
            ComEditar = new GenericCommand(Editar, param => Seleccionado != null);
            ComEliminar = new GenericCommand(Eliminar, param => Seleccionado != null);
            ComBuscar = new GenericCommand(Buscar);
            Lista = new ObservableCollection<M_WareHouse>();
        }

        private void Agregar(object sender)
        {
            new W_Warehouse(ViewType.CREATE, new M_WareHouse()).ShowDialog();
        }
        private void Editar(object sender)
        {
            new W_Warehouse(ViewType.UPDATE, Seleccionado).ShowDialog();
        }
        private void Eliminar(object sender)
        {
            new W_Warehouse(ViewType.DELETE, Seleccionado).ShowDialog();
        }
        public void Buscar(object sender)
        {
            List<M_WareHouse> ret = null;
            try
            {
                Lista.Clear();
                ret = new R_WareHouse(Config.conexion).GetByNombre(Busqueda);
                ret?.ForEach(i => Lista.Add(i));
            }
            catch (Exception ex)
            {
                Ext_Mensajes.Error(ex.Message);
            }
        }
    }
}
