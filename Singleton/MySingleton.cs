using System;

namespace Singleton
{
	public sealed class MySingleton : IDatabase, IDisposable
	{

		private static volatile MySingleton ins;
		private bool a;
		private static readonly object f = new object();
		private MySingleton()
		{
		}
		public static MySingleton Ins
		{
			get
			{
				if (ins != null) return ins;
				lock (f)
				{
					if (ins == null)
					{
						ins = new MySingleton();
					}
				}
				return ins;
			}
		}
		public int SomeValue { get; set; }

		public void GetRecords()
		{
			for (int zh = 0; zh < 20; zh += 2)
			{
				Console.WriteLine($"{zh} in MySingleton.");
			}
		}

		public void Dispose()
		{
			Dispose(a);
			GC.SuppressFinalize(this);
		}

		private void Dispose(bool disposing)
		{
			if (a)
				return;
			else
				ins = null;
		}


	}
}

