using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace VMMV.Model
{
    public class Ventas : INotifyPropertyChanged
    {

        private int idVenta;
        private string fecha;
        private double importe;
        private string numTarjeta;

        public int IdVenta
        {
            get
            {
                return idVenta;
            }
            set
            {
                idVenta = value;
                OnPropertyChanged("idVenta");
                
            }
        }
        public string Fecha {
            get { return fecha; }
            set
            {
                fecha = value;
                OnPropertyChanged("fecha");
            }
        }
        public double Importe {
            get { return importe; }
            set
            {
                importe = value;
                OnPropertyChanged("importe");
            }
            
        }
        public string NumTarjeta
        {
            get { return numTarjeta; }
            set
            {
                numTarjeta = value;
                OnPropertyChanged("numTarjeta");
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