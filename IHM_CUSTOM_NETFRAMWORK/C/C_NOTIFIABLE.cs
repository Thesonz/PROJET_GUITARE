using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace IHM_CUSTOM_NETFRAMWORK.C
{
    public class C_NOTIFIABLE : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Signale_Changement([CallerMemberName] string P_Nom_Propriete = null)
        {
            if (PropertyChanged != null) PropertyChanged.Invoke(this, new PropertyChangedEventArgs(P_Nom_Propriete));
        }
    }
    }
