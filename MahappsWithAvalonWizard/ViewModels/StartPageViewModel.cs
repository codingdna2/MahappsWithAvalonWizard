using AvalonWizard.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahappsWithAvalonWizard
{
    public class StartPageViewModel : WizardPageViewModelBase
    {
        public StartPageViewModel()
        {
            Header = "Start Page";
            Subtitle = "This is a test project for Mahapps and Avalon.Wizard";
        }
    }
}
