namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            userSnapshot U = new userSnapshot("jana", 19);
            user u = new user("mahmoud", 14);
            Test(U, u);
            Test1(ref U, ref u);
        }


        //method
        public static void Test(userSnapshot U, user u)
        {

            Console.WriteLine(U.name + " " + u.name);
            Console.WriteLine(U.age + " " + u.age);

        }
        public static void Test1(ref userSnapshot U, ref user u)
        {

            Console.WriteLine(U.name + " " + u.name);
            Console.WriteLine(U.age + " " + u.age);

        }
    }
    public struct userSnapshot
    {
        public string name { get; set; }
        public int age { get; set; }

        public userSnapshot(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    class user
    {
        public string name { get; set; }
        public int age { get; set; }
        public user(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

    }
}
