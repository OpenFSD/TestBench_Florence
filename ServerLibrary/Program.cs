//ServerLibrary
using System;
using System.Threading;

namespace ServerLibrary
{
    class Program
    {
        private static bool isThread_CaptureInputAction_Inisialised = true, isThread_SendOutputResult_Inisialised = true;
        private static Thread captureInputAction;
        private static Thread sendOutputResult;

        static void Main(string[] args)
        {
            Console.WriteLine("started => Main()");
            Florence.Server_IO.Library.Create_Hosting_Server();
            Console.WriteLine("created => Server Library");
            captureInputAction = new Thread(Thread_CaptureInputAction);
            captureInputAction.Start();
            sendOutputResult = new Thread(Thread_SendOutputResult);
            sendOutputResult.Start();

            while (GetFlag_SystemInitialised() == true)
            {

            }
            Console.WriteLine("system initialised");
            Thread_CaptureInputAction();//SIMULATION

            while (true)
            {

            }
        }

        private static void Thread_CaptureInputAction()
        {
            Console.WriteLine("started SIMULATION => Thread_CaptureInputAction");
            isThread_CaptureInputAction_Inisialised = false;
            while (GetFlag_SystemInitialised() == true)
            {

            }
            Florence.Server_IO.PraiseEvents.Set_PraiseEventId((byte)0);
            Florence.Server_IO.PraiseEvents.Set_Praise1_mousePos_X((Int16)0);
            Florence.Server_IO.PraiseEvents.Set_Praise1_mousePos_Y((Int16)100);
            Florence.Server_IO.Library.Flip_InBufferToWrite();
            Florence.Server_IO.Library.Push_Stack_InputPraises();
        }

        private static void Thread_SendOutputResult()
        {
            Console.WriteLine("started => Thread_SendOutputResult");
            isThread_SendOutputResult_Inisialised = false;
            while (GetFlag_SystemInitialised() == true)
            {

            }
            while (Florence.Server_IO.Library.Get_Flag_IsStackLoaded_Server_OutputRecieve() == true)
            {
                Florence.Server_IO.WriteEnable_Stack_Server_OutputSend.Request_Write_Stack_Server_OutputSend(0);

            }
        }

        private static bool GetFlag_SystemInitialised()
        {
            bool isInitalised = false;
            if (Florence.Server_IO.Library.GetFlag_Server_Library_Initialised() == true)
            {
                isInitalised = true;
            }
            if (isThread_CaptureInputAction_Inisialised == true)
            {
                isInitalised = true;
            }
            if (isThread_SendOutputResult_Inisialised == true)
            {
                isInitalised = true;
            }
            return isInitalised;
        }
    }
}