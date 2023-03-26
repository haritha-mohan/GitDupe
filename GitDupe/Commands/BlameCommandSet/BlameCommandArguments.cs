namespace GitDupe.Commands.BlameCommandSet;

public class BlameCommandArguments : GitCommandArguments
{
    public string Filename { get; set; } = String.Empty;
    
    // Implement argument handling actions, ex: validation
}