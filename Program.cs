using System;
using System.Collections.Generic;

namespace MiniMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ivan es puto");
            
            char[,] Board = new char[3,3];
            for(int i = 0; i<3; i++)
            {
                for(int j = 0; j<3; j++)
                {
                    Board[i,j] = 'a';
                    Console.WriteLine(Board[i, j]);
                }
            }
            Board board = new Board(Board);
            board.PrindBoard();
            Console.ReadKey();
        }
    }
    public class Node
    {
        char[,] Board;
        List<Node> PosibleStates = new List<Node>();
        public Node(List<Node> posibleStates, char[,] board)
        {
            PosibleStates = posibleStates;
            Board = board;   
        }
    }
    public class Board
    {
        char[,] State;
        public Board(char[, ] state)
        {
            State = state;
        }
        public  void PrindBoard()
        {
            for(int i = 0; i<3; i++)
            {
                for(int j = 0; j<3; j++)
                {
                    Console.WriteLine(State[i,j]);
                }
            }
        }
    }

}
