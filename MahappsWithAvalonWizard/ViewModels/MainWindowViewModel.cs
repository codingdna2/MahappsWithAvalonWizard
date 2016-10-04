using AvalonWizard.Mvvm;
using MahApps.Metro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MahappsWithAvalonWizard
{
    public class MainWindowViewModel
    {
        private readonly IWizardController wizardController = new WizardController();

        public MainWindowViewModel()
        {
            Pages = new List<object>
            {
                new StartPageViewModel(),
                new LastPageViewModel(),
            };

        }

        public IList<object> Pages { get; private set; }

        public IWizardController WizardController { get { return wizardController; } }

        public ICommand OnCancel { get { return new RelayCommand<object>((ExecuteCancel)); } }

        public ICommand OnFinish { get { return new RelayCommand<object>((ExecuteFinish)); } }

        public ICommand OnThemeSelector { get { return new RelayCommand<object>((ExecuteThemeSwitch)); } }

        public ICommand WindowClosing { get { return new RelayCommand<object>((ExecuteShutdown)); } }

        private void ExecuteCancel(object parameter)
        {
        }

        private void ExecuteFinish(object parameter)
        {
            Application.Current.Shutdown();
        }

        private void ExecuteThemeSwitch(object parameter)
        {
            var theme = ThemeManager.DetectAppStyle(Application.Current);
            string name = theme.Item1.Name == "BaseLight" ? "BaseDark" : "BaseLight";
            var appTheme = ThemeManager.GetAppTheme(name);
            ThemeManager.ChangeAppStyle(Application.Current, theme.Item2, appTheme);
        }

        private void ExecuteShutdown(object parameter)
        { 
        }

    }
}
