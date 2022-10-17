using System;
using System.Collections;
using System.Collections.Generic;

//1. 

public class Enemy {
 public static int NumberOfEnemies { get; private set; }
 public int Health { get; set; }
 public Enemy(int health) {
 NumberOfEnemies++;
 Health = health;
 }
 public void Die() {
 NumberOfEnemies--;
 Health = 0;
 }
}

//1.1.

Console.WriteLine(monster.Health);
Console.WriteLine(Enemy.NumberOfEnemies);

//1.2

Faz sentido essa propriedade ser static porque não pode ser referenciada por
meio de uma instancia, apenas pelo nome do tipo, neste caso Enemy. Por isso
NumberOfEnemies não tem nenhum tipo especifico de enemy.

//1.3

Apenas dentro da classe Enemy porque tem o set private, ou seja, é readonly.

//2.

enum MonsterType { Troll, Ogre, Elf, Demon }
class Monster {
 public const double MaxHealth = 100;
 public const int MaxStrength = 200;
 public MonsterType Type { get; set; }
 public double Health { get; set; }
 public int Strength { get; set; }
}

//2.1

Não.

//2.2

private Monster CreateRandomMonsters (int n)
{
    List<Monster> ms = new List<Monster>(n);

    foreach(Monster m in ms)
    {
        n = rnd;

        return m;
    }
}