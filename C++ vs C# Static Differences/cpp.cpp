#include <iostream>
using namespace std;

/*
   🔍 **Static Members in C++**:

   In C++, `static` members belong to the class itself, rather than to any individual instance. This means they share the same memory across all instances of the class. Static variables retain their value between function calls and across different objects of the class. There are a few important concepts when dealing with `static`:

   1. **Static Variables**: These variables are shared across all instances of the class. They must be defined outside the class, even though they are declared inside it.

   2. **Static Methods**: These methods can only access static variables and cannot use instance-specific variables. They can be called without creating an object of the class.

   3. **Initialization of Static Variables**: Static variables are not initialized when declared inside the class. They must be defined and initialized outside the class.

   🎯 **Key Tricks**:
   - Static members allow you to share data across all instances.
   - Static methods don't need an object to be called and can only access static data.
   - Static variables retain their state across function calls.
*/

class clsStatic
{
public:
	static int x;		// Static member variable declaration
	static int counter; // Static counter variable for example

	// Static method to return static variable 'x'
	static int foo()
	{
		return x;
	}

	// Static method to increment counter and return its value
	static int increment()
	{
		return (counter++, counter); // Increment the counter and return the new value
	}
};

// ✅ Define static variables outside the class
// The static variable needs to be defined and initialized outside the class

int clsStatic::x = 1337;	// Static variable initialization
int clsStatic::counter = 0; // Static counter initialization

int main(void)
{
	clsStatic t;

	// ✅ Accessing static variable via object:
	cout << "variable : " << t.x << endl;
	cout << "foo function : " << t.foo() << endl << endl;

	// ✅ Accessing static variable via class name:
	cout << "variable : " << clsStatic::x << endl;
	cout << "foo function : " << clsStatic::foo() << endl << endl;

	// 🚸 Modifying static variable  (in c# 🚸🚸🚸):

	t.x = 42; // Modifying the static variable through the object (it affects all objects)
	cout << "\nmodify : \n" << endl;

	cout << "variable : " << t.x << endl; // Checking modified value object
	cout << "foo function : " << t.foo() << "\n" << endl;

	cout << "variable : " << clsStatic::x << endl;		   // Checking modified value via class name
	cout << "foo function : " << clsStatic::foo() << endl;

	cout << "\nstatic variable Increment : \n" << endl;
	cout << "counter = " << t.increment() << endl;          // 🔄 Incrementing and accessing counter via object
	cout << "counter = " << t.increment() << endl;
	cout << "counter = " << clsStatic::increment() << endl; // 🔄 Incrementing and accessing counter via class name
	cout << "counter = " << clsStatic::increment() << endl;
	cout << "counter = " << clsStatic::increment() << endl;

	return 0;
}
