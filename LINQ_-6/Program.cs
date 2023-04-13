using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ__6
{
    internal class Program
    {
        public static void Main()
        {
            List<Soldier> firstTeam = new List<Soldier>()
            {
                new Soldier("Бежин В.В","АК-47","Рядовой",12),
                new Soldier("Бакин В.В","АК-47","Рядовой",12),
                new Soldier("Барышников К.К","АК-47","Рядовой",12),
                new Soldier("Бабушкин А.В","АК-47","Рядовой",12),
                new Soldier("Воронин К.Д","АК-47","Рядовой",12),
                new Soldier("Воронин К.Д","РПК","Ефрейтор",6),
                new Soldier("Бажин В.В","РПК","Ефрейтор",6),
                new Soldier("Бажин В.Ю","РПК","Ефрейтор",6),
                new Soldier("Барышников Б.К","ПМ","Под-полковник",36),
                new Soldier("Бабушкин Д.В","ПМ","Полковник",36),
            };

            
            
            var selectedInfo = firstTeam.Select(solder => new { solder.Name, solder.Rank }).ToList();
            selectedInfo.ForEach( solder=>Console.WriteLine(solder));
            
            Console.ReadKey();
        }
    }

    public class Soldier
    {
        public Soldier(string name,string armament,string rank,int lifeTime)
        {
            Name = name;
            Armament = armament;
            Rank = rank;
            LifeTime = lifeTime;
        }

        public string Name { get; }
        public string Armament { get; }
        public string Rank { get; }
        public int LifeTime { get; }
    }
}