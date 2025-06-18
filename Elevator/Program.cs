// See https://aka.ms/new-console-template for more information

try
{
    var start = Elevator.Elevator.GetStartFloor();
    var floorsToVisit = Elevator.Elevator.GetFloorsToVisit();
    Elevator.Elevator.Simulate(start, floorsToVisit);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
