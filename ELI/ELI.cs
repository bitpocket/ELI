using System;
using System.Runtime.InteropServices;

namespace ELI
{
    /// <summary>
    /// WebServiceShell
    /// </summary>
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("ELI.WebServiceShell")]
    public class WebServiceShell : IWebServiceShell
    {

        /// <summary>
        /// L pobiera swój identyfikator w Erlab. Jest to metoda testowa i powinna być wykorzystywana do początkowego testowania komunikacji za pomocą Web Serviców
        /// </summary>
        /// <returns>Identyfikator laboratorium w systemie Erlab</returns>
        //[ClassInterface(ClassInterfaceType.AutoDual)]
        public string getLabId()
        {
            return "test lab id";
        }

        /// <summary>
        /// Laboratorium pobiera zlecenia wykonania badań z serwera ErLab wykorzystując identyfikator pacjenta. W rezultacie otrzymuje wszystkie niegotowe skierowania danego pacjenta z ostatniego miesiąca. Skierowania za pomocą tej metody są pobierane wielokrotnie. 
        /// </summary>
        /// <param name="patientIdVO">Identyfikator pacjenta. Zgodny z opisem PatientIdVO.</param>
        /// <returns>zbiór obiektów zleceń</returns>
        public PatientWithOrderListVO getPatientWithOrderListBy(PatientIdVO patientIdVO)
        {
            PatientWithOrderListVO res = new PatientWithOrderListVO();

            res.orders = new OrderVO[] {
                new OrderVO()
                {
                    contractor = new ContractorVO() { },
                    doctor = new DoctorVO() { },
                    examination = new ExaminationVO[]
                    {
                        new ExaminationVO() { }
                    },
                    id = "test id 1",
                    orderTime = DateTime.Now,
                    specimenCollection = new SpecimenCollectionVO() { },
                    valuableClinicInfo = "test klinc data 1"
                },

                new OrderVO()
                {
                    contractor = new ContractorVO() { },
                    doctor = new DoctorVO() { },
                    examination = new ExaminationVO[]
                    {
                        new ExaminationVO() { }
                    },
                    id = "test id 2",
                    orderTime = DateTime.Now,
                    specimenCollection = new SpecimenCollectionVO() { },
                    valuableClinicInfo = "test klinc data 2"
                }
            };

            return res;
        }
    }
}
