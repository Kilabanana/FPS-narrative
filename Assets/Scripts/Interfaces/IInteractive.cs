

/// <summary>
/// interface for elements player can interact with by pressing Interact button.
/// </summary>
public interface IInteractive 
{
    string DisplayText { get; }
    void InteractWith();
}
