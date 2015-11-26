using System;
using System.Runtime.InteropServices;

namespace ELI
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ProgId("ELI.WebServiceShell")]
    public class WebServiceShell
    {
        /// <summary>
        /// Laboratorium pobiera zlecenia wykonania badań z serwera ErLab 
        /// wykorzystując identyfikator pacjenta. 
        /// W rezultacie otrzymuje wszystkie niegotowe skierowania danego pacjenta z ostatniego miesiąca. 
        /// Skierowania za pomocą tej metody są pobierane wielokrotnie. 
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

        /// <summary>
        /// Laboratorium pobiera skierowania dla laboratorium 
        /// w zależności od trybu w jakim działa aplikacja. 
        /// W trybie centralnym pobrane zostają wszystkie skierowania 
        /// które nie są gotowe ( nie mają jeszcze wyników ).
        /// W trybie zdecentalizowanym zostają pobrane wszystkie niegotowe skierowania 
        /// kierowane do tego laboratorium, które wywołuje metodę.  
        /// W obydwu trybach pobierane są skierowania, które zostały dodane nie wcześniej niż 30 dni temu.
        /// </summary>
        /// <returns>Lista zleceń badań  pogrupowana po pacjencie</returns>
        public PatientWithOrderListVO[] getAllReferrals()
        {
            return new PatientWithOrderListVO[] { };
        }

        /// <summary>
        /// Metoda działa bardzo podobnie jak metoda getAllReferrals z tą różnicą, 
        /// że pobrane skierowania są oznaczane w systemie i nie są ponownie wysyłane do laboratorium.
        /// </summary>
        /// <returns>Lista zleceń badań  pogrupowana po pacjencie</returns>
        public PatientWithOrderListVO[] getAllNewReferrals()
        {
            return new PatientWithOrderListVO[] { };
        }

        /// <summary>
        /// L pobiera swój identyfikator w Erlab.
        /// Jest to metoda testowa i powinna być wykorzystywana 
        /// do początkowego testowania komunikacji za pomocą Web Serviców
        /// </summary>
        /// <returns>Identyfikator laboratorium w systemie Erlab</returns>
        public string getLabId()
        {
            return "test lab id";
        }

        /// <summary>
        /// L dodaje wyniki badań. 
        /// Możliwe jest wielokrotne dodanie tych samych wyników badań. 
        /// W takiej sytuacji istniejące wyniki badań są dodawane do archiwum 
        /// ale dalej istnieją w systemie, a nowe wyniki zastępują stare.
        /// </summary>
        /// <returns></returns>
        public string add(OrderResultListVO orderList)
        {
            return orderList.ordersResults.Length.ToString();
        }
    }
}
