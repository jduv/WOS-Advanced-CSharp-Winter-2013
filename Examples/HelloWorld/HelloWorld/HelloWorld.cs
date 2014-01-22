using System;

namespace HelloWorld
{
    class HelloWorld
    {
        public static void Main(string[] args)
        {
            HelloWorld.Hello();

            HelloWorld myThing = new HelloWorld();

        }

        public static void Hello()
        {
            Console.WriteLine("Hello");
        }

        public void HelloWorldMethod(string myString)
        {
            Console.WriteLine(myString);
        }
    }
}
