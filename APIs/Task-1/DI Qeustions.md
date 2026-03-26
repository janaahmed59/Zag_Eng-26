##### Question1: What is the dependency?

Hard to Test and Maintain , No flexibilty

* Depending only on one type of database, depending on one type of sending message that it is sending only Emails, depending on one type of data storage 
* Hard to test the OrderServices because it is Connected with one type of database or SqlConnection 
* Parameter of Class is connect with its Name not with its fuctionality 



##### Question2: Difference between Class A \& Class B

1. Class A:

the problems -> testing , maintaining , flexibilty

* one type of sending emails -> No flexibility to send other Types
* class make its Dependancies inside the class 

2\. Class B:

* Make attributes and pass it to constructor so the class become wait the dependencies from outside and doesn't need to make it by itself(constructor Injection) 
* Make Interface to use the concept or what the function do not the name only



\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_

##### Question3:What happens when a request is received?

* client send request (Post/product) then Routing determine controller, here is called "ProductController", then DI save the dependencies which "productController" need a "ProductServices" 
* After DI container searching, there is <AddScoped> of "ProductService" which it means if any controller need "ProductService". pass it!
* DI say that "ProductService" need "IRepository" and DI start creating instance of "SqlRepository" in order to the Existing of <AddScoped>
* After "ProdctService" Now Created, the "productController" execute the "AddProduct" fuction and return Ok()



\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_

##### Question4: What is the output for each registration?

for each Registration 

1. AddTranseint: for each calling the service there is a new instance, so it is not equal each other, the same is false so return false.
2. AddScoped: for the same request there one instance for every http request this means there is one instance for the same request , so he same is True and return true.
3. AddSingleton: one instance for the app lifetime so the same is true and returned true



\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_

##### Question5: Which implementation will Controller A receive?

##### How many services will be injected into Controller B?

* DI make Controller A choose the last Registration (MailgunEmailService>())
* DI make Controller B choose all Registraction and put it in Ienumrable in order.



\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_

