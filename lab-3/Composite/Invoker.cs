using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Invoker
    {
        private List<ICommand> _commands = new List<ICommand>();

        public Invoker(List<ICommand> commands) 
        {
            _commands = commands;
        }

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void UndoLastCommand()
        {
            if (_commands.Count > 0)
            {
                var lastCommand = _commands[_commands.Count - 1];
                lastCommand.Undo();
                _commands.Remove(lastCommand);
            }
        }
    }
}
