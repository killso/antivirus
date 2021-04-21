using System.ComponentModel;
using System.ServiceProcess;

namespace WindowsService
{
    [RunInstaller(true)]
    public partial class ServiceInstaller : System.Configuration.Install.Installer
    {
        public ServiceInstaller()
        {
            // InitializeComponent();
            serviceProcessInstaller = new ServiceProcessInstaller();
            serviceProcessInstaller.Account = ServiceAccount.LocalSystem;
            serviceInstaller1 = new System.ServiceProcess.ServiceInstaller();
            serviceInstaller1.ServiceName = "ServiceSherbakova";
            serviceInstaller1.DisplayName = "ServiceSherbakova";
            serviceInstaller1.Description = "ServiceSherbakova";
            serviceInstaller1.StartType = ServiceStartMode.Automatic;
            Installers.Add(serviceProcessInstaller);
            Installers.Add(serviceInstaller1);
        }
    }
}
