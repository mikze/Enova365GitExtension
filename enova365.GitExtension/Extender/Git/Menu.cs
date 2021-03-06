﻿#define GIT

using Soneta.Business;
using Soneta.Business.App;

using Soneta.Business.UI;
using enova365.GitExtension.Extender.Git;



#if GIT
// Sposób w jaki należy zarejestrować page który będzie wyswietlany jako folderw interfejsie.
[assembly: FolderView("enova365.GitExtension/GitExtension",
    Priority = 100000,
    Description = "BLOBLALSA",
    ObjectType = typeof(FormProps),
    ObjectPage = "Notowania.Ogolne.pageform.xml",
    ReadOnlySession = false,
    BrickColor = FolderViewAttribute.BlackBrick,
    ConfigSession = false
)]

[assembly: FolderView("enova365.GitExtension/GitExtension2",
    Priority = 100001,
    Description = "NOWE OKNO!",
    ObjectType = typeof(FormProps),
    ObjectPage = "Notowania.Ogolne2.pageform.xml",
    ReadOnlySession = false,
    BrickColor = FolderViewAttribute.GreenBrick,
    ConfigSession = false
)]

[assembly: FolderView("enova365.GitExtension/GitExtension3",
    Priority = 100002,
    Description = "NOWE OKNO!2",
    ObjectType = typeof(FormProps),
    ObjectPage = "Notowania.Ogolne3.pageform.xml",
    ReadOnlySession = false,
    BrickColor = FolderViewAttribute.YellowBrick,
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