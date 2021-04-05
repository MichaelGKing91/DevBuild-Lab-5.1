using System;

namespace Lab_5._1
{
    class GameCharacter
    {
        private string name;
        private int strength;
        private int intelligence;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }
        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }
        public GameCharacter(string cName, int cStr, int cIntel)
        {
            name = cName;
            strength = cStr;
            intelligence = cIntel;
        }
        public virtual void Play()
        {
            Console.WriteLine("Character Profile: ");
            Console.WriteLine($"- Name: {Name}");
            Console.WriteLine($"- Strength: {Strength}");
            Console.WriteLine($"- Intelligence: {Intelligence}");
        }
    }
    class Warrior : GameCharacter
    {
        private string weapondType;
        public string WeapondType
        {
            get { return weapondType; }
            set { weapondType = value; }
        }
        public Warrior(string cName, int cStr, int cIntel, string cWeap) : base(cName, cStr, cIntel)
        {
            weapondType = cWeap;
        }
        public override void Play()
        {
            Console.WriteLine("Character Profile: ");
            Console.WriteLine($"- Name: {Name}");
            Console.WriteLine($"- Strength: {Strength}");
            Console.WriteLine($"- Intelligence: {Intelligence}");
            Console.WriteLine($"- Weapond: {WeapondType}");
        }
    }
    class MagicUsingCharacter : GameCharacter
    {
        private int magicalEnergy;
        public int MagicalEnergy
        {
            get { return magicalEnergy; }
            set { magicalEnergy = value; }
        }
        public MagicUsingCharacter(string cName, int cStr, int cIntel, int cMag) : base(cName, cStr, cIntel)
        {
            magicalEnergy = cMag;
        }
        public override void Play()
        {
            Console.WriteLine("Character Profile: ");
            Console.WriteLine($"- Name: {Name}");
            Console.WriteLine($"- Strength: {Strength}");
            Console.WriteLine($"- Intelligence: {Intelligence}");
            Console.WriteLine($"- Magical Energy: {MagicalEnergy}");
        }
    }
    class Wizard : MagicUsingCharacter
    {
        private int spellNumber;
        public int SpellNumber
        {
            get { return spellNumber; }
            set { spellNumber = value; }
        }
        public Wizard(string cName, int cStr, int cIntel, int cMag, int cSpell) : base(cName, cStr, cIntel, cMag)
        {
            spellNumber = cSpell;
        }
        public override void Play()
        {
            Console.WriteLine("Character Profile: ");
            Console.WriteLine($"- Name: {Name}");
            Console.WriteLine($"- Strength: {Strength}");
            Console.WriteLine($"- Intelligence: {Intelligence}");
            Console.WriteLine($"- Magical Energy: {MagicalEnergy}");
            Console.WriteLine($"- Magical Spells: {SpellNumber}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> gameCharacters = new List<GameCharacter>();
            gameCharacters.Add(new Warrior("Tnarg the Barbarian", 16, 100, "Long-sword"));
            gameCharacters.Add(new Warrior("Kincaid the Fighter", 16, 100, "Long-bow"));
            gameCharacters.Add(new Wizard("Grant the Viking", 10, 100, 60, 6));
            gameCharacters.Add(new Wizard("Lady Witherell the Wizard", 6, 100, 150, 5));
            gameCharacters.Add(new Wizard("Pearl the Magician", 4, 150, 250, 2));

            foreach (GameCharacter character in gameCharacters)
            {
                character.Play();
            }
        }
    }
}
