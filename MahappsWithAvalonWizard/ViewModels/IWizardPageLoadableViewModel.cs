using System.Windows.Input;

namespace MahappsWithAvalonWizard
{
    public interface IWizardPageLoadableViewModel
    {
        ICommand LoadedCommand { get; set; }
    }
}