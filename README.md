## Operators
#### bitwise Operator Code
## Type Conversion
The process to change one data type value into another data type. The Type Conversion is only possible if both the data types are compatible with each other else we will get compile time error saying **cannot implicitly convert one type to another type**.
#### Types 
* **Implicit type conversion**
	1. The two data types are compatible.
	2. When we assign a value of a smaller data type to a bigger data type.
* **Explicit Type Casting (Manual Conversion):**
1.  Required when converting a larger data type to a smaller data type, which may lead to data loss.
2. Must be performed manually using a cast operator.
* explicit casting can lead to data loss if the value being converted doesn't fit within the target data type's range. For instance, converting an `int` with a value of `500` to a `byte` would result in data loss, as the `byte` type can only store values from `0` to `255`.
### Boxing and Unboxing
In C#, **boxing** and **unboxing** are concepts related to the conversion between value types and reference types, specifically with objects. These mechanisms are used when a value type (e.g., `int`, `float`, etc.) needs to be treated as an object type.
#### Boxing
- **Definition**: Boxing is the process of converting a **value type** into a **reference type** by wrapping it in an object.
- **How it works**:
    - The value is stored on the heap instead of the stack.
    - The runtime creates an object wrapper around the value.
#### Unboxing
- **Definition**: Unboxing is the process of converting a **reference type** back into its corresponding **value type**.
- **How it works**:
    - The runtime extracts the value from the object.
    - A cast is required to retrieve the value type.

**Can we store parent class object in child object?**
* We cannot directly store a parent class object in a child class object.
* A **parent class object** only contains members defined in the parent class.
* A **child class object** extends the parent class and may introduce additional members (fields or methods).
* Directly assigning a parent class object to a child class reference would lead to **runtime errors** because the child class expects the additional members to exist, but they don't in the parent class.
