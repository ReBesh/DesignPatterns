using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class SLazy : IDatabase
    {
        private static volatile Lazy<SLazy> _instance =
            new Lazy<SLazy>(() => new SLazy());

        private SLazy()
        {

        }

        public static SLazy Instance => _instance.Value;

        public void GetRecords()
        {
            for (int zh = 0; zh < 20; zh += 2)
            {
                Console.WriteLine($" {zh} in SLazy.");
            }
        }
    }

    public interface IDatabase
    {
        void GetRecords();
    }
}
