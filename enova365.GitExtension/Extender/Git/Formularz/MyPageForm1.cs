using Soneta.Business;
using Soneta.Business.App;

using enova365.GitExtension.Extender.Git.Formularz;


// Sposób w jaki należy zarejestrować extender, który później zostanie użyty w interfejsie.
[assembly: Worker(typeof(MyPageForm1))]



namespace enova365.GitExtension.Extender.Git.Formularz
{
    public class MyPageForm1
    {
        [Context]
        public Session Session { get; set; }

        [Context]
        public Login Login { get; set; }
    }
}
