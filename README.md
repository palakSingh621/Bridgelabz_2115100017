#### **Basic Structure of C# Program**
**What is C#.NET?**
C# is a Simple, Secure, Robust, Portable, Platform-Independent, Architectural Neutral, Multithreaded, Automatic Memory Management, Object-Oriented Programming Language with a strong type Exception Handling mechanism for developing different kinds of applications such as Web, Windows Form, Console, Web Services, Mobile Apps, etc. which can be run on different Operating Systems such as Windows, Linus, and Mac.

**Different Types of Applications are Developed using C#.NET.**
1. Windows Applications
2. Web Applications
3. Restful Web Services
4. SOAP Based Services
5. Console Applications
6. Class Library, ETC.

**What is a Console Application?**
1. A console application is an application that can be run in the command prompt.
2. The Console Applications contain a similar user interface to the Operating systems like MS-DOS, UNIX, etc.
3. Console applications do not provide any GUI facilities like the Mouse Pointer, Colors, Buttons, Menu Bars, etc.

**Importing Namespace Section:**
This section contains importing statements that are used to import the BCL (Base Class Libraries) as well as user-defined namespaces if required. This is similar to the included statements in the C programming language.
*Example: using System;*
If the required namespace is a member of another namespace, we have to specify the parent and child namespaces separated by a dot as follows:  
*using System.Data;*  
*using System.IO;*

**Note:** A namespace is a container that contains a group of related classes and interfaces, as well as, a namespace can also contain other namespaces.

**Namespace Declaration Section:**
Here a user-defined namespace is declared. In .NET applications, all classes and interfaces or any type related to the project should be declared inside some namespace. Generally, we put all the related classes under one namespace and in a project, we can create multiple namespaces.  
*Example: namespace MyFirstProject {}*

Generally, the namespace name will be the same as the project name but it is not mandatory, you can give any user-defined name to the namespace.

**Main() Method Section:**
The main() method is the entry point or starting point of the application to start its execution. When the application starts executing, the main method will be the first block of the application to be executed. The Main method contains the main logic of the application.

**Procedure Programming in C#**
 Procedural Programming is a programming paradigm that relies on a structured sequence of instructions, organized into procedures, functions, or routines to perform tasks. It follows a top-down approach and emphasizes a clear sequence of commands and control flow.
Procedural programming (PP) follows a step-by-step approach, where programs are divided into functions.
*Examples: C, Pascal, C#*
#### **C#: Class and Object**
1. **What is a Class?**
A class is a blueprint or template that defines the structure (attributes) and behavior (methods) of objects. It provides a way to group related data and functions together.
- A class doesn't consume memory until objects are created from it.    
- It is defined using the class keyword.

2. **What is an Object?**
An object is an instance of a class that represents a real-world entity. It has:
- State: Defined by the values of its attributes.
- Behavior: Defined by the methods of the class.
*Syntax:*
*ClassName objectName = new ClassName(parameters);*

* Attributes (Fields): Represent the data or state of the object. 
    *Example: public string Brand;, public int Speed;*
- Methods: Define the behavior or actions of the object. 
	-*Example: public void DisplayDetails()*
- Constructor: A special method used to initialize the attributes of an object. 
- Example:

           public Car(string brand, int speed) {

                    this.Brand = brand;

                    this.Speed = speed;

     }
* Memory Allocation: When an object is created, memory is allocated for its attributes in the heap.
