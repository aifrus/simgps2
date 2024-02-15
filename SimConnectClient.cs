

using Microsoft.FlightSimulator.SimConnect;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Aifrus.SimGPS2
{
    public class SimConnectClient
    {
        private SimConnect my_simconnect;
        public const int WM_USER_SIMCONNECT = 0x402;
        private readonly FormMain FormMain;

        private enum DATA_REQUESTS
        {
            REQUEST_1
        }

        private enum DEFINITIONS
        {
            Struct1
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct Struct1
        {
            public double latitude;
            public double longitude;
            public double magCourse;
            public double altitude;
            public double verticalSpeed;
            public double groundSpeed;
        }

        public SimConnectClient(FormMain formMain)
        {
            FormMain = formMain;

        }

        public void Connect(string Hostname = "localhost", int Port = 500, string Protocol = "IPv4", int MaxReceiveSize = 4096, int DisableNagle = 0)
        {
            string FileContent = "[SimConnect]\nProtocol=" + Protocol + "\nPort=" + Port + "\nAddress=" + Hostname + "\nMaxReceiveSize=" + MaxReceiveSize + "\nDisableNagle=" + DisableNagle;
            System.IO.File.WriteAllText("SimConnect.cfg", FileContent);
            my_simconnect = new SimConnect("Managed Data Request", FormMain.Handle, WM_USER_SIMCONNECT, null, 0);
            InitDataRequest();
        }

        public void Disconnect()
        {
            if (my_simconnect != null)
            {
                my_simconnect.Dispose();
                my_simconnect = null;
            }
        }

        private void InitDataRequest()
        {
            try
            {
                my_simconnect.OnRecvOpen += new SimConnect.RecvOpenEventHandler(SimConnect_OnRecvOpen);
                my_simconnect.OnRecvQuit += new SimConnect.RecvQuitEventHandler(SimConnect_OnRecvQuit);
                my_simconnect.OnRecvException += new SimConnect.RecvExceptionEventHandler(SimConnect_OnRecvException);
                my_simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Plane Latitude", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                my_simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Plane Longitude", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                my_simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Plane Heading Degrees Magnetic", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                my_simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Plane Altitude", "meters", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                my_simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Vertical Speed", "meters per minute", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                my_simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Ground Velocity", "meters per second", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                my_simconnect.RegisterDataDefineStruct<Struct1>(DEFINITIONS.Struct1);
                my_simconnect.OnRecvSimobjectDataBytype += new SimConnect.RecvSimobjectDataBytypeEventHandler(SimConnect_OnRecvSimobjectDataBytype);
            }
            catch (COMException exception1)
            {
                MessageBox.Show(exception1.Message);
            }
        }

        private void SimConnect_OnRecvException(SimConnect sender, SIMCONNECT_RECV_EXCEPTION data)
        {
            MessageBox.Show(FormMain, "Exception received: " + data.dwException, "SimConnect Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void SimConnect_OnRecvOpen(SimConnect sender, SIMCONNECT_RECV_OPEN data)
        {
            FormMain.SimConnected();
        }

        private void SimConnect_OnRecvQuit(SimConnect sender, SIMCONNECT_RECV data)
        {
            Disconnect();
            FormMain.SimDisconnected();
        }

        private void SimConnect_OnRecvSimobjectDataBytype(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA_BYTYPE data)
        {
            if (data.dwRequestID != 0) return;
            Struct1 struct1 = (Struct1)data.dwData[0];
            FormMain.UpdateSimData(struct1);
        }

        public void RequestData()
        {
            my_simconnect?.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_1, DEFINITIONS.Struct1, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);
        }

        public void ReceiveMessage()
        {
            my_simconnect?.ReceiveMessage();
        }
    }

}
