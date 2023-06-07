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
        public delegate void TapeChanged(Post_Machine machine);
        public event TapeChanged Notify;
        List<bool> rightTape = new List<bool>(53);
        List<bool> leftTape = new List<bool>(53);
        int currentPos = 0;
        int currentLine = 1;
        private Dictionary<int, string> commands = new Dictionary<int, string>();
        public Post_Machine(int startPos)
        {
            currentPos = startPos;
            for (int i = 0; i < 51; i++)
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

        public void If(int lineIfZero, int lineIfOne)
        {
            if (currentPos >= 0)
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
            if (currentPos >= 0)
            {
                rightTape[currentPos] = true;
            }
            if (currentPos < 0)
            {
                leftTape[Math.Abs(currentPos)] = true;
            }
            currentLine = numOfLine;
            Notify?.Invoke(this);
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
            Notify?.Invoke(this);
        }
        public void MarkAllPositions()
        {
            for (int i = 50; i > -51; i--)
            {
                if (i >= 0)
                {
                    rightTape[i] = false;
                }
                else
                {
                    leftTape[Math.Abs(i)] = false;
                }
            }
        }
        public void NotifyLabels()
        {
            Notify?.Invoke(this);
        }
        public void Start()
        {
            currentLine = 1;
            string command = commands[1];
            string[] numOfNextCommands = new string[2];
            string actualCommand = "";
            string tempCommand = "";
            bool ifCommnad = false;
            commands.Add(0, "end");
            while (true)
            {
                if (command.Contains("end"))
                {
                    break;
                }
                for (int i = 0; i < command.Length; i++)
                {
                    if (command[i] == ' ')
                    {
                        actualCommand = tempCommand;
                        tempCommand = "";
                        continue;
                    }
                    if (command[i] == ',')
                    {
                        numOfNextCommands[0] = tempCommand;
                        ifCommnad = true;
                        tempCommand = "";
                        continue;
                    }
                    tempCommand += command[i];
                }
                if (ifCommnad)
                {
                    numOfNextCommands[1] = tempCommand;
                }
                else
                {
                    numOfNextCommands[0] = tempCommand;
                }

                if (actualCommand == "<")
                {
                    MoveLeft(int.Parse(numOfNextCommands[0]));
                }
                else if (actualCommand == ">")
                {
                    MoveRight(int.Parse(numOfNextCommands[0]));
                }
                else if (actualCommand == "?")
                {
                    If(int.Parse(numOfNextCommands[0]), int.Parse(numOfNextCommands[1]));
                }
                else if (actualCommand == "1")
                {
                    MarkCurrentPos(int.Parse(numOfNextCommands[0]));
                }
                else if (actualCommand == "0")
                {
                    CleanCurrentpos(int.Parse(numOfNextCommands[0]));
                }
                
                command = commands[currentLine];
                tempCommand = "";
                ifCommnad = false;
            }

        }
        public Dictionary<int, string> Commands { get { return commands; } set { commands = value; } }
        public List<bool> RightTape { get { return rightTape; } set { rightTape = value; } }
        public List<bool> LeftTape { get { return leftTape; } set { leftTape = value; } }
        public int CurrentPos { get { return currentPos; } set { currentPos = value; } }
    }
}
