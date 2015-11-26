using System.Runtime.InteropServices;

namespace ELI
{
    /// <summary>
    /// obiekt przechowuje dane adresowe
    /// </summary>
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("ELI.AddressVO")]
    public class AddressVO
    {
        /// <summary>
        /// nazwa ulicy
        /// Maksymalnie 80 znaków
        /// </summary>
        public string street;

        /// <summary>
        /// kod pocztowy
        /// Format: xx-xxx
        /// </summary>
        public string postcode;

        /// <summary>
        /// miasto
        /// Maksymalnie 30 znaków
        /// </summary>
        public string city;

        /// <summary>
        /// Kod terytorialny
        /// </summary>
        public int codeTeryt;

        /// <summary>
        /// nr domu
        /// Maksymalnie 5 cyfr/znaków
        /// </summary>
        public string houseNumber;

        /// <summary>
        /// nr mieszkania
        /// Maksymalnie 5 cyfr/znaków
        /// </summary>
        public string apartamentNumber;
    }
}