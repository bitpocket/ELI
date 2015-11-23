using System.Runtime.InteropServices;

namespace ELI
{
    /// <summary>
    /// obiekt przechowuje dane o lekarzu
    /// </summary>
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("ELI.DoctorVO")]
    public class DoctorVO
    {
        /// <summary>
        /// imię
        /// Maksymalnie 30 znaków
        /// </summary>
        public string firstName;

        /// <summary>
        /// drugie imię
        /// Maksymalnie 30 znaków
        /// </summary>
        public string secondName;

        /// <summary>
        /// nazwisko
        /// Maksymalnie 50 znaków
        /// </summary>
        public string surname;

        /// <summary>
        /// Numer prawa wykonywania zawodu. 
        /// 7 cyfr
        /// </summary>
        public string pzw;

        /// <summary>
        /// Zbiór specjalizacji jakie posiada dany lekarz
        /// </summary>
        public SpecializationVO[] specializations;
    }
}