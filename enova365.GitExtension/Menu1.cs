#define OKNO_GLOWNE

using Soneta.Business.Licence;
using Soneta.Business.UI;



#if OKNO_GLOWNE

[assembly: FolderView("enova365.GitExtension",
    Priority = 10,
    Description = "Git Extension",
    BrickColor = FolderViewAttribute.BlackBrick,
    Icon = "enova365.GitExtension.Utils.Icon.ico;enova365.GitExtension",
    Contexts = new object[] { LicencjeModułu.All }
)]

#endif