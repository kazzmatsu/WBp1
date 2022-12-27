using System;

namespace WildBaseProject1
{
    public class WBp1
    {
        public static void Main ( string [ ] args )
        {
            var mmm = new WBp1();
            mmm.ClsMain();
        }
        internal void ClsMain ( )
        {
            local_func1();
        }
        internal void local_func1()
        {
            var msg = "Checks";
            Console.WriteLine($"{msg}");
        }
    }
}