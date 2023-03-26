using GitDupe.Commands;
using Mono.Options;

namespace GitDupe;

public static class Program
{
    public static int Main (string[] args)
    {
        CommandSet commands = new("git")
        {
            new BlameCommand()
        };
        return commands.Run(args);
    }
}