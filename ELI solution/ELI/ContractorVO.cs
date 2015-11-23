using System.Runtime.InteropServices;

namespace ELI
{
    /// <summary>
    /// obiekt przechowuje dane o kontrahencie
    /// </summary>
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("ELI.ContractorVO")]
    public class ContractorVO
    {
        /// <summary>
        /// regon
        /// 9 lub 14 cyfr, suma kontrolna
        /// </summary>
        public string regon;

        /// <summary>
        /// Adres kontrahenta
        /// </summary>
        public AddressVO address;

        /// <summary>
        /// Nazwa kontrahenta
        /// Maksymalnie 200 znaków
        /// </summary>
        public string name;

        /// <summary>
        /// Unikatlny numer kontrahenta
        /// W przypadku HCI - zgodnie z kodem świadczeniodawcy. Lab - ciąg downolnych znaków MAX 100 
        /// </summary>
        public string institutionId;
    }
}