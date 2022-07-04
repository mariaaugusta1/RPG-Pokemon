using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio.src.Entities
{
    public class Water : Pokemon
    {
        public Water(string Name, int Level, string Type){
            this.Name = Name;
            this.Level = Level;
            this.Type = Type;
        }
        public override string Attack() {
            return this.Name + " usou o jato de agua";
        }
        public string Attack(int bonus) {
            if (bonus >= 6){
            return this.Name + " usou o jato de agua critico com um bonus de " + bonus;
            } else if (bonus > 0 && bonus <= 5) {
            return this.Name + " usou o jato de agua com um bonus de " + bonus;
            } else 
            return this.Name + " usou o jato de agua com efeito normal";
        }
    }
}