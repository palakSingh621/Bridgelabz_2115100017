## Difference between Java and C#
**Java**
* Java is a **high level, robust, secured and object-oriented programming** language developed by Oracle.
* Java programming language is designed to be run on a Java platform, by the help of **Java Runtime Environment (JRE).**
* Java type safety is safe i.e., it doesn't support pointers.
* built-in data types that are passed by value are called **primitive types.**
* Arrays are specialization of object.
* Namespaces are created by Camel Case format.
  
**C#**
* Object-oriented programming language developed by Microsoft that works on .NET framework.
* C# language runs on Common Language Runtime(CLR).
* C# is type unsafe i.e., does support pointers.
* built-in data types that are passed by value are called simple types.
* Arrays are specialization of system.
* Namespaces are craeted by Pascal format.

## Understanding Static and No-Static Members in C#
* The members (Variables, Constructors, and Methods) which are created by using the static modifier are called static members rest of all are called non-static members.
* the members of a class that does not require an instance either for initialization or execution are known as the static member. On the other hand, the members which require an instance of a class for both initialization and execution are known as non-static members.

### Static and Non-Static Variables
**Scope of Static and Non-Static Variables**: 
  The Non-Static variables are created when the object is created and are destroyed when the object is destroyed. The object is destroyed when its reference variable is     destroyed or initialized with null. So, we can say that the scope of the object is the scope of its referenced variables. On the other hand, the Static Variable scope is the Application Scope. What it means, as soon as the application start and class execution starts, static variables are created and they will be there as long as your application is running. Once the application stops, then static variables are going to be deleted. So, the scope is application scope.

### Static and  Non-Static Methods
When we create a method by using the static modifier then it is called the static method and the rest of the methods are non-static methods. You cannot consume the non-static members directly within a static method. If you want to consume any non-static members with a static method then you need to create an object and then through the object, you can access the non-static members. On the other hand, you can directly consume the static members within a non-static method without any restriction.
## Rules to follow while working with Static and Non-Static Members
1. **Non-Static to Static:** Non-Static Members can be consumed only by using the object of that class inside a static block.
2. **Static to Static:** Static Members can be consumed directly (within the same class) or by using the class name (from outside the class) inside another static block.
3. **Static to Non-Static:** Static Members can be consumed directly or by using the class name inside a Non-Static block.
4. **Non-Static to Non-Static:** Non-Static Members can be consumed directly or by using the “this” keyword inside another non-static block.
### Static and Non-Static Constructors
* the static constructor is the first block of code that gets executed under a class. No matter how many numbers of objects you created for the class the static constructor is executed only once. On the other hand, a non-static constructor gets executed only when we created the object of the class and that is too for each and every object of the class.
* It is not possible to create a static constructor with parameters. This is because the static constructor is the first block of code that is going to execute under a class. And this static constructor is called implicitly, even if parameterized there is no chance of sending the parameter values.
### Static Class
The class which is created by using the static modifier is called a static class in C#. A static class can contain only static members. It is not possible to create an instance of a static class. This is because it contains only static members. And we know we can access the static members of a class by using the class name.
## Access Modifier
Default Access-Modifier in c# is **internal**
Default Access-Modifier in java is **default**
### Access Modifier in c#:                                                           
* **Public** within Namespace access is not restricted and Accessible outside namespace. 
* **Private** within Namespace access is limited to containing type.Not accessible outside the namespace.
* **Protected** within Namespace access is limited to the containing class or types derived from the containing class.                                                          
* **Internal** within Namespace access is limited to current assembly only. Not accessible outside namespace.
* **Protected Internal** within Namespace access is limited to the current assembly or types derived from the containing class. Outside the namespace, only accessible to the types derived from the containing class.
