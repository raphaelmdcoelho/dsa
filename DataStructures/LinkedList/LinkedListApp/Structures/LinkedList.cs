public class LinkedList<T>
{
    private Node head;

    private class Node
    {

        public T Value { get; set; }
        public Node Next { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null!;
        }
    }

    public void Add(T value)
    {
        Node newNode = new Node(value);

        if(head is null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while(current.Next != null)
            {
                current = current.Next;
            }

        }
    }
}