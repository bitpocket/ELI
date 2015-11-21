using System.Runtime.InteropServices;

namespace ELI
{
    /// <summary>
    /// obiekt identyfikator pacjenta
    /// </summary>
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    [ProgId("ELI.PatientIdVO")]
    public class PatientIdVO
    {
        /// <summary>
        /// Typ identyfikatora pacjenta.
        /// </summary>
        public IdType type;

        /// <summary>
        /// Wartość identyfikatora
        /// Wartość w/w pola. Zawiera skrót md5 numeru identyfikacyjnego , numer identyfikacyjny przed utworzeniem skrótu nie może zawierać spacji, myślników, itp. (powinny zostać same cyfry i litery)
        /// </summary>
        public string Value;
    }
}
