public class StateMachine<T> where T : class
{
    // StateMachine�� ������
    private T ownerEntity;
    // ���� State
    private State<T> currentState;
    // ���� State
    private State<T> previousState;

    // �ʱ� ����
    public void Setup(T owner, State<T> entryState)
    {
        ownerEntity = owner;
        currentState = null;
        previousState = null;

        ChangeState(entryState);
    }

    // ���� State Update
    public void Update()
    {
        if (currentState != null)
        {
            currentState.Update(ownerEntity);
        }
    }

    // State ����
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

    // ���� State���� ����
    public void RevertToPreviousState()
    {
        ChangeState(previousState);
    }

    // ���� State ��������
    public State<T> GetCurState()
    {
        return currentState;
    }
}