using AssigmentOOP04.IClonable;
using AssigmentOOP04.Interface_Eam03;
using AssigmentOOP04.interface_Exam02;
using System.Net.WebSockets;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;

namespace AssigmentOOP04
{
    internal class Program
    {

           #region InterfaceEam02
        //public static void ptint10NumberFromSeries(ISeries series)
        //{

        //    if (series == null)
        //        return;


        //    for (int i = 0; i < 10; i++)
        //    {

        //        Console.WriteLine($"{series.Current}\t");
        //        series.GetNext();
        //    }
        //    series.Reset();
        //    Console.WriteLine();


        //} 
        #endregion

        static void Main(string[] args)
        {


            // part01

            #region 1.Try all what we have learned in the lecture.
            //#region InterfaceEam02
            //SeriesBytwo SeriesBytwo = new SeriesBytwo();
            //SeriesByThree SeriesByThree = new SeriesByThree();


            //ISeries Series = new SeriesBytwo();
            //Series = new SeriesByThree();

            //ptint10NumberFromSeries(SeriesByThree);
            //#endregion

            //#region InterfaceEam03
            //AirPlane airPlane = new AirPlane();
            //IMovable movable = new AirPlane();

            //IFlayable flayable = new AirPlane();

            //movable.Forward();
            //flayable.Forward();
            //#endregion


            //#region Shallow Copy

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };


            //Console.WriteLine($" HashVode Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($" HashVode Arr01 = {Arr02.GetHashCode()}");

            ////Shallow Copy
            //Arr02 = Arr01;

            //Console.WriteLine("Afer Shallow Copy ");


            //Console.WriteLine($" HashVode Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($" HashVode Arr02 = {Arr02.GetHashCode()}");

            //Arr02[0] = 100;

            //Console.WriteLine(Arr01[0]);








            //#endregion

            //#region Deep Copy

            //Arr02 = (int[])Arr01.Clone();


            //Console.WriteLine("Afer Deep Copy ");


            //Console.WriteLine($" HashVode Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($" HashVode Arr02 = {Arr02.GetHashCode()}");


            //Console.WriteLine(Arr01[0]);








            //#endregion


            //#region  Deep Copy Vs Shallow Copy [Array Of Reference Type (String)]
            //string[] Name01 = new string[] { "saad" };
            //string[] Name02 = new string[1];

            //Console.WriteLine($" HashVode Name01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($" HashVode Name02 = {Arr02.GetHashCode()}");

            //Name02 = Name01;
            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine($" HashVode Name01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($" HashVode Name02 = {Arr02.GetHashCode()}");

            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);

            //Name02 = (string[])Name01.Clone();
            //Console.WriteLine("After Deeo Copy");
            //Console.WriteLine($" HashVode Name01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($" HashVode Name02 = {Arr02.GetHashCode()}");


            //Name02[0] = "hamda";
            //Console.WriteLine("After Change");
            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);


            //#endregion


            //#region  Deep Copy Vs Shallow Copy [Array Of Reference Type (StringBuilder)]


            //StringBuilder[] name01 = new StringBuilder[1];

            ////  name01[0].Append("hamada");

            //name01[0] = new StringBuilder("hamada");

            //StringBuilder[] name02 = new StringBuilder[1];
            //Console.WriteLine($" HashVode Name01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($" HashVode Name02 = {Arr02.GetHashCode()}");

            //Console.WriteLine(name01[0]);
            //Console.WriteLine(name02[0]);
            ////Shallow Copy

            //name02 = name01;
            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine($" HashVode Name01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($" HashVode Name02 = {Arr02.GetHashCode()}");



            //Console.WriteLine(name01[0]);
            //Console.WriteLine(name02[0]);


            //name02[0].Append("Ahmed");
            //Console.WriteLine("After change");
            //Console.WriteLine(name01[0]);
            //Console.WriteLine(name02[0]);


            ////Deep Copy


            //name02 = (StringBuilder[])Name01.Clone();

            //Console.WriteLine("After Deep Copy");

            //Console.WriteLine($" HashVode Name01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($" HashVode Name02 = {Arr02.GetHashCode()}");

            //Console.WriteLine(name01[0]);
            //Console.WriteLine(name02[0]);


            //name02[0].Append("Ahmed");
            //Console.WriteLine("After change");
            //Console.WriteLine(name01[0]);
            //Console.WriteLine(name02[0]);



            //#endregion


            //#region  Built-in Interfaces - ICloneable
            //Employee employee01 = new Employee()

            //{

            //    Id = 1,
            //    Name = "Ali",
            //    Salary = 3000
            //};

            //Employee employee02 = new Employee()

            //{

            //    Id = 1,
            //    Name = "saad",
            //    Salary = 10000
            //};


            //Console.WriteLine($"HashCode Of employee01 = {employee01.GetHashCode}");
            //Console.WriteLine($"HashCode Of employee01 = {employee02.GetHashCode}");



            //Employee employee03 = employee01;

            //employee03 = (Employee)employee01.Clone();


            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"HashCode Of employee01 = {employee01.GetHashCode}");
            //Console.WriteLine($"HashCode Of employee01 = {employee02.GetHashCode}");


            //Console.WriteLine(employee01);
            //Console.WriteLine(employee03);

            //#endregion

            //#region  Built-In Interface ICompareable

            ////int[] Numner = { 1, 2, 3, 4, 5, 15, 7, 8, 9, 20, 11, };


            ////Array.Sort(Numner);

            //Employee[] employees =
            //{

            //    new Employee() { Id = 1, Name = "saad" , Salary =50000 },

            //    new Employee() { Id = 2, Name = "omar" , Salary =10000 },

            //    new Employee() { Id = 2, Name = "mona" , Salary =70000 },

            //};

            //Array.Sort(employees);

            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item);


            //}



            ////for (int i = 0; i < employees.Length; i++)
            ////{

            ////    for (int j = 0;j< employees.Length - j - 1; j++)
            ////    {

            ////       if (employees[j].compareto(employees[j+1]) ==1)

            ////                swap(employees[j],employees[j+1]);
            ////    }


            ////} 

            //#endregion 
            #endregion


            // part02

            #region 1.What is the primary purpose of an interface in C#?


            //  b) To define a blueprint for a class



            #endregion


            #region 2.Which of the following is NOT a valid access modifier for interface members in C#?

            //a) private


            #endregion



            #region 3.Can an interface contain fields in C#?


            //  b) No


            #endregion



            #region 4.In C#, can an interface inherit from another interface?


            //  b) Yes, interfaces can inherit from multiple interfaces

            #endregion




            #region 5.Which keyword is used to implement an interface in a class in C#?

            //d) implements

            #endregion



            #region 6.Can an interface contain static methods in C#?

            // a) Yes


            #endregion



            #region 7.In C#, can an interface have explicit access modifiers for its members?


            //b) No, all members are implicitly public

            #endregion



            #region 8.What is the purpose of an explicit interface implementation in C#?


            //b) To provide a clear separation between interface and class members


            #endregion



            #region 9.In C#, can an interface have a constructor?

            //b) No, interfaces cannot have constructors



            #endregion



            #region 10.How can a C# class implement multiple interfaces?


            //  a) By using the "implements" keyword


            #endregion




            //part03


            #region Define an interface named IShape with a property Area and a method DisplayShapeInfo. Create two interfaces, ICircle and IRectangle, that inherit from IShape. Implement these interfaces in classes Circle and Rectangle. Test your implementation by creating instances of both classes and displaying their shape information

            //Circle circle = new Circle(7);
            //Rectangle rectangle = new Rectangle(8, 5);

            //circle.DisplayShapeInfo();
            //rectangle.DisplayShapeInfo();



            #endregion


            #region Question 02:



            //IAuthenticationService authService = new BasicAuthenticationService();

            //if (authService.AuthenticateUser("user", "password"))
            //{
            //    Console.WriteLine("User authenticated");

            //    if (authService.AuthorizeUser("user", "admin"))
            //    {
            //        Console.WriteLine("User authorized");
            //    }
            //    else
            //    {
            //        Console.WriteLine("User not authorized");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Authentication failed");
            //}


            #endregion



            #region Question 03


            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //string recipient = "user@example.com";
            //string message = "This is a test notification.";


            //emailService.SendNotification(recipient, message);


            //recipient = "0111111111111";
            //smsService.SendNotification(recipient, message);

            //// Send push notification
            //recipient = "User569";
            //pushService.SendNotification(recipient, message);

            #endregion


        }


    }
}
