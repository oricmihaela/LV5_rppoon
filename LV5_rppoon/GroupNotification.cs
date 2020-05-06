using System;
using System.Collections.Generic;
using System.Text;

namespace LV5_rppoon
{
    class GroupNotification : Note
    {
        
        private List<string> recievers;

        public GroupNotification(string newMessage, ITheme newTheme) : base(newMessage, newTheme)
        {
            this.recievers = new List<string>();
        }

        public void AddReciever(string newReciever)
        {
            recievers.Add(newReciever);
        }
        public void RemoveReciever(string exReciever)
        {
            for(int i = 0; i < recievers.Count; i++)
            {
                if(recievers[i] == exReciever)
                {
                    recievers.RemoveAt(i);
                }
            }
        }
        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine(Message);
            Console.WriteLine("Sent to:");
            foreach (string current in recievers)
            {
                Console.Write(current + ", ");
            }
            Console.ResetColor();
        }
    }
}
