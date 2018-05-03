#define GIT

using Soneta.Business;
using Soneta.Business.App;

using Soneta.Business.UI;
using enova365.GitExtension.Extender.Git;



#if GIT
// Sposób w jaki należy zarejestrować page który będzie wyswietlany jako folderw interfejsie.
[assembly: FolderView("enova365.GitExtension/GitExtension",
    Priority = 100000,
    Description = "BLOBLALSA",
    ObjectType = typeof(Notowania),
    ObjectPage = "Notowania.Ogolne.pageform.xml",
    ReadOnlySession = false,
    BrickColor = FolderViewAttribute.BlackBrick,
    ConfigSession = false
)]

namespace enova365.GitExtension.Extender.Git
{
    public class Menu
    {
        [Context]
        public Session Session { get; set; }

        [Context]
        public Login Login { get; set; }


    }
}

#endif