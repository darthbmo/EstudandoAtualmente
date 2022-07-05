namespace EstudosGerais.Thread_Multithread
{
    public static class MultiThread
    {
        public static void VariasThreads()
        {
            Console.WriteLine("...MULTITHREAD...");

            Console.WriteLine("...INICIANDO THREAD #1...");

            Thread thr = new Thread(ThreadOne);
            thr.Start();
            //Thread.Sleep(1000);


            Console.WriteLine("...INICIANDO THREAD #2...");

            Thread _thr = new Thread(ThreadTwo);
            _thr.Start();
            //Thread.Sleep(1000);

        }

        public static void ThreadOne()
        {
            for (var i = 0; i < 50; i++)
            {
                Console.WriteLine("Thread One.");
            }
        }

        public static void ThreadTwo()
        {
            for (var i = 0; i < 50; i++)
            {
                Console.WriteLine("Thread Two.");
            }
        }
    }
}
