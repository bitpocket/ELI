using System.Runtime.InteropServices;

namespace ELI
{
    /// <summary>
    /// obiekt przechowuje dane o badaniu
    /// </summary>
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("ELI.ExaminationVO")]
    public class ExaminationVO
    {
        /// <summary>
        /// nazwa
        /// Maksymalnie 150 znaków
        /// </summary>
        public string name;

        /// <summary>
        /// Kod opisujący dane badanie zgodne ze słownikiem badań systemu Erlab
        /// Maksymalnie 10 znaków
        /// </summary>
        public string code;

        /// <summary>
        /// Priorytet badania 
        /// </summary>
        public PriorytetType priorytet;

        /// <summary>
        /// Taryfa badania
        /// Maksymalnie 100 znaków
        /// </summary>
        public string rate;

        /// <summary>
        /// Flaga czy dostarczono materiał do badania 
        /// </summary>
        public bool specimenCollected;
    }
}