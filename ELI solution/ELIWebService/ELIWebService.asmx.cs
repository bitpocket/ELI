using ELI;
using System;
using System.Web.Services;

namespace ELIWebService
{
    /// <summary>
    /// Summary description for ELIWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ELIWebService : WebService
    {

        [WebMethod]
        public string HelloWorld(string param)
        {
            return "Hello World " + param;
        }

        [WebMethod]
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
                    id = "ws test id 1",
                    orderTime = DateTime.Now,
                    specimenCollection = new SpecimenCollectionVO() { },
                    valuableClinicInfo = "ws test klinc data 1"
                },

                new OrderVO()
                {
                    contractor = new ContractorVO() { },
                    doctor = new DoctorVO() { },
                    examination = new ExaminationVO[]
                    {
                        new ExaminationVO() { }
                    },
                    id = "ws test id 2",
                    orderTime = DateTime.Now,
                    specimenCollection = new SpecimenCollectionVO() { },
                    valuableClinicInfo = "ws test klinc data 2"
                }
            };

            return res;
        }
    }
}
