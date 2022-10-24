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
    class DependientesViewModel
    {
        private List<Dependiente> DependientesList;

        public DependientesViewModel()
        {
            DependientesList = new List<Dependiente>
            {
                new Dependiente{SegSocial = "1", Nombre = "Pepe", Apellido1 = "Martinez", Apellido2 = "Garcia", Comision = 10},
                new Dependiente{SegSocial = "2", Nombre = "Juan Miguel", Apellido1 = "Rodriguez", Apellido2 = "Garcia", Comision = 10},
                new Dependiente{SegSocial = "3", Nombre = "Rebeca", Apellido1 = "Ochoa", Apellido2 = "Garcia", Comision = 10},
                new Dependiente{SegSocial = "4", Nombre = "Zulema", Apellido1 = "Ibarraguren", Apellido2 = "Garcia", Comision = 10},
                new Dependiente{SegSocial = "5", Nombre = "Mario", Apellido1 = "Castillo", Apellido2 = "Garcia", Comision = 10},
                new Dependiente{SegSocial = "6", Nombre = "Bernarda", Apellido1 = "Martinez", Apellido2 = "Garcia", Comision = 10}
            };
        }

        public IList<Dependiente> Dependientes
        {
            get{return DependientesList; }
            set{DependientesList = (List<Dependiente>)value;}
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
