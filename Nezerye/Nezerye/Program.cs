namespace Nezerye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Test test = new Test();
            test[0] = 1;
            test[1] = 25;
            test[2] = 36;
            test[3] = 48;
            test[11] = 99;

            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }*/

           Test t = new Test();

            foreach(var item in typeof(Test).GetProperties(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance))
            {
                /*item.SetValue(t, 20);*/

                Console.WriteLine(item.GetValue(t));
            }
        }
    }
    class Test 
    {
        private int[] Arr { get; }
        private int A { get; set; } = 5;
    /* public int Length => Arr.Length;*/
        /*public int this[int i]
        {
            get
            {
                return Arr[i];
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("deyer 0 dan kicik ola bilmez");
                }
                if (i >= Arr.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                Arr[i] = value;
            }
        }
        public Test()
        {
            Arr = new int[10];
        }*/
    }
}
