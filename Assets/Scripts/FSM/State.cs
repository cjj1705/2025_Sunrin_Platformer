public abstract class State<T> where T : class
{
    // �ش� ���¸� ������ �� ȣ��
    public abstract void Enter(T entity);

    // �ش� ���¸� ������Ʈ�� �� �� ������ ȣ��
    public abstract void Update(T entity);

    // �ش� ���¸� ������ �� 1ȸ ȣ��
    public abstract void Exit(T entity);
}