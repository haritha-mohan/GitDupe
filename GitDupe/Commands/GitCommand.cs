using Mono.Options;
namespace GitDupe.Commands;

internal abstract class GitCommand : Command
{
    protected bool ShowHelp = false;
    protected GitCommand(string name, string help) : base (name, help) {}
    
    protected GitCommand(string name) : this (name, string.Empty) {}
    
    public sealed override int Invoke (IEnumerable<string> arguments)
    {
        Options.Parse (arguments);
        if (ShowHelp)
        {
            Options.WriteOptionDescriptions(Console.Out);
            return 0;
        }
            
        return InvokeInternal();
    }
    
    protected abstract int InvokeInternal ();
}