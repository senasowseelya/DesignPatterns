using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.SingletonDesignPattern
{

    internal class StaticVsSingleton
    {

    }

    public static class StaticClass
    {
    }
    public class Parent
    {
    }

    public sealed class Singleton : Parent
    {
    }




    //Similarities:
    //    1.Both have only one  copy in the memory at any time.
    //    2.Both are used to save the global state of an application.
    //    3.Both can be implemented as Thread-safe

    //Differences:
    // 1. We can create instance of singleton class but as a developer we cannot create an instance for static class
    // 2. Static is a keyword and a language feature but singleton is a design pattern.
    // 3. Static class when compiled is internally abstract and sealed.Therefore we cannot create an instance for it nor we can use it for inheritance
    // public static class StaticChild : Parent { }  --> throws error static class must derive from object
    //  public class Child : StaticClass { } --> throws error cannot derive from static class
    // whereas we can create an instance for singleton class and also use singleton class as a child class The Singleton class can be created as a Child class only. You cannot create child classes from the Singleton class. These are not possible with a static class. So, the Singleton class is more flexible than the Static Classes in C#.
    // 4. Static class / types cannot be used as parameters where as singleton can be.
    // 5. Static classes cannot implement interface whereas singleton can.



}
