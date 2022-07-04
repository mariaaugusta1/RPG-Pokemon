using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio.src.Entities
{
    public abstract class Pokemon
    {
        public Pokemon (string Name, int Level, string Type) {
            this.Name = Name;
            this.Level = Level;
            this.Type = Type; 
        }

        public Pokemon () {

        }
        public string? Name;
        public int? Level;
        public string? Type;

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.Type;
        }
        public virtual string Attack(){
            return this.Name + "atacou";
        }
    }
}