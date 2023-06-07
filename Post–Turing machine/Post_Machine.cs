using System;
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
        private Dictionary<int,string> commands = new Dictionary<int, string>();
        public Post_Machine(int startPos) 
        {
            commands.Add(0, "end");
            currentPos = startPos;
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
                if (leftTape[Math.Abs(currentPos)] == false)
                {
                    currentLine = lineIfZero;
                }
                else
                {
                    currentLine = lineIfOne;
                }
            }
            
        }
        public void MarkCurrentPos(int numOfLine)
        {
            if(currentPos >= 0)
            {
                rightTape[currentPos] = true;
            }
            if (currentPos < 0)
            {
                leftTape[Math.Abs(currentPos)] = true;
            }
            currentLine = numOfLine;
        }
        public void CleanCurrentpos(int numOfLine) 
        {
            if (currentPos >= 0)
            {
                rightTape[currentPos] = false;
            }
            if (currentPos < 0)
            {
                leftTape[Math.Abs(currentPos)] = false;
            }
            currentLine = numOfLine;
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
        public void Start()
        {
            string command = commands[1];
            
            while (true)
            {
                if (command[0]=='<')
                {
                    MoveLeft(command[2]-'0');
                }
                else if (command[0] == '>')
                {
                    MoveRight(command[2] - '0');
                }
                else if (command[0] == '?')
                {
                    If(command[2] - '0', command[4] - '0');
                }
                else if (command[0] == '1')
                {
                    MarkCurrentPos(command[2] - '0');
                }
                else if (command[0] == '0')
                {
                    CleanCurrentpos(command[2] - '0');
                }
                else if(command.Contains("end"))
                {
                    break;
                }
                command = commands[currentLine];
            }
        }
       public Dictionary<int, string> Commands { get {return commands; } set { commands = value; } }
        public List<bool> RightTape { get { return rightTape; } set {  rightTape = value; } }
        public List<bool> LeftTape { get { return leftTape; } set { leftTape = value; } }
        public int CurrentPos { get { return currentPos; } set {  currentPos = value; } }
    }
}
