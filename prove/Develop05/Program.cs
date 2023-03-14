class Program
{
    static void Main(string[] args)
    {
        bool _play = true;
        // Console.Write("What's your name?: ");
        User user = new User();

        do
        {
            Console.WriteLine("");
            Console.WriteLine($"Points: {user.GetTotalPoints()}");
            string _menu = "\nMenu Options:\n   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit\nSelect any option: ";
            Console.Write(_menu);
            int _userOption = int.Parse(Console.ReadLine());
            switch (_userOption)
            {
                case 1:
                    user.CreateNewGoal();
                    break;

                case 2:
                    user.DisplayGoals();
                    break;

                case 3:
                    user.Save();
                    break;

                case 4:
                    user.Load();
                    break;

                case 5:
                    user.RecordEvent();
                    break;

                case 6:
                    _play = false;
                    break;

                default:
                    Console.WriteLine("That's not an option.");
                    break;

            }
        } while (_play);
    }
}