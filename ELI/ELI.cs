using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ELI
{

    [Guid("C4B4BD32-01F4-4609-9B46-020A48A7EE06")]
    [ComVisible(true)]
    public interface IFoo
    {
        string DoFoo();
    }

    [ClassInterface(ClassInterfaceType.AutoDual)]
    [Guid("737C975F-C910-45E5-89B3-2A53991FB0F2")]
    [ComVisible(true)]
    [ProgId("ELI.Foo")]
    public class Foo : IFoo
    {
        public Foo()
        {
        }

        public string DoFoo()
        {
            return "some foo";
        }
    }


    [ClassInterface(ClassInterfaceType.AutoDual)]
    [Guid("7C82DE98-324C-48B3-B51D-03F785D6B6B9")]
    [ComSourceInterfaces(typeof(MyEvents))]
    [ComVisible(true)]
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

        public string HelloWorld(string name)
        {
            return "Hello World " + name;
        }
    }

    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    [Guid("6339B265-EC1A-4444-AF9E-A11CB2FD530A")]
    [ComVisible(true)]
    public interface MyEvents
    {
        //the comm interface for the eventhandler IsCompleted
        //On the client (VFP) side we use the command EVENTHANDLER and the
        //pubblic OLE class MyEvents to comunicate with the COM generated from this class
        [DispId(1)]
        void IsCompleted(object source, string respStr, bool icComplete);
    }
}
