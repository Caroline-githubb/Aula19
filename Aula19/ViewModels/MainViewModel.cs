using Caliburn.Micro;
using Aula19.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula19.ViewModels
{
    public class MainViewModel : Screen
    {
        private string nomeCompleto = string.Empty;

        public string NomeCompleto
        {
            get
            {
                return nomeCompleto;
            }
            set
            {
                nomeCompleto = value;
                // Observa se o atributo/instância FirstName recebeu alguma atualização.
                base.NotifyOfPropertyChange(() => NomeCompleto);
            }
        }
    }
}
