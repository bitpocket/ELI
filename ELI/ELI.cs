using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ELI
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComSourceInterfaces(typeof(MyEvents))]
    [ProgId("ELI.WebServiceShell")]
    public class WebServiceShell
    {
        /// <summary>
        /// GetPersons form web service
        /// </summary>
        /// <returns>retrun list of persons</returns>
        public List<string> GetPendingReferral()
        {
            List<string> result = new List<string>();

            result.Add("Person1");
            result.Add("Person2");
            result.Add("Person3");

            return result;
        }

        /// <summary>
        /// SendExaminationResults to the web service 
        /// </summary>
        /// <param name="data">data if examination results</param>
        /// <returns>true or false depends on succed</returns>
        public Boolean SendExaminationResults(string data)
        {
            return true;
        }
    }

    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface MyEvents
    {
        //the comm interface for the eventhandler IsCompleted
        //On the client (VFP) side we use the command EVENTHANDLER and the
        //pubblic OLE class MyEvents to comunicate with the COM generated from this class
        [DispId(1)]
        void IsCompleted(object source, string respStr, bool icComplete);
    }
}
