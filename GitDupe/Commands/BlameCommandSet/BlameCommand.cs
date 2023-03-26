using GitDupe.Commands.BlameCommandSet;
using Mono.Options;

namespace GitDupe.Commands;

internal class BlameCommand : GitCommand
{
    public BlameCommandArguments blameArguments = new ();
    public BlameCommand() : base("blame", "Figure out who to blame (or give kudos to).")
    {
        
        Options = new OptionSet()
        {
            "usage: blame [OPTIONS] <filename>",
            "",
            "Provides the author name for each line of code specified.",
            { "filename=", "The file to be inspected.", f => blameArguments.Filename = f},
            { "help|h", "Show this help message", h => ShowHelp = h is not null },
        };
    }

    protected override int InvokeInternal ()
    {
        // invoke functionality for blame command
        return 0;
    }
}