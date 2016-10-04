using AvalonWizard.Mvvm;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MahappsWithAvalonWizard
{
    public class LastPageViewModel : WizardPageViewModelBase
    {
        public LastPageViewModel()
        {
            Header = "Last Page";
            Subtitle = "This is a test project for Mahapps and Avalon.Wizard";

            InitializeCommand = new RelayCommand<object>(ExecuteInitialize);
        }

        private async void ExecuteInitialize(object parameter)
        {
            var dialog = DialogCoordinator.Instance;
            var settings = new MetroDialogSettings()
            {
                ColorScheme = MetroDialogColorScheme.Accented
            };

            await dialog.ShowMessageAsync(this, "Hello World", "This dialog is triggered from Avalon.Wizard InitializeCommand", MessageDialogStyle.Affirmative, settings);
        }
    }
}
