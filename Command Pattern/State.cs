using EstudosGerais.Command_Pattern.Interfaces;

namespace EstudosGerais.Command_Pattern
{
    public class State : IState
    {
        public State(int statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}
