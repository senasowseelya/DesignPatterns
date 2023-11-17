using DesignPatterns.Behavioural.ChainOfResponsibility;
using DesignPatterns.Behavioural.Iterator;
using DesignPatterns.Behavioural.Observer;
using DesignPatterns.Behavioural.State;
using DesignPatterns.Creational.AbstractFactoryDesignPattern;
using DesignPatterns.Creational.BuilderDesignPattern;
using DesignPatterns.Creational.FactoryDesignPattern;
using DesignPatterns.Creational.FactoryMethodDesignPattern;
using DesignPatterns.Creational.FluentInterfaceDesignPattern;
using DesignPatterns.Creational.PrototypeDesignPattern;
using DesignPatterns.Creational.SingletonDesignPattern;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.FlyWeight;
using DesignPatterns.Structural.Proxy;
using System.ComponentModel;

namespace DesignPatterns
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
           
        }
        public static void TestSingletonPattern()
        {
            Parallel.ForEach(Enumerable.Range(1, 10), item =>
            {
                Console.WriteLine(SingletonDemo.instance.Id);
            });
            var tasks = new List<Task>();
            SingletonDemo s1, s2;
            for (int i = 0; i < 15; i++)
            {
                tasks.Add(Task.Run(
                    () =>
                    {
                        Thread.Sleep(100 * i);
                        s1 = SingletonDemo.instance;
                        s2 = SingletonDemo.instance;
                        bool eq = s1.Equals(s2);
                        bool eq1 = ReferenceEquals(s1, s2);
                        Console.WriteLine(eq);
                        Console.WriteLine(eq1);
                        Console.WriteLine($"{s1.Id} : {s2.Id}");
                    }
                    ));
            }
            Task.WhenAll(tasks).GetAwaiter().GetResult();
            Parallel.Invoke(
                () => { Console.WriteLine(SingletonDemo.instance.Id); },
                () => { Console.WriteLine(SingletonDemo.instance.Id); }
                );
        }
        public static void TestFactoryPattern()
        {
            //without Factory class
            string cardType = "Gold";
            if (cardType == "Gold")
            {
                Console.WriteLine("Gold Card");
                GoldCreditCard gc = new GoldCreditCard();
            }
            else if (cardType == "Platinum")
            {
                Console.WriteLine("Platinum Card");
                PlatinumCreditCard gc = new PlatinumCreditCard();
            }

            else if (cardType == "Titanium")
            {
                Console.WriteLine("Titanium Card");
                TitaniumCreditCard gc = new TitaniumCreditCard();
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }

            //With Factory Class

            ICreditCard creditCard;
            creditCard = CreditCardFactory.GetCreditCard(cardType);
            if (creditCard != null)
            {
                Console.WriteLine("CardType : " + creditCard.GetCardType());
                Console.WriteLine("CreditLimit : " + creditCard.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + creditCard.GetAnnualCharge());
            }
        }
        public static void TestFactoryMethodPattern()
        {
            ICreditCard creditCard = new PlatinumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("CardType : " + creditCard.GetCardType());
                Console.WriteLine("CreditLimit : " + creditCard.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + creditCard.GetAnnualCharge());
            }
        }
        public static void TestAbstractFactoryPattern()
        {
            IBike bike = new RegularVehicleFactory().GetBike();
            bike.GetDetails();
            IBike sportsBike = new SportsVehicleFactory().GetBike();
            sportsBike.GetDetails();
            Creational.AbstractFactoryDesignPattern.ICar car = new RegularVehicleFactory().GetCar();
            car.GetCarDetails();
            Creational.AbstractFactoryDesignPattern.ICar sportsCar = new SportsVehicleFactory().GetCar();
            sportsCar.GetCarDetails();
        }
        public static void TestBuilderPattern()
        {
            ReportDirector director;
            ExcelReport excelReport = new ExcelReport();
            director = new ReportDirector(excelReport);
            Report report = director.BuildReport();
            report.Display();
            PdfReport pdfReport = new PdfReport();
            director = new ReportDirector(pdfReport);
            Report report1 = director.BuildReport();
            report1.Display();


        }
        public static void TestFluentInterfacePattern()
        {
            //Without FLuentInterface
            Creational.FluentInterfaceDesignPattern.Employee emp = new Creational.FluentInterfaceDesignPattern.Employee();
            emp.Id = 1;
            emp.Age = 10;
            Console.WriteLine($"{emp.Id} {emp.Name} {emp.Age}");
            //With FLuent Interface
            FluentEmployee employee = new FluentEmployee();
            employee.Id(2).Age(20).BornAt("Tenali").BornOn(DateTime.Now).Name("sena");
            employee.ShowDetails();
            Creational.FluentInterfaceDesignPattern.Employee employee2 = employee.employee;
            Console.WriteLine($"{employee.employee.Id} {employee.employee.Name} {employee2.Age}");
        }
        public static void TestPrototypePattern()
        {
            //AssignmentOperatorCopyProcess();
            //CloningWithMemberWiseClone();
            //ShallowCopy();
            //DeepCopy();
            Vehicle vehicle = new TwoWheelerVehicle() { Id = 1, Capacity = 2 };
            Vehicle vehicle1 = vehicle.GetClone();
            vehicle1.Capacity = 3;
            Console.WriteLine($"{vehicle.Capacity} {vehicle1.Capacity}");
            Vehicle vehicle2 = new FourWheelerVehicle() { Id = 1, model = "Sedan", Capacity = 4 };
            Vehicle vehicle3 = vehicle2.GetClone();
            vehicle3.Capacity = 7;
            Console.WriteLine($"{vehicle2.Capacity} {vehicle3.Capacity}");
        }
        public static void AssignmentOperatorCopyProcess()
        {
            //How assignment Operator performs copying 
            Student s = new Student
            {
                Id = 1,
                Name = "Sena",
                Branch = "CSE",
                Section = "D"
            };
            Student s1 = s;
            s1.Branch = "IT";
            s1.Section = "C";
            //s1=s makes both s,s1 point to same address.Change i one affects the other.
            //Below code outputs IT IT C C
            Console.WriteLine($"{s.Branch} {s1.Branch} {s.Section} {s1.Section}");
        }
        public static void CloningWithMemberWiseClone()
        {
            //Cloning in C#
            Student student = new Student
            {
                Id = 4,
                Name = "Nag",
                Branch = "CSE",
                Section = "D"
            };
            Student s2 = student.GetClone();
            s2.Branch = "ECE";
            //MemberWiseClone is from System.Object and it creates a new Complete copy of the object.
            Console.WriteLine($"{student.Branch} {s2.Branch}");
        }
        public static void ShallowCopy()
        {
            Student s = new Student
            {
                Id = 1,
                Name = "Sena",
                StudentAddress = new Address { Country = "India" }
            };
            Student s1 = s.GetClone();
            s1.Name = "Mohith";
            s1.StudentAddress.Country = "US";
            //Here S1 is shallow copy of S 
            //Value type is stored in a different memory location where  as reference type point to same memory location
            Console.WriteLine($"{s.Name}{s1.Name} {s.StudentAddress.Country} {s1.StudentAddress.Country}");
        }
        public static void DeepCopy()
        {
            Student s = new Student
            {
                Id = 1,
                Name = "Sena",
                StudentAddress = new Address { Country = "India" }
            };
            Student s1 = s.GetDeepCopy();
            s1.Name = "Mohith";
            s1.StudentAddress.Country = "US";
            //Here S1 is Deep copy of S 
            //Both reference types and value types are stored in different memory locations
            Console.WriteLine($"{s.Name}{s1.Name} {s.StudentAddress.Country} {s1.StudentAddress.Country}");
        }
        public static void TestSingletonClone()
        {
            SingletonDemo s1 = SingletonDemo.instance;
            Console.WriteLine($"{s1.Id}");
            SingletonDemo s2 = s1.GetClone();
            Console.WriteLine($"{s2.Id}");
        }
        public static void TestAdapter()
        {

            string[,] employeesArray = new string[5, 4]
           {
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
           };
            ITarget employeeAdapter = new EmployeeAdapter();
            employeeAdapter.ProcessCompanySalary(employeesArray);
        }
        public static void TestFacade()
        {
            Customer customer = new Customer()
            {
                Id = 1,
                Name = "Sena",
                Address = "Hyderabad"

            };
            //Without Facade 
            bool isValid = new Validator().ValidateCustomer(customer);
            if (isValid)
                new Registration().RegisterCustomer(customer);

            //With Facade
            //Without Facade , client may or maynot follow order of invocations and may fail. Facade overcomes that disadvantage
            CustomerFacade facade = new CustomerFacade();
            facade.RegisterCustomer(customer);
        }
        public static void TestDecortor()
        {
            Structural.Decorator.ICar bmwCar = new BMWCar();
            CarDecorator pcd = new PetrolCarDecorator(bmwCar);
            pcd.ManufactureCar();
            CarDecorator dcd = new DieselCarDecorator(bmwCar);
            dcd.ManufactureCar();


        }
        public static void TestComposite()
        {
            Structural.Composite.IComponent monitor = new Leaf("Monitor", 2.0);
            Structural.Composite.IComponent mouse = new Leaf("Mouse", 2.0);
            Structural.Composite.IComponent ram = new Leaf("ram", 2.0);
            Structural.Composite.IComponent cpu = new Leaf("CPU", 2.0);
            Composite motherboard = new Composite("Motherboard");
            Composite cabinet = new Composite("Cabinet");
            motherboard.AddComponent(cpu);
            motherboard.AddComponent(ram);
            cabinet.AddComponent(motherboard);
            motherboard.DisplayPrice();
            monitor.DisplayPrice();
            mouse.DisplayPrice();
            cabinet.DisplayPrice();
        }
        public static void TestFlyWeight()
        {

            for (int i = 0; i < 3; i++)
            {
                Circle circle = (Circle)ShapeFactory.GetShape();
                circle.SetColor("Green");
                circle.Draw();
            }
            for (int i = 0; i < 3; i++)
            {
                Circle circle = (Circle)ShapeFactory.GetShape();
                circle.SetColor("Red");
                circle.Draw();
            }


        }
        public static void TestProxy()
        {
            Structural.Proxy.Employee employee = new Structural.Proxy.Employee(1, "Sena", "Developer");
            Structural.Proxy.Employee employee1 = new Structural.Proxy.Employee(2, "Mohith", "Admin");
            SharedFolderProxy proxy = new SharedFolderProxy(employee);
            proxy.ReadWriteToSharedFolder();
            SharedFolderProxy proxy1 = new SharedFolderProxy(employee1);
            proxy1.ReadWriteToSharedFolder();

        }
        public static void TestIterator()
        {
          
            PlayListAggregate playListAggr = new PlayListAggregate();

            playListAggr.AddSong(new Song { Id = 1, Name = "ABC" });  
            playListAggr.AddSong(new Song { Id = 1, Name = "ABClkj" });  
            playListAggr.AddSong(new Song { Id = 1, Name = "jk" });  
            playListAggr.AddSong(new Song { Id = 1, Name = "kjjs" });  
            playListAggr.AddSong(new Song { Id = 1, Name = "ooo" });  
            Song song = null;
            IIterator<Song> iterator = playListAggr.CreateIterator();
            while (iterator.HasNext()) {
                Console.WriteLine(iterator.Next());
            }
           
        }
        public static void TestObserver() {
            IObserver observer1 = new ConcreteObserver() { Id=1};
            IObserver observer2 = new ConcreteObserver() { Id=2};
            IObserver observer3 = new ConcreteObserver() { Id=3};
            IObserver observer4= new ConcreteObserver() { Id=4};

            ConcreteSubject subject = new ConcreteSubject(new Product { Id=1,Name="Phone",State=ProductState.SoldOut});
            subject.AddObserver(observer1);
            subject.AddObserver(observer2);
            subject.AddObserver(observer3); 
            subject.AddObserver(observer4);
            subject.RemoveObserver(observer1);
            subject.UpdateProductAvailabilty();
            

        }
        public static void TestChainOfResponsibility() {
            Chain chain = new Chain();
            chain.Withdraw(2500);
            chain.Withdraw(2600);
        }
        public static void TestState()
        {
            ATMMachine machine = new ATMMachine();
            machine.EnterPin();
            machine.EjectDebitCard();
            machine.InsertDebitCard();
            machine.Withdraw();
            machine.EjectDebitCard();
            Console.WriteLine("correct pattern");
            machine.InsertDebitCard();
            machine.EnterPin();
            machine.Withdraw();
            machine.EjectDebitCard();


        }
    }



}