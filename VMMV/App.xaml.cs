using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using VMMV.ViewModel;

namespace VMMV
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        
    protected override void OnStartup(StartupEventArgs e)    
    {    
        base.OnStartup(e);    
        VMMV.View.MainPageArticulos window = new View.MainPageArticulos();    
        ArticlosViewModel VM = new ArticlosViewModel();    
        window.DataContext = VM;    
        window.Show();    
    }  

    }
}
