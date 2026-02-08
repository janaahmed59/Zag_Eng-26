##### ==Variables==
```c#
// var 
var s1 = "jana";// string
var x = 3;// int
var f = 0f;// float
var g = 0d;// double
var x = 0m;// decimal
var y = 0u; // unsigned int +
var z = 0l; // long

// dynamic -> resolve at runtime;

dynamic x = 9m;// considered as object x= double 9
dynamic y = "jana";// y = string
```
==**Data Types**==
```c#
   Console.WriteLine($"sbyte {sbyte.MinValue} -> {sbyte.MaxValue}");
   Console.WriteLine($"int {int.MinValue} -> {int.MaxValue}");
   Console.WriteLine($"Double: {double.MinValue} -> {double.MaxValue}");
   Console.WriteLine($"float {float.MinValue} -> {float.MaxValue}");
   Console.WriteLine($"Decimal: {decimal.MinValue} -> {decimal.MaxValue}");
   Console.WriteLine($"Long {long.MinValue} -> {long.MaxValue}");
   
```
**==Expressions==**** 
- null is a var is Not exist

```c#
// precedence
int x = 3+5*2 // 13 (* then +)
int y = (3+5)*2 // 16( () tnen *)

// Null op
var s1 = null // erroe null can be anything (var)

string s1 = null
s1 = s1 ?? "Jane" // if s1 is Null? yes so s1 = "jana"

// Null refrence Exception ->
var s2 = s1.toUpper() // exception because s1 = null
var s2 = s1?.toUpper()

//Arihmaic
int x =5, y= 10;
int z= x+y;

// Relational 
int total = 1000;
bool isvalid = total > 900;

//logical && || ^
 bool result = (5 > 3) && ( 1<2);
 var result1 = (5>3) || (1>2);
 
 // Assignment
 int x =10;
 x+=5;
 
// unary 
 int x=5;
 x++;
 bool flag = !true;
 
 // Conditional or ternary
 int max = ((5>3)? 5 : 3;
 
 // Bitwise
 int bit = 5& 3;
 
 //lambda 
 func<int,int>v square = n=> n*n//
 
 // on=bject creation
 var person = new Person();
 Person person = new Person();
 
 // method call
 
 int len = name.length;
 //Type casting
 double d= 5.5
 int i= (int)d;
 
 // Goto )jump statement
 var i =0;
 start: // label
 if(i<=5)
 {
	 Console.Write(i + " " );
	 i++;
	 goto start;
 
 }
```
##### ==Control Flows==
###### conditional statement
- IF
```c#
int x = 5
if(x%2 ==0){
// body
}
else if(x%2==1){
// body
}
else{
//body
}
```
- Switch
```c#
int x;
switch(x)
{
  cas1 1:
  //code
  break;
  case 2:
  //code
  break
  //...
  default:
  // code if no cases found === else
  break;
}
```
###### Loops
- For & While & doWhile
```c#
for(int i=0;ei<10;i++){
    // body
	if(conditon){
		 continue;
	}
	else{
	   break;
	}
}
// foreach
foreach(var i in arr){
   // body
}

int n=6;
while(n>0){
	// body
}

do{
	//condition that execute once
}while(condition);
```
###### - Return From Methods
```c#
int Add(int x , int b){
	return x+b;
}

```
###### - Exception Handling
```c#
try{
	// code that might throw exception
}catch(Exceptoion type ex)
{
	//handle
}
finally
{
	// code that always run
}
```

#### Casting & Type Conversion
- implicit Casting -> 
```c#
int ni = 1000;
long nl = ni;

long nnl = 1000;
int nni = nnl // error 
```
- Explicit Casting
```c#
long nnl = 1000;
if(nnl <= int.MaxValue)
{
	int nni = (int)nnl;
}

```
##### Boxing & unBoxing
- Boxing -> conversion from Reference to Value (implicitly done)
- Unboxing -> Conversion from Value to Reference (Explicitly cast)
```c#
int x=10;
object ob ;
ob = x ; // Boxing 
int y = (int)ob; //unboxing

```
##### Conversion between string & int

```c#
string SVal = "120";
int num = int.Parse(SVal);
// Type.Parse() converse string to int if 
string sval = "W120";
int num = int.Parse(sval); // exception
//sol
if(int.TryParse(sval ,out int number))
{
	// body
}
```

