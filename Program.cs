using DesignPatterns.Behavioral;
using DesignPatterns.Creational;
using DesignPatterns.Functional;
using DesignPatterns.Structural;

////////////////////////////////////Behavioral Patterns

//////////////Chain of Responsibility////////////////////

Handler h1 = new ConcreteHandler1();
Handler h2 = new ConcreteHandler2();
Handler h3 = new ConcreteHandler3();

h1.SetSuccessor(h2);
h2.SetSuccessor(h3);


// Get ejnkins to triger build

var someVal = "a a a 1 2 value";
Console.WriteLine(someVal);



int[] requests = { 5, 14, 22, 18, 3, 27, 20 };

foreach (int request in requests)
{
    h1.HandleRequest(request);
}

////////////////////////Command//////////////////////////
Light livingRoomLight = new Light();

ICommand turnOn = new TurnOnCommand(livingRoomLight);
ICommand turnOff = new TurnOffCommand(livingRoomLight);

RemoteControl remote = new RemoteControl();

// Turn the light on
remote.SetCommand(turnOn);
remote.PressButton();

// Undo the command (turn it off)
remote.PressUndo();

// Turn the light off
remote.SetCommand(turnOff);
remote.PressButton();

// Undo the command (turn it on)
remote.PressUndo();

//////////////////////Interpreter////////////////////////
// Represents "3 + 5 - 2"
IExpression number1 = new NumberExpression(3);
IExpression number2 = new NumberExpression(5);
IExpression number3 = new NumberExpression(2);

IExpression addition = new AddExpression(number1, number2); // 3 + 5
IExpression subtraction = new SubtractExpression(addition, number3); // (3 + 5) - 2

Console.WriteLine($"Result: {subtraction.Interpret()}"); // Output: Result: 6


/////////////////////////Mediator/////////////////////////
var mediator = new ConcreteMediator();

var colleague1 = new ConcreteColleague1(mediator);
var colleague2 = new ConcreteColleague2(mediator);

mediator.SetColleague1(colleague1);
mediator.SetColleague2(colleague2);

// Colleague1 performs an action
colleague1.DoAction(); // Output: Colleague 1 is doing an action.
//         Mediator responds to Action1 and triggers Action2.
//         Colleague 2 is responding to another action.

// Colleague2 performs another action
colleague2.DoAnotherAction(); // Output: Colleague 2 is doing another action.
//         Mediator responds to Action2 and triggers Action1.
//         Colleague 1 is responding

///////////////////////Observer///////////////////////
// Create the subject
ConcreteSubject subject = new ConcreteSubject();

// Create observers
IObserver observerA = new ConcreteSubject.ConcreteObserverA();
IObserver observerB = new ConcreteSubject.ConcreteObserverB();

// Attach observers to the subject
subject.Attach(observerA);
subject.Attach(observerB);

// Change the state of the subject and notify observers
subject.ChangeState("State 1");

// Detach an observer and change the state again
subject.Detach(observerB);
subject.ChangeState("State 2");

////////////////////////////////////Creational Patterns

/////////////////////Abstract Factory/////////////////

IAbstractFactory factoryA = new FactoryA();
IProd productA = factoryA.CreateProduct();
IService serviceA = factoryA.CreateService();

Console.WriteLine($"FactoryA created {productA.GetName()} and {serviceA.GetService()}");

IAbstractFactory factoryB = new FactoryB();
IProd productB = factoryB.CreateProduct();
IService serviceB = factoryB.CreateService();

Console.WriteLine($"FactoryB created {productB.GetName()} and {serviceB.GetService()}");

/////////////////////////Builder//////////////////////

// Create a builder instance
IComputerBuilder builder = new GamingComputerBuilder();

// Create a director instance and construct the computer
ComputerDirector director = new ComputerDirector(builder);
director.ConstructComputer();

// Get the constructed computer
Computer computer = director.GetComputer();

// Print the constructed computer
Console.WriteLine(computer);
// Output: Computer [CPU=Intel Core i9, RAM=32GB DDR4, Storage=1TB SSD, GPU=NVIDIA GeForce RTX 3080]

//////////////////////Factory Method//////////////////
Creator creatorA = new ConcreteCreatorA();
creatorA.DoWork();

Creator creatorB = new ConcreteCreatorB();
creatorB.DoWork();

/////////////////////////Prototype////////////////////
// Create an instance of Circle and set properties
CircleX circle1 = new CircleX { Id = "1", Radius = 5.0 };
Console.WriteLine("Original Circle: " + circle1);

// Clone the circle
CircleX circle2 = (CircleX)circle1.Clone();
circle2.Id = "2";
circle2.Radius = 10.0;
Console.WriteLine("Cloned Circle: " + circle2);

// Create an instance of Rectangle and set properties
RectangleX rectangle1 = new RectangleX { Id = "3", Width = 4.0, Height = 6.0 };
Console.WriteLine("Original Rectangle: " + rectangle1);

// Clone the rectangle
RectangleX rectangle2 = (RectangleX)rectangle1.Clone();
rectangle2.Id = "4";
rectangle2.Width = 8.0;
rectangle2.Height = 12.0;
Console.WriteLine("Cloned Rectangle: " + rectangle2);

///////////////////////Singleton/////////////////////

Singleton singleton = Singleton.Instance;
singleton.DoSomething();

ThreadSafeSingleton threadSafeSingleton = ThreadSafeSingleton.Instance;
threadSafeSingleton.DoSomething();

////////////////////////////////////Functional Patterns

////////////////////HigherOrderFunctions//////////////
List<int> numbers = [1, 2, 3, 4, 5];

// Applying the Square function to the list of numbers
List<int> squaredNumbers = HigherOrderFunction.ApplyFunction(numbers, HigherOrderFunction.Square);
Console.WriteLine("Squared Numbers: " + string.Join(", ", squaredNumbers));

// Applying the Double function to the list of numbers
List<int> doubledNumbers = HigherOrderFunction.ApplyFunction(numbers, HigherOrderFunction.Double);
Console.WriteLine("Doubled Numbers: " + string.Join(", ", doubledNumbers));

////////////////////////Immutability//////////////////
// Create an immutable Person instance
Person person = new Person("Alice", 30);

// Print the original person
Console.WriteLine("Original Person: " + person);

// Create a new Person instance with an updated age
Person updatedPerson = person.WithUpdatedAge(31);

// Print the updated person
Console.WriteLine("Updated Person: " + updatedPerson);

// Ensure the original person is unchanged
Console.WriteLine("Original Person (Unchanged): " + person);

///////////////////Pure Functions///////////////////
// Testing the pure functions
Console.WriteLine("Square of 5: " + PureFunctions.Square(5)); // Output: 25
Console.WriteLine("Addition of 3 and 4: " + PureFunctions.Add(3, 4)); // Output: 7

// Pure functions always produce the same output for the same input
Console.WriteLine("Square of 5: " + PureFunctions.Square(5)); // Output: 25
Console.WriteLine("Addition of 3 and 4: " + PureFunctions.Add(3, 4)); // Output: 7


//////////////////Recursion////////////////////////
// Testing the recursive factorial function
int number = 5;
int result = Recursion.Factorial(number);
Console.WriteLine($"Factorial of {number} is {result}"); // Output: Factorial of 5 (5x4x3x2x1) is 120

///////////////Pattern Matching////////////////////
// Create different shapes
Shape circle = new Circle(5);
Shape rectangle = new Rectangle(4, 6);
Shape triangle = new Triangle(3, 4);

// Calculate and print the area of each shape
Console.WriteLine($"Area of Circle: {PatternMatchingCalculator.CalculateArea(circle)}");      
Console.WriteLine($"Area of Rectangle: {PatternMatchingCalculator.CalculateArea(rectangle)}"); 
Console.WriteLine($"Area of Triangle: {PatternMatchingCalculator.CalculateArea(triangle)}");

/////////////////////Monad///////////////////////

Maybe<int> num = Maybe<int>.Some(5);
Maybe<int> res = num.Bind(x => Maybe<int>.Some(x * 2));

Console.WriteLine(res); // Output: Some(10)

Maybe<int> none = Maybe<int>.None();
Maybe<int> noneResult = none.Bind(x => Maybe<int>.Some(x * 2));

Console.WriteLine(noneResult); // Output: None

///////////////Functional Composition/////////////
// List of integers to transform
List<int> nums= new List<int> { 1, 2, 3, 4, 5 };

// Compose MultiplyByTwo and AddTen
Func<int, int> multiplyByTwoThenAddTen = 
    FunctionCompositionExample.Compose(FunctionCompositionExample.MultiplyByTwo, FunctionCompositionExample.AddTen);

// Apply the composed function to each number in the list
List<int> transformedNumbers = nums.Select(multiplyByTwoThenAddTen).ToList();

// Print the transformed numbers
Console.WriteLine("Transformed Numbers: " + string.Join(", ", transformedNumbers));
// Output: Transformed Numbers: 12, 14, 16, 18, 20


////////////////////////////////////Structural Patterns

/////////////////////////Adapter///////////////////////
Adaptee adaptee = new Adaptee();
ITarget target = new Adapter(adaptee);

Console.WriteLine(target.GetRequest());

/////////////////////////Bridge////////////////////////
IImplementer implementerA = new ConcreteImplementerA();
IImplementer implementerB = new ConcreteImplementerB();

Abstraction abstractionA = new RefinedAbstractionA(implementerA);
Abstraction abstractionB = new RefinedAbstractionB(implementerB);

abstractionA.Operation();
abstractionB.Operation();

/////////////////////////Composite/////////////////////////
var file1 = new FileX("File1.txt");
var file2 = new FileX("File2.txt");

var dir1 = new DirectoryX("Dir1");
var dir2 = new DirectoryX("Dir2");

dir1.Add(file1);
dir1.Add(dir2);

dir2.Add(file2);

var root = new DirectoryX("Root");
root.Add(dir1);

root.Display(1);

/////////////////////////Decorator////////////////////////
Beverage beverage = new Espresso();
Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");

beverage = new Milk(beverage);
Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");

beverage = new Sugar(beverage);
Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");

beverage = new Milk(beverage);
Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");

/////////////////////////Facade//////////////////////////
Facade facade = new Facade();

// Use the simplified interface provided by the Facade
facade.Operation1();

facade.Operation2();

///////////////////////.Flyweight/////////////////////////
CharacterFactory factory = new CharacterFactory();

string document = "ABAB";
int row = 0;
int column = 0;

foreach (char c in document)
{
    CharacterX character = factory.GetCharacter(c);
    character.Display(row, column);
    column += 1;
}

/////////////////////////Proxy///////////////////////////
ISubjectX subjectx = new Proxy();
subjectx.Request();