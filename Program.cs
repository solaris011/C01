using System;

int hero = 10;
int monster = 10;
int round = 0;

while (hero != 0 || monster != 0)
{
    round++;
    System.Console.WriteLine($"Round {round}. Fight!");
    Random rand = new();
    int heroAttack = rand.Next(1, 10);
    monster -= heroAttack;
    System.Console.WriteLine($"\tHero makes an {heroAttack} attack to monster! Monster has {monster} life points left.");
    
    if (monster <= 0) {
        System.Console.WriteLine("Hero wins!");
        break;
    }
        
    int monsterAttack = rand.Next(1, 10);
    hero -= monsterAttack;
    System.Console.WriteLine($"\tMonster makes an {monsterAttack} attack to hero! Hero has {hero} life points left.");
    
    if (hero <= 0) {
        System.Console.WriteLine("Monster wins!");
        break;
    }
    
}
System.Console.WriteLine("Game over :(");