int heroHp = 10;
int monsterHp = 10;

Random random = new Random();

do {

int heroAttack = random.Next(1, 11);
monsterHp -=heroAttack;
Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHp} health.");

if (monsterHp<=0) break;

int monsterAttack = random.Next(1, 11);
heroHp -=monsterAttack;
Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHp} health.");

if (heroHp<=0) break;

} while(heroHp > 0 && monsterHp > 0);

Console.WriteLine($"{(monsterHp <= 0 ? "Hero" : "Monster")} wins!");