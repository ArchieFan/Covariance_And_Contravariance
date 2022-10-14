using Covariance_And_Contravariance;

Base x = new Base();
Base y = new Derived();

x.DoSomething();
y.DoSomething();
//y.DoMore(); <-- not allow

Derived x2 = new Derived();
x2.DoSomething();
x2.DoMore();


// Covariance 
IProducer<Base> prodOfBase = null!;
Base a = prodOfBase.Produce();
//Derived b = prodOfBase.Produce();  <-- not allow

IProducer<Derived> prodOfDerived = null!;
Derived b = prodOfDerived.Produce();
Base c = prodOfDerived.Produce();

// Contravariance
IConsumer<Base> consOfBase = null!;
consOfBase.Cosume(new Base());
consOfBase.Cosume(new Derived());

IConsumer<Derived> consOfDerived = null!;
consOfDerived.Cosume(new Derived());
//consOfDerived.Cosume(new Base());  <-- not allow

IProducer<Base> p = prodOfBase; // IProducer<Base>
IProducer<Base> q = prodOfDerived;  // IProducer<Derived>

IProducer<Derived> r = prodOfDerived;  // IProducer<Derived>
//IProducer<Derived> s = prodOfBase;  <-- not allow

IConsumer<Derived> t = consOfDerived; // IConsumer<Derived>
IConsumer<Derived> u = consOfBase; // IConsumer<Derived>

IConsumer<Base> v = consOfBase; // IConsumer<Derived>
//IConsumer<Base> w = consOfDerived; <-- not allow