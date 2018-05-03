using Soneta.Business;
using Soneta.Business.App;

using Soneta.Business.UI;
using enova365.GitExtension.Extender;




// Sposób w jaki należy zarejestrować page który będzie wyswietlany jako folderw interfejsie.
[assembly: FolderView("GitExtension",
    Priority = 100000,
    Description = "GitExtension",
    ObjectType = typeof(Menu),
    ReadOnlySession = false,
    Icon = "enova365.GitExtension.Utils.Icon.ico;enova365.GitExtension",
    BrickColor = FolderViewAttribute.BlackBrick,
    ConfigSession = false
)]

namespace enova365.GitExtension.Extender
{
    public class Menu
    {
        [Context]
        public Session Session { get; set; }

        [Context]
        public Login Login { get; set; }
    }
}
