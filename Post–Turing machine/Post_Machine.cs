﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Turing_machine
{
    public enum Actions
    {
        MoveLeft,
        MoveRight,
        If,
        MarkCurrentPos,
        CleanCurrentPos
    }
    public class Post_Machine
    {
        List<bool> rightTape = new List<bool>(53);
        List<bool> leftTape = new List<bool>(53);
        int currentPos = 0;
        int currentLine = 1;
        private Dictionary<int,Actions> commands = new Dictionary<int,Actions>();
        public Post_Machine() 
        { 
            for(int i = 0;i<51;i++)
            {
                rightTape.Add(false);
                leftTape.Add(false);
            }
            
        }
        public void MoveLeft(int numOfLine)
        {
            currentPos -= 1;
            currentLine = numOfLine;
        }
        public void MoveRight(int numOfLine)
        {
            currentPos += 1;
            currentLine = numOfLine;
        }

        public void If(int lineIfZero,int lineIfOne)
        {
            if(currentPos>=0)
            {
                if (rightTape[currentPos] == false)
                {
                    currentLine = lineIfZero;
                }
                else
                {
                    currentLine = lineIfOne;
                }
            }
            else
            {
                if (leftTape[currentPos] == false)
                {
                    currentLine = lineIfZero;
                }
                else
                {
                    currentLine = lineIfOne;
                }
            }
            
        }
        public void MarkCurrentPos()
        {
            if(currentPos >= 0)
            {
                rightTape[currentPos] = true;
            }
            if (currentPos < 0)
            {
                rightTape[currentPos] = true;
            }
        }
        public void CleanCurrentpos() 
        {
            if (currentPos >= 0)
            {
                rightTape[currentPos] = false;
            }
            if (currentPos < 0)
            {
                rightTape[currentPos] = false;
            }
        }
        public void MarkAllPositions()
        {
            for(int i = 50; i>-51; i--)
            {
                if(i>=0)
                {
                    rightTape[i] = false;
                }
                else
                {
                    leftTape[Math.Abs(i)] = false;
                }
            }
        }
       public Dictionary<int,Actions> Commands { get {return commands; } set { commands = value; } }
        public List<bool> RightTape { get { return rightTape; } set {  rightTape = value; } }
        public List<bool> LeftTape { get { return leftTape; } set { leftTape = value; } }
    }
}
