using EstudosGerais.Command_Pattern.Interfaces;

namespace EstudosGerais.Command_Pattern
{
    public class Command : ICommand
    {
        public Command(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public void Execute()
        {
            Console.WriteLine($"Executing... {this.Id} - {this.Name}");
        }
    }
}
