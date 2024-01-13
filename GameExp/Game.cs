using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExp
{
    internal static class Game
    {

        private static Character _playerCharacter;
        private static Character _playerTarget;
        private static Character TargetHero = new Hero("TargetHero");
        private static Character TargetEnemy = new Enemy("TargetEnemy");
        private static Character TargetCreature = new Creature("TargerCreature");
        private static List<Character> _targets = new List<Character> { TargetHero, TargetEnemy, TargetCreature };


        public static void ChoosePlayerCharacter(int option)
        {
            switch (option)
            {
                case 1:
                    _playerCharacter = new Hero("Hero");

                    break;
                case 2:
                    _playerCharacter = new Enemy("Enemy");
                    break;
                case 3:
                    _playerCharacter = new Creature("Creature");
                    break;
            }

        }
        public static void ChooseTargetCharacter(int option)
        {

            switch (option)
            {
                case 1:
                    {

                        _playerTarget = _targets[0];
                        break;
                    }
                case 2:
                    {
                        _playerTarget = _targets[1];
                        break;
                    }

                case 3:
                    {
                        _playerTarget = _targets[2];
                        break;
                    }
            }

        }
        public static void ShowPlayerCharacter()
        {
            Console.WriteLine(_playerCharacter.Name);
        }
        public static void ShowTargetCharacter()
        {
            Console.WriteLine(_playerTarget.Name);
        }
        public static void Atack()
        {
            _playerTarget.Health -= _playerCharacter.Power;
            Console.WriteLine($"Atack Done.\n" +
                $"Target Health: {_playerTarget.Health}");
        }
    }
}
