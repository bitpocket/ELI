using System.Runtime.InteropServices;

namespace ELI
{
    /// <summary>
    /// obiekt przechowuje dane o wyniku badania
    /// </summary>
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("ELI.ExaminationResultParameterVO")]
    public class ExaminationResultParameterVO
    {
        /// <summary>
        /// Opis wyników badania. 
        /// Może zawierać liczbę lub po prostu napis(POZYTYWNY, W NORMIE etc)
        /// Maksymalnie 5000 znaków
        /// </summary>
        public string result;

        /// <summary>
        /// Nazwa parametru wyniku
        /// Maksymalnie 150 znaków
        /// </summary>
        public string parametrName;

        /// <summary>
        /// Kod parametru wyniku 
        /// Maksymalnie 20 znaków
        /// </summary>
        public string parametrCode;

        /// <summary>
        /// Jednostka w jakiej wyrażany jest wynik badania
        /// Maksymalnie 100 znaków
        /// </summary>
        public string unit;

        /// <summary>
        /// Dolna granica normy. 
        /// Jest zależna od płci i wieku
        /// </summary>
        public double normFrom;

        /// <summary>
        /// Górna granica normy
        /// </summary>
        public double normTo;

        /// <summary>
        /// Wartości referencyjne dla parametru
        /// Maksymalnie 5000 znaków
        /// </summary>
        public string referenceValues;
    }
}