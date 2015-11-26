using System.Runtime.InteropServices;

namespace ELI
{
    /// <summary>
    /// obiekt przechowuje dane o osobie personelu medycznego
    /// </summary>
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("ELI.MedicalStaffVO")]
    public class MedicalStaffVO
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
        /// numer prawa wykonywania zawodu. 
        /// dla lekarza 7 cyfr. 
        /// dla pielęgniarki: 7 cyfr lub 7 cyfr + 1 litera A lub P
        /// </summary>
        public string pzw;

        /// <summary>
        /// zawód
        /// </summary>
        public ProfessionType type;
    }
}