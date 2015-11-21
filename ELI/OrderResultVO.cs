using System.Runtime.InteropServices;

namespace ELI
{
    /// <summary>
    /// obiekt przechowuje dane o wynikach badań danego zlecenia
    /// </summary>
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("ELI.OrderResultVO")]
    public class OrderResultVO
    {
        /// <summary>
        /// identyfikator zlecenia
        /// kod świadczeniodawcylub regon (prywatne placówki) + ‘-’ + kolejny nr zlecenia
        /// w placówce  medycznej, maksymalnie 50 znaków
        /// </summary>
        public string orderId;

        /// <summary>
        /// Obiekt zawierający informacje o kontrahencie
        /// </summary>
        public ContractorVO contractorVO;

        /// <summary>
        /// Lista wyników badań
        /// Wymagane conajmniej jedno z pól: examinationsResults lub resultDocuments
        /// </summary>
        public ExaminationResultVO[] examinationsResults;

        /// <summary>
        /// Lista skompresowanych zbiorów plików z wynikami
        /// Wymagane  conajmniej jedno z pól: examinationsResults lub resultDocuments
        /// </summary>
        public ResultDocumentVO[] resultDocuments;
    }
}