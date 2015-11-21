using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ELI
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [Guid("737C975F-C910-45E5-89B3-2A53991FB0F2")]
    [ComVisible(true)]
    [ProgId("ELI.SomeClass")]
    public class WebServiceShell
    {

        /// <summary>
        /// L pobiera swój identyfikator w Erlab. Jest to metoda testowa i powinna być wykorzystywana do początkowego testowania komunikacji za pomocą Web Serviców
        /// </summary>
        /// <returns>Identyfikator laboratorium w systemie Erlab</returns>
        public string getLabId()
        {
            return "test web service";
        }

        /// <summary>
        /// Laboratorium pobiera zlecenia wykonania badań z serwera ErLab wykorzystując identyfikator pacjenta. W rezultacie otrzymuje wszystkie niegotowe skierowania danego pacjenta z ostatniego miesiąca. Skierowania za pomocą tej metody są pobierane wielokrotnie. 
        /// </summary>
        /// <param name="patientIdVO">Identyfikator pacjenta. Zgodny z opisem PatientIdVO.</param>
        /// <returns>zbiór obiektów zleceń</returns>
        public PatientWithOrderListVO getPatientWithOrderListBy(PatientIdVO patientIdVO)
        {
            PatientWithOrderListVO res = new PatientWithOrderListVO();

            res.orders = new List<OrderVO>();

            res.orders.Add(
                new OrderVO()
                {
                    contractor = new ContractorVO() { },
                    doctor = new DoctorVO() { },
                    examination = new List<ExaminationVO>()
                    {
                        new ExaminationVO() { }
                    },
                    id = "test id",
                    orderTime = DateTime.Now,
                    specimenCollection =  new SpecimenCollectionVO() { },
                    valuableClinicInfo = "testowe dane kliniczne"                    
                });

            return res;
        }
    }
}
