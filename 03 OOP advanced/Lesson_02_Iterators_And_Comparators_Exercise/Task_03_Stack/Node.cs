public class Node<T>
{
    public Node(T element, Node<T> previous = null)
    {
        this.Element = element;
        this.Previous = previous;
    }

    public T Element;
    public Node<T> Previous;
}
