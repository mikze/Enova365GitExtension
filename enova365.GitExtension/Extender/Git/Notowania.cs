using System.Collections.Generic;

namespace enova365.GitExtension.Extender.Git
{

    public class Notowania
    {
        #region Property dla formularza

        public IEnumerable<Akcja> AktualneNotowania
        {
            get
            {
                var List = new List<Akcja>();

                var myJarray = GetInfo.Get();

                foreach(var It in myJarray)
                {
                    List.Add(new Akcja()
                    {
                        Nazwa = (string)It["name"]
                    });
                }
                    
                

                return List;
            }
        }

        #endregion Property dla formularza
    }

}
