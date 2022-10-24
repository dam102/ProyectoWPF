using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using VMMV.Model;
using System.Windows.Input;

namespace VMMV.ViewModel
{
    public class VentasViewModel
    {
        private List<Ventas> VentasList;

        public VentasViewModel()
        {
            VentasList = new List<Ventas>
            {
                new Ventas{IdVenta=1,Fecha="10/12/2020",Importe=20.3,NumTarjeta="1234"},
                new Ventas{IdVenta=2,Fecha="10/12/2020",Importe=20.2,NumTarjeta="1234"},
                new Ventas{IdVenta=3,Fecha="10/12/2020",Importe=20.5,NumTarjeta="1234"},
                new Ventas{IdVenta=4,Fecha="10/12/2020",Importe=20.6,NumTarjeta="1234"}
            };

        }
        public IList<Ventas> Ventas
        {
            get { return VentasList; }
            set { VentasList = (List<Ventas>)value; }
        }

        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }
        private class Updater : ICommand
        {
            public event EventHandler CanExecuteChanged;
            #region ICommand Members
            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                throw new NotImplementedException();
            }
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {

        }

        #endregion
    }
}
