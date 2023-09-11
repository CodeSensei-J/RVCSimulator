using RVCSimulator.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RVCSimulator.Unit;

internal class UnitMovement
{
    public static (int, int, char) MoveUnit(int currentX, int currentY, char direction, char command)
    {
        int newX = currentX;
        int newY = currentY;
        char newDirection = direction;

        switch (command)
        {
            case 'w':
                if (newDirection == 'N')
                {
                    newY--;
                }
                else if (newDirection == 'W')
                {
                    newX--;
                }
                else if (newDirection == 'E')
                {
                    newX++;
                }
                else if (newDirection == 'S')
                {
                    newY++;
                }
                break;

            case 's':
                if (newDirection == 'N')
                {
                    newY++;
                }
                else if (newDirection == 'W')
                {
                    newX++;
                }
                else if (newDirection == 'E')
                {
                    newX--;
                }
                else if (newDirection == 'S')
                {
                    newY--;
                }
                break;

            case 'a':
                if (newDirection == 'N')
                {
                    newDirection = 'W';
                }
                else if (newDirection == 'W')
                {
                    newDirection = 'S';
                }
                else if(newDirection == 'S')
                {
                    newDirection = 'E';
                }
                else if (newDirection == 'E')
                {
                    newDirection = 'N';
                }
                break;

            case 'd':
                if (newDirection == 'N')
                {
                    newDirection = 'E';
                }
                else if (newDirection == 'W')
                {
                    newDirection = 'N';
                }
                else if (newDirection == 'S')
                {
                    newDirection = 'W';
                }
                else if (newDirection == 'E')
                {
                    newDirection = 'S';
                }
                break;

            default: throw new ArgumentException("Ogiltigt kommando.");
        }

        return (newX, newY, newDirection);
    }
}
