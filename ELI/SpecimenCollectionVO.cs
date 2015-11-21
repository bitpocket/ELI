using System;
using System.Runtime.InteropServices;

namespace ELI
{
    /// <summary>
    /// obiekt przechowuje dane o pobraniu próbek
    /// </summary>
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("ELI.SpecimenCollectionVO")]
    public class SpecimenCollectionVO
    {
        /// <summary>
        /// Numer partii próbek
        /// Maksymalnie 20 znaków
        /// </summary>
        public string lotNumber;

        /// <summary>
        /// Data i godzina pobrania materiału do badań
        /// </summary>
        public DateTime collectionTime;

        /// <summary>
        /// Osoba pobierająca materiał do badań
        /// </summary>
        public MedicalStaffVO collectedBy;

        /// <summary>
        /// Dane placówki pobierającej 
        /// </summary>
        public ContractorVO institution;

        /// <summary>
        /// Dzienna ilość moczu wyrażona w ml
        /// 1-10000
        /// </summary>
        public int dzm;

        /// <summary>
        /// Waga pacjenta wyrażona w kg
        /// 1-500
        /// </summary>
        public double weight;
    }
}