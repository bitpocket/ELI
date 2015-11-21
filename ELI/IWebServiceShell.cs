using System.Runtime.InteropServices;

namespace ELI
{
    /// <summary>
    /// 
    /// </summary>
    public interface IWebServiceShell
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="patientIdVO"></param>
        /// <returns></returns>
        PatientWithOrderListVO getPatientWithOrderListBy(PatientIdVO patientIdVO);
    }
}