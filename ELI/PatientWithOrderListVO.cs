using System.Collections.Generic;

namespace ELI
{
    /// <summary>
    /// obiekt przechowuje dane o pojedynczym zleceniu danego pacjenta
    /// </summary>
    public class PatientWithOrderListVO
    {
        /// <summary>
        /// Obiekt zawierający  dane pacjenta
        /// </summary>
        public PatientVO patient;

        /// <summary>
        /// Lista zleceń 
        /// </summary>
        public List<OrderVO> orders;
    }
}
