namespace Delegate_Progs
{
    public class Program
    {
        public delegate int mydelegate(int x,int y);
        public event mydelegate 

        public void Calculate()
        {
            mydelegate md = new mydelegate(ADD);
            var ans = md(20, 60);
            Console.WriteLine(ans);

            //................MULTICAST DELEGATE ............//

            mydelegate md2 = new mydelegate(ADD);
           // md2 = md + SUB;
           // md2 = md2 + MUL;// all the variables will be stored in md2 obj that we created for the mydelegate

            var ans2 = md2.Invoke(20, 60);
            Console.WriteLine(ans2);

        }

        public int ADD(int a,int b)
        {
            return a + b;// the signature should be same with the delegate bt u can use diffrent variables 
        }
        public int SUB(int a,int b)
        {
            return (a - b) ;
        }

        public int MUL(int a, int b)
        {
            return a * b;
        }


        public static void Main(string[] args)
        {
            Program p = new Program();
            p.Calculate();
           // Console.WriteLine(p);
        }
    }
}
