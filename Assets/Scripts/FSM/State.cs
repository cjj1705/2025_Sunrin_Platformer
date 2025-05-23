public abstract class State<T> where T : class
{
    // 해당 상태를 시작할 때 호출
    public abstract void Enter(T entity);

    // 해당 상태를 업데이트할 때 매 프레임 호출
    public abstract void Update(T entity);

    // 해당 상태를 종료할 때 1회 호출
    public abstract void Exit(T entity);
}