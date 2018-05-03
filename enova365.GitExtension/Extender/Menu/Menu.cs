#define OKNO_GLOWNE

using Soneta.Business;
using Soneta.Business.App;
using Soneta.Business.UI;
using enova365.GitExtension.Extender;
using Soneta.Business.Licence;


#if OKNO_GLOWNE

// Sposób w jaki należy zarejestrować page który będzie wyswietlany jako folderw interfejsie.
[assembly: FolderView("enova365.GitExtension",
    Priority = 100000,
    Description = "JAJCO!",
    Icon = "enova365.GitExtension.Utils.Icon.ico;enova365.GitExtension",
    BrickColor = FolderViewAttribute.BlueBrick,
    Contexts = new object[] { LicencjeModułu.All }
)]

#endif