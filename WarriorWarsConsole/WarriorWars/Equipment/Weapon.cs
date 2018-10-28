﻿using WarriorWars.Enum;

namespace WarriorWars.Equipment {
	class Weapon {

		private const int GODD_GUY_DAMAGE = 5;
		private const int BAD_GUY_DAMAGE = 5;


		private int damage;

		public int Damage => damage;

		public Weapon(Faction faction) {

			switch (faction) {
				case Faction.GoodGuy:
					damage = GODD_GUY_DAMAGE;
					break;
				case Faction.BadGuy:
					damage = BAD_GUY_DAMAGE;
					break;
				default:
					break;
			}

		}
	}
}
