using System;
using System.Runtime.InteropServices;

namespace ELI
{
    /// <summary>
    /// obiekt przechowuje informacje o dokumencie i jego zawartość. 
    /// Przesłane dokumenty muszą zostać wcześniej dodany do archiwum zip. 
    /// Archiwum powinno zostać skompresowane zgodnie z formatem ZIP. 
    /// W systemach typu UNIX/LINUX służy do tego komenda zip. 
    /// Zawartość pliku powinna być zaszyfrowana za pomocą tej samej metody jak dane pacjenta 
    /// z wykorzystaniem tego samego klucza.
    /// </summary>
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("ELI.ResultDocumentVO")]
    public class ResultDocumentVO
    {
        /// <summary>
        /// Unikalny identyfikator dokumentu
        /// Maksymalnie 50 znaków
        /// </summary>
        public string id;

        /// <summary>
        /// Zawartość dokumentu (typ Java DataHandler)
        /// (w przypadku statusu NEW)
        /// </summary>
        public byte[] content;

        /// <summary>
        /// Status dokumentu
        /// </summary>
        public StatusType status;

        /// <summary>
        /// Komentarz – np. przyczyna unieważnienia
        /// Maksymalnie 50 znaków
        /// </summary>
        public string comment;

        /// <summary>
        /// Data unieważnienia
        /// (przypadku statusu CANCELLED)
        /// </summary>
        public DateTime cancelDate;
    }
}