/*
*  Managed C# wrapper for FLORENCE Concurrent Que library by Jasper Assembly Pty Ltd.
*  Copyright (c) 2022 - 2025 Jasper Assembly Pty Ltd.  
*  All rights reserved.
*/

using System.Runtime.InteropServices;
using System.Security;


namespace Florence.Concurrency
{
    [SuppressUnmanagedCodeSecurity]
    public static class ConcurrentQue_Client
    {
        [DllImport("WaitLaunch_Client_ConcurrentThread_lib.dll", CharSet = CharSet.Unicode)]
        public static extern void Create_ConcurrentQue();

        [DllImport("WaitLaunch_Client_ConcurrentThread_lib.dll", CharSet = CharSet.Unicode)]
        public static extern void Request_Wait_Launch_ConcurrentThread(ushort concurrent_coreId);

        [DllImport("WaitLaunch_Client_ConcurrentThread_lib.dll", CharSet = CharSet.Unicode)]
        public static extern void ConcurrentThread_End(ushort concurrent_coreId);
    }

    [SuppressUnmanagedCodeSecurity]
    public static class ConcurrentQue_Server
    {
        [DllImport("WaitLaunch_Server_ConcurrentThread_lib.dll", CharSet = CharSet.Unicode)]
        public static extern void Create_ConcurrentQue();

        [DllImport("WaitLaunch_Server_ConcurrentThread_lib.dll", CharSet = CharSet.Unicode)]
        public static extern void Request_Wait_Launch_ConcurrentThread(ushort concurrent_coreId);

        [DllImport("WaitLaunch_Server_ConcurrentThread_lib.dll", CharSet = CharSet.Unicode)]
        public static extern void ConcurrentThread_End(ushort concurrent_coreId);
    }
}