using System;
using System.DirectoryServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string judgeUser = "-u";
            string judgePass = "-p";
            string judgeChange = "-c";
            string judgeDelete = "-d";
            string judgeGroup = "-g";
            string judgeRdp = "-rdp";

            if (args.Length == 6 && args[0].Equals(judgeUser, StringComparison.OrdinalIgnoreCase) &&
                args[2].Equals(judgePass, StringComparison.OrdinalIgnoreCase) &&
                args[4].Equals(judgeGroup, StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    DirectoryEntry AD = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
                    DirectoryEntry NewUser = AD.Children.Add($"{args[1]}", "user");
                    NewUser.Invoke("SetPassword", new object[] { args[3] });
                    NewUser.CommitChanges();

                    DirectoryEntry group;

                    group = AD.Children.Find($"{args[5]}", "group");

                    if (group != null)
                    {
                        group.Invoke("Add", new object[] { NewUser.Path.ToString() });
                    }

                    Console.WriteLine("Successfull");

                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            else if
            (args.Length == 7 && args[0].Equals(judgeUser, StringComparison.OrdinalIgnoreCase) &&
             args[2].Equals(judgePass, StringComparison.OrdinalIgnoreCase) &&
             args[4].Equals(judgeGroup, StringComparison.OrdinalIgnoreCase) &&
             args[6].Equals(judgeRdp, StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    DirectoryEntry AD = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
                    DirectoryEntry NewUser = AD.Children.Add($"{args[1]}", "user");
                    NewUser.Invoke("SetPassword", new object[] { args[3] });

                    NewUser.CommitChanges();
                    DirectoryEntry group;
                    DirectoryEntry rdp_group;

                    group = AD.Children.Find($"{args[5]}", "group");
                    rdp_group = AD.Children.Find("Remote Desktop Users", "group");


                    if (group != null && rdp_group != null)
                    {
                        group.Invoke("Add", new object[] { NewUser.Path.ToString() });
                        rdp_group.Invoke("Add", new object[] { NewUser.Path.ToString() });
                    }

                    Console.WriteLine("Successfull");
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (args.Length == 3 && args[0].Equals(judgeChange, StringComparison.OrdinalIgnoreCase))
            {

                try
                {
                    DirectoryEntry AD = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
                    DirectoryEntry Username = AD.Children.Find($"{args[1]}", "User");
                    if (Username != null)
                    {

                        Username.Invoke("SetPassword", new object[] { args[2] });
                        Username.CommitChanges();
                        Console.WriteLine("Successfull");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }

            else if (args.Length == 2 && args[0].Equals(judgeDelete, StringComparison.OrdinalIgnoreCase))
            {

                try
                {
                    DirectoryEntry AD = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
                    DirectoryEntry DelUsername = AD.Children.Find($"{args[1]}", "User");

                    if (DelUsername != null)
                    {
                        AD.Children.Remove(DelUsername);
                        Console.WriteLine("Successfull");

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            else
            {
                Console.WriteLine("Usage: BypassAddUser.exe -u username -p password -g groups");
                Console.WriteLine("       BypassAddUser.exe -u username -p password -g groups -rdp");
                Console.WriteLine("       BypassAddUser.exe -c username NewPassword");
                Console.WriteLine("       BypassAddUser.exe -d username");
            }

        }
    }
}