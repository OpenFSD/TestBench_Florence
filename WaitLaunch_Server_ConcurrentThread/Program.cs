//WaitLaunch_Server_ConcurrentThread

namespace ServerLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Florence.Concurrency.ConcurrentQue_Server.Create_ConcurrentQue();
            while (true)
            {

            }
        }
    }
}