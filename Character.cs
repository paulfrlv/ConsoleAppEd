using System;

namespace ConsoleApp {
    public class Character {
        private readonly int speed;
        public int Health { get; private set; } = 100;
        public string Race { get; private set; }
        public uint Armor { get; private set; }
        public bool IsHuman { get; private set; }
        
        public Character(string race, int speed, int health, bool isHuman) {
            this.Race = race;
            Armor = 1000;
            this.speed = speed;
            this.Health = health;
            this.IsHuman = isHuman;

        }

        public void Hit(int damage) {
           	if (damage > Health) {
                 damage = Health;
            }
            Health -= damage;
       	}
    }
}