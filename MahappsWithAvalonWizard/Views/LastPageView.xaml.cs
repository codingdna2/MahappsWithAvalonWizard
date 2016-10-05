using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls.Dialogs;

namespace MahappsWithAvalonWizard
{
    /// <summary>
    /// Interaction logic for LastPageView.xaml
    /// </summary>
    public partial class LastPageView : UserControl
    {
        public LastPageView()
        {
            InitializeComponent();
            this.Loaded += (sender, args) =>
            {
                DialogParticipation.SetRegister(this, this.DataContext);
                ((IWizardPageLoadableViewModel) this.DataContext).LoadedCommand.Execute(this);
            };
            // if using DialogParticipation on Windows which open / close frequently you will get a
            // memory leak unless you unregister.  The easiest way to do this is in your Closing/ Unloaded
            // event, as so:
            //
            // DialogParticipation.SetRegister(this, null);
            this.Unloaded += (sender, args) => { DialogParticipation.SetRegister(this, null); };
        }
    }
}