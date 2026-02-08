###### - Classes
- class is a blueprint -> not stored untill call object (variable & Fields & Methods)
```c#
class Person
{
	public string Name;
	private int age;
	// Methods
	public void SayHello()
	{
		Console.WriteLine("Hello Jana");
	}
	
}
```

- ==**object**== is a copy of the class -> when it is called the copy of the class(attributes &Methods) stored in memory
```c#
Person p= new Person();
p.Name = jana;
p.Age//eroor
p.SayHello();
```
- ==**Properties**== is a variables into classes instead of using the fields for security
```c#
Class Person
{
public string Name {get;set;}

// another
public string name
{
	get
	{
		return Name;
	}
	set
	{
		Name= value;
	}
}
```
###### ==Constructors== ->
called automatically when object is created 
if we do not create it the compiler make it by default
the static Class Do not have to make object
//overloaded + implicit + This +Non public + Obj initializer +Read Only
```c#
class Person
{
	public Person (/*Parameters*/)
	{
		//body
	}	
}
```
##### Methods
- ***Static Member***
-> ==*A Shared Variable That Can Be Changed After it Has Been Initialized*==
- ***Constant Member***
-> *==A Promise that Can't Be Changed After it Has Been Initialized==*


> [!NOTE] Calling
> ==Static Method== is called by TypeName
> ==Instance Method== is called by Object


```c#
class Demo
{
	// method callee
	// void
	public void Says()
	{
		Console.WriteLine( "Hello World" );
	}
	// return type
	public int DoSomething()
	{
		return 10;
	}
	// 
	
	public int GetAge(int age)// age here is a parameter 
	{
		// age in the main scope called Argument
	}
}
```

- ***Pass By Value***->Making A copy in Memory of the Actual Parameter's Valus
```c#
internal class Program
{
    static void Main(string[] args)
    {
        int age = 18;
        Demo d = new Demo();
        d.GetAge(age);

        Console.WriteLine(age); // 18
		Console.WriteLine(d.GetAge(age)); // 21 sure because this is the func
        Console.ReadKey();
    }
}
public class Demo
{
    public int GetAge(int age)
    {
        return age += 3;
    }

}
```
- ***Pass by Reference***-> affect on arguments
```c#
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 18;
            Demo d = new Demo();
            d.GetAge(ref age);

            Console.WriteLine(age); // 21


            Console.ReadKey();
        }
    }
    public class Demo
    {
        public int GetAge(ref int age)
        {
            return age += 3;
        }

    }
```
###### - What's the Diff Between Ref & Out Keyword
- *Ref->* used to affect on the argument and stored it in memory
- *Out->* used when the argument is not Initialized yet
```c#
 internal class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.GetAge(ref age);
            int age;//   Not Initialized
            Console.WriteLine(age); // 21


            Console.ReadKey();
        }
    }
    public class Demo
    {
        public int GetAge(out int age)
        {
	        age = 18;
            return age += 3;
        }
    }

```

##### Method Signiture:
-> ==Method Name + param Type + param Order== 
###### **Method Overloading** 
-> A common Way of implementing Polymorphism
```c#
public void sum(int a,int b)
{
	Console.Write("Hello");
}
public void sum(int a)
{
	Console.Write("Hello");
}

public bool inEven(int num) => num % 2 == 0;// bodied Method
```

*Local Method* -> when the method has 1 ref to another 
```c#

public void printArr(int[] nums)
{
	foreach(var n in nums)
	{
		if(isEven(n)) Console.Write(n + " " );
	}
	public bool isEven(int num) 
	{
		 return num % 2==0;
	}
}
// method isEven is Local for MEthod PrintArr
```

> [!NOTE] Static func
> is Called by class Name Not by object Name



