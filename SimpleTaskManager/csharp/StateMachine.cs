namespace TheStreets.Prototype;

public class StateMachine
{
    enum State
    {
        APP_START,
        APP_QUIT,
        VIEW_PRIMARY,
        VIEW_PROJECT_DETAILS,
        VIEW_TASK_DETAILS,
        VIEW_SETTINGS,
    }
    public enum UxAction
    {
        NEW_PROJECT, NEW_TASK,
        EDIT_PROJECT, EDIT_TASK,
        DELETE_PROJECT, DELETE_TASK,

        ARCHIVE_PROJECT, ARCHIVE_TASK,
    }
    public StateMachine()
    {
        State _state = State.APP_START;
    }
    public bool TryDoAction(string action)
    {
        // TODO: Implement
        return false;
    }
    private bool TryChangeState(State newState)
    {
        // TODO: Implement
        return false;
    }
}
