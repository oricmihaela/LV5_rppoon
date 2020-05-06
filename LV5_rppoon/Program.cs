using System;

namespace LV5_rppoon
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Zadatak
            VirtualProxyDataset virtualProxyDataset = new VirtualProxyDataset("csv.txt");
            User user = User.GenerateUser("Mihaela");
            ProtectionProxyDataset protectionProxyDataset = new ProtectionProxyDataset(user);
            DataConsolePrinter dataConsolePrinter = new DataConsolePrinter();
            Console.WriteLine("Printing VirtualProxyDataset.");
            dataConsolePrinter.Print(virtualProxyDataset);
            Console.WriteLine("Printing ProtectionProxyDataset.");
            dataConsolePrinter.Print(protectionProxyDataset);
            

            //5. Zadatak
            MagentaTheme magentaTheme = new MagentaTheme();
            ReminderNote myNotification = new ReminderNote("Wake Up!", magentaTheme);
            myNotification.Show();

            //6. Zadatak
            LightTheme lightTheme = new LightTheme();
            GroupNotification groupOne = new GroupNotification("Class at 1pm.", lightTheme);
            string newReciever;
            Console.WriteLine("Send note1 to these 4 people: ");
            for (int i = 0; i < 4; i++)
            {
                newReciever = Console.ReadLine();
                groupOne.AddReciever(newReciever);
            }

            GroupNotification groupTwo = new GroupNotification("Class at 4.30pm.", magentaTheme);
            Console.WriteLine("Send note2 to these 4 people: ");
            for (int i = 0; i < 4; i++)
            {
                newReciever = Console.ReadLine();
                groupTwo.AddReciever(newReciever);
            }

            groupOne.Show();
            Console.WriteLine();
            groupTwo.Show();
            Console.WriteLine();

            //7. Zadatak
            Notebook myNotebook = new Notebook(magentaTheme);
            myNotebook.AddNote(groupOne);
            myNotebook.AddNote(groupTwo);
            myNotebook.ChangeTheme(lightTheme);
            myNotebook.Display();

        }
    }
}
