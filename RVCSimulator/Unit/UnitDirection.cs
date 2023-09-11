using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVCSimulator.Unit;

internal class UnitDirection
{
    public static bool IsValidDirection(char direction)
    {
        return direction == 'N' || direction == 'S' || direction == 'W' || direction == 'E';
    }

    public static char GetDirectionSymbol(char direction)
    {
        switch (direction)
        {
            case 'N':
                return '^';
            case 'S':
                return 'v';
            case 'W':
                return '<';
            case 'E':
                return '>';
            default:
                throw new ArgumentException("Ogiltig riktning");
        }
    }
}
