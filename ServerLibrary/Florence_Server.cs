/*
*  Managed C# wrapper for FLORENCE Server library by Jasper Assembly Pty Ltd.
*  Copyright (c) 2022 - 2025 Brenton James Maddocks BEng(CompSys).  
*  All rights reserved.
*/
using System;
using System.Net;
using System.Net.Sockets;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Florence.Server_IO
{
    public static class ConcurrentQue
    {
        [DllImport("ServerLibrary_lib.dll", CharSet = CharSet.Unicode)]
        public static extern void Request_Wait_Launch_ConcurrentThread();
    }

    public static class WriteEnable
    {
        [DllImport("ServerLibrary_lib.dll", CharSet = CharSet.Unicode)]
        public static extern void ServerCallTo_Request_Write_Stack_Server_InputAction(byte coreId);

        [DllImport("ServerLibrary_lib.dll", CharSet = CharSet.Unicode)]
        public static extern void ServerCallTo_End_Write_Stack_Server_InputAction(byte coreId);

        [DllImport("ServerLibrary_lib.dll", CharSet = CharSet.Unicode)]
        public static extern bool ServerCallTo_Get_Flag_IsStackLoaded_Server_InputAction();

        [DllImport("ServerLibrary_lib.dll", CharSet = CharSet.Unicode)]
        public static extern void ServerCallTo_Request_Write_Stack_Server_OutputAction(byte coreId);

        [DllImport("ServerLibrary_lib.dll", CharSet = CharSet.Unicode)]
        public static extern void ServerCallTo_End_Write_Stack_Server_OutputAction(byte coreId);

        [DllImport("ServerLibrary_lib.dll", CharSet = CharSet.Unicode)]
        public static extern bool ServerCallTo_Get_Flag_IsStackLoaded_Server_OutputRecieve();
    }

    public static class Library
    {
        [DllImport("ServerLibrary_lib.dll", CharSet = CharSet.Unicode)]
        public static extern void ServerCallTo_Create_Hosting_Server();

        [DllImport("ServerLibrary_lib.dll", CharSet = CharSet.Unicode)]
        public static extern void ServerCallTo_Create_Write_Stack_Server_InputAction();

        [DllImport("ServerLibrary_lib.dll", CharSet = CharSet.Unicode)]
        public static extern void ServerCallTo_Create_Write_Stack_Server_OutputRecieve();

        [DllImport("ServerLibrary_lib.dll", CharSet = CharSet.Unicode)]
        public static extern void ServerCallTo_Flip_InBufferToWrite();

        [DllImport("ServerLibrary_lib.dll", CharSet = CharSet.Unicode)]
        public static extern void ServerCallTo_Flip_OutBufferToWrite();

        [DllImport("ServerLibrary_lib.dll", CharSet = CharSet.Unicode)]
        public static extern bool ServerCallTo_Get_State_OfCoreToLaunch();

        [DllImport("ServerLibrary_lib.dll", CharSet = CharSet.Unicode)]
        public static extern bool ServerCallTo_GetFlag_Server_Library_Initialised();

        [DllImport("ServerLibrary_lib.dll", CharSet = CharSet.Unicode)]
        public static extern void ServerCallTo_Pop_Stack_Output();

        [DllImport("ServerLibrary_lib.dll", CharSet = CharSet.Unicode)]
        public static extern void ServerCallTo_Push_Stack_InputPraises();
    }


    [SuppressUnmanagedCodeSecurity]
    internal static class PraiseEvents
    {
        [DllImport("ServerLibrary_lib.dll", CharSet = CharSet.Unicode)]
        public static extern byte ServerCallTo_Get_PraiseEventId();

        [DllImport("ServerLibrary_lib.dll", CharSet = CharSet.Unicode)]
        public static extern float ServerCallTo_Get_Praise1_pitch();

        [DllImport("ServerLibrary_lib.dll", CharSet = CharSet.Unicode)]
        public static extern float ServerCallTo_Get_Praise1_yaw();


        [DllImport("ServerLibrary_lib.dll", CharSet = CharSet.Unicode)]
        public static extern void ServerCallTo_Set_PraiseEventId(byte value);

        [DllImport("ServerLibrary_lib.dll", CharSet = CharSet.Unicode)]
        public static extern void ServerCallTo_Set_Praise1_mousePos_X(Int16 value);

        [DllImport("ServerLibrary_lib.dll", CharSet = CharSet.Unicode)]
        public static extern void ServerCallTo_Set_Praise1_mousePos_Y(Int16 value);
    }
}