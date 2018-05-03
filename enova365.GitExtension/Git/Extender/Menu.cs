#define EXAMPLE8

using enova365.GitExtension.Git.Extender;
using Soneta.Business.UI;

#if EXAMPLE8

[assembly: FolderView("Soneta.Examples/Notowania GPW",
    Priority = 13,
    Description = "Przykład pokazujący programistyczne możliwości kolorowania wierszy",
    ObjectType = typeof(Notowania),
    ObjectPage = "Notowania.Ogolne.pageform.xml",
    ReadOnlySession = false,
    ConfigSession = false
)]

#endif