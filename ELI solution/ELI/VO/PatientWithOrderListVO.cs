using System.Runtime.InteropServices;

namespace ELI
{
    /// <summary>
    /// obiekt przechowuje dane o pojedynczym zleceniu danego pacjenta
    /// </summary>
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("ELI.PatientWithOrderListVO")]
    public class PatientWithOrderListVO
    {
        /// <summary>
        /// Obiekt zawierający  dane pacjenta
        /// </summary>
        public PatientVO patient;

        /// <summary>
        /// Lista zleceń 
        /// </summary>
        public OrderVO[] orders;
    }
}
