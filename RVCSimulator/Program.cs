using RVCSimulator.Table;
using RVCSimulator.Unit;

Console.WriteLine("Ange rummets storlek.");

Console.WriteLine("Ange ett två tal och separera de med X.");
Console.Write("Värde: ");
string tableSizeInput = Console.ReadLine();

string[] tableSizeXY = tableSizeInput.Split(new[] { 'X', 'x' }, StringSplitOptions.RemoveEmptyEntries);

if (tableSizeXY.Length == 2)
{
    if (int.TryParse(tableSizeXY[0], out int x) && int.TryParse(tableSizeXY[1], out int y))
    {
        Console.WriteLine($"{x}x{y}");

        Console.WriteLine("Skapar rummet...");
        char[,] table = CreateTable.CreateNewTable(x, y);
        Thread.Sleep(4000);

        Console.WriteLine("Rummet är skapat, X = {0} och Y = {1}.", x, y);

        Console.WriteLine("Placera roboten med två heltal separerade med X.");
        string placementInput = Console.ReadLine();

        string[] unitPlacement = placementInput.Split(new[] {'X', 'x'}, StringSplitOptions.RemoveEmptyEntries);
        if (unitPlacement.Length == 2)
        {
            if (int.TryParse(unitPlacement[0], out int objX) && int.TryParse(unitPlacement[1], out int objY))
            {
                Console.WriteLine($"Robotens placering: {objX}x{objY}");

                Console.WriteLine("Välj åt vilket håll roboten ska titta åt.");
                Console.WriteLine("N = upp, S = ner, W = vänster, E = höger.");

                Console.Write("Välj: ");
                char direction = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (UnitDirection.IsValidDirection(direction))
                {
                    char objectSymbol = UnitDirection.GetDirectionSymbol(direction);
                    UnitPosition.PlaceUnitOnTable(table, objX, objY, objectSymbol);

                    Console.WriteLine("Rummet med roboten:");
                    PrintTable.PrintNewTable(table);
                }
                else
                {
                    Console.WriteLine("Riktningen måste vara giltig.");
                }

                Console.WriteLine("Ange kommandon för att förflytta roboten.");
                Console.WriteLine("w = framåt, s = bakåt, a = rotera 90grader åt vänster, d = rotera 90grader åt höger.");

                Console.Write("Välj: ");
                string commands = Console.ReadLine().ToLower();

                bool unitHitSomething = false;

                foreach (char command in commands)
                {
                    if (!unitHitSomething)
                    {
                        if (command == 'w' || command == 's' || command == 'a' || command == 'd')
                        {
                            (objX, objY, direction) = UnitMovement.MoveUnit(objX, objY, direction, command);
                            Console.WriteLine("X:{0}, Y:{1}, R:{2}", objX, objY, direction);
                            Thread.Sleep(1000);

                            if (objX < 0 || objY < 0 || objX >= x || objY >= y)
                            {
                                Console.WriteLine($"Roboten gick utanför rummet på X:{objX}, Y:{objY}.");
                                unitHitSomething = true;
                            }
                        }
                    }
                }

                if (!unitHitSomething)
                {
                    Console.WriteLine("Roboten står på {0}, {1}. I riktning mot {2}", objX, objY, direction);
                }
            }
            else
            {
                Console.WriteLine("Ange två heltal och separera med x.");
            }
        }
        else
        {
            Console.WriteLine("Felaktig inmatning. Ange två heltal och separera med x.");
        }
    }
    else
    {
        Console.WriteLine("Ange två heltal och separera med x.");
    }
}
else
{
    Console.WriteLine("Felaktig inmatning. Ange två heltal och separera med x.");
}


Console.ReadLine();