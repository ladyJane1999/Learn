using WebApplication1;
using WebApplication1.Distance;

//Transport
Boat boat = new Boat();
boat.Move();
Car car = new Car();
car.Move();
Airplane airplane = new Airplane();
airplane.Move();

// Distance
void SavePathToDb(string cargold, Distance milesPath, Distance KmPath)
{
    Console.WriteLine(milesPath.Meters);
    Console.WriteLine(KmPath.Meters);
    Console.WriteLine((milesPath + KmPath).Meters);
}

var id = "test";
var miles = 109;
var kilosl = 46;
var kilos2 = 86;
SavePathToDb(id, Distance.FromMiles(miles), Distance.FromKilometers(kilosl) + Distance.FromMiles(miles));

//Validation 
string s = null;

try
{
    var f = new Foo(s);
}
catch (ArgumentNullException e)
{
    Console.WriteLine("{0} Exception caught.", e);
}

