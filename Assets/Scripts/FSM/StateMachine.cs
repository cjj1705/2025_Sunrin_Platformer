public class StateMachine<T> where T : class
{
    // StateMachine의 소유자
    private T ownerEntity;
    // 현재 State
    private State<T> currentState;
    // 이전 State
    private State<T> previousState;

    // 초기 세팅
    public void Setup(T owner, State<T> entryState)
    {
        ownerEntity = owner;
        currentState = null;
        previousState = null;

        ChangeState(entryState);
    }

    // 현재 State Update
    public void Update()
    {
        if (currentState != null)
        {
            currentState.Update(ownerEntity);
        }
    }

    // State 변경
    public void ChangeState(State<T> newState)
    {
        if (newState == null) return;

        if (currentState != null)
        {
            previousState = currentState;
            currentState.Exit(ownerEntity);
        }

        currentState = newState;
        currentState.Enter(ownerEntity);
    }

    // 이전 State으로 변경
    public void RevertToPreviousState()
    {
        ChangeState(previousState);
    }

    // 현재 State 가져오기
    public State<T> GetCurState()
    {
        return currentState;
    }
}