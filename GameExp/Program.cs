using GameExp;

while (true)
{
    Console.WriteLine("Choose an Option:\n" +
        "1.Choose Your Character\n" +
        "2.Atack\n" +
        "3.ShowPlayerCharacter\n" +
        "4.ShowTargetCharacter\n" +
        "0.Exit\n" +
        "");
    var option = int.Parse(Console.ReadLine());
    switch (option)
    {
        case 0: Environment.Exit(0); break;
        case 1:
            Console.WriteLine("1.Hero\n2.Enemy\n3.Creature");
            var opt = int.Parse(Console.ReadLine());
            Game.ChoosePlayerCharacter(opt);
            break;
        case 2:
            Console.WriteLine("Choose Target:\n1.Hero\n2.Enemy\n3.Creature");
            var opt2 = int.Parse(Console.ReadLine());
            Game.ChooseTargetCharacter(opt2);
            Game.Atack();
            break;
            case 3:
            {
                Game.ShowPlayerCharacter();
                break;
            }
        case 4:
            {
                Game.ShowTargetCharacter();
                break;
            }
    }
}