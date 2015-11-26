namespace ELI
{
    public class ExampleAPIProxy
    {
        private static string Uri = "http://elitest.azurewebsites.net/ELIWebService.asmx";
        //    private static WebService ExampleAPI = new WebService("http://.../example.asmx");    // DEFAULT location of the WebService, containing the WebMethods
        private static WebServiceCustom ExampleAPI = new WebServiceCustom(Uri);    // DEFAULT location of the WebService, containing the WebMethods


        public static void ChangeUrl(string webserviceEndpoint)
        {
            ExampleAPI = new WebServiceCustom(webserviceEndpoint);
        }

        public static string ExampleWebMethod(string name, int number)
        {
            ExampleAPI.PreInvoke();

            ExampleAPI.AddParameter("name", name);                    // Case Sensitive! To avoid typos, just copy the WebMethod's signature and paste it
            ExampleAPI.AddParameter("number", number.ToString());     // all parameters are passed as strings
            try
            {
                ExampleAPI.Invoke("ExampleWebMethod");                // name of the WebMethod to call (Case Sentitive again!)
            }
            finally { ExampleAPI.PosInvoke(); }

            return ExampleAPI.ResultString;                           // you can either return a string or an XML, your choice
        }

        public static string HelloWord(string name)
        {
            ExampleAPI.PreInvoke();

            ExampleAPI.AddParameter("param", name);

            try
            {
                ExampleAPI.Invoke("HelloWorld");                // name of the WebMethod to call (Case Sentitive again!)
            }
            finally
            {
                ExampleAPI.PosInvoke();
            }

            return ExampleAPI.ResultString;                           // you can either return a string or an XML, your choice
        }

        //public static PatientWithOrderListVO getPatientWithOrderListBy(PatientIdVO patientIdVO)
        //{
        //    ExampleAPI.PreInvoke();

        //    ExampleAPI.AddParameter("patientIdVO", patientIdVO);

        //    try
        //    {
        //        ExampleAPI.Invoke("getPatientWithOrderListBy");                        // name of the WebMethod to call (Case Sentitive again!)
        //    }
        //    finally
        //    {
        //        ExampleAPI.PosInvoke();
        //    }

        //    return ExampleAPI.ResultString;                           // you can either return a string or an XML, your choice
        //}
    }
}
