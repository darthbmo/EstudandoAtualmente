using EstudosGerais.Command_Pattern.Interfaces;

namespace EstudosGerais.Command_Pattern
{
    public class Receiver : IReceiver<Command, IState>
    {
        public IState Action(Command command)
        {
            command.Execute();
            return new State(200, "OK");
        }
    }
}
