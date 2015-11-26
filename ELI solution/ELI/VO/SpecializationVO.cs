using System.Runtime.InteropServices;

namespace ELI
{
    /// <summary>
    /// obiekt przechowuje dane o specjalizacji lekarza
    /// </summary>
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("ELI.SpecializationVO")]
    public class SpecializationVO
    {
        /// <summary>
        /// Unikalny kod specjalizacji
        /// 6 cyfr
        /// </summary>
        public string specializationCode;

        /// <summary>
        /// Nazwa Specializacji
        /// Maksymalnie 50 znaków
        /// </summary>
        public string specializationName;
    }
}