using Caliburn.Micro;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula19.ViewModels;

namespace Aula19
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            // Inicializa o projeto
            base.Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            // Define qual será o Controlador padrão
            // Nota: O controlador MainViewModel ainda não foi criado nessa etapa.
            base.DisplayRootViewFor<MainViewModel>();
        }
    }
}
