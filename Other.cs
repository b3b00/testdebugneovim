using System;

namespace testdebugneovim
{
    public class Other(string m)
    {
        private readonly string _m = m;

        public void Do()
        {
            Console.WriteLine($"other => {_m}");
        }
    }
}
