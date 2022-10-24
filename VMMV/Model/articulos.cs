using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace VMMV.Model
{
    public class Articulos : INotifyPropertyChanged
    {

        private int idArticulo;
        private string descripcion;
        private double precioCoste;
        private double iva;
        private double pvp;

        public int IdArticulo
        {
            get
            {
                return idArticulo;
            }
            set
            {
                idArticulo = value;
                OnPropertyChanged("IdArticulo");
                
            }
        }
        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
                OnPropertyChanged("Descripcion");
            }
        }
        public double PrecioCoste
        {
            get
            {
                return precioCoste;
            }
            set
            {
                OnPropertyChanged("PrecioCoste");
                precioCoste = value;
              
            }
        }
        public double IVA
        {
            get
            {
                return iva;
            }
            set
            {
                OnPropertyChanged("IVA");
                iva = value;
               
            }
        }
        public double PVP
        {
            get
            {
                return pvp;
            }
            set
            {
                pvp = value;
                OnPropertyChanged("PVP");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}