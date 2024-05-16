namespace Ex3
{
    public class Anata
    {
        public Anata() { }
    }
    public class NodeOfTree<T>
    {
        public T Value { get; }
        public List<NodeOfTree<T>> Childrens { get; }

        public NodeOfTree(T value)
        {
            Value = value;
            Childrens = new List<NodeOfTree<T>>();
        }
        public NodeOfTree(T value, List<NodeOfTree<T>> Childrens)
        {
            Value = value;
            this.Childrens = Childrens;
        }
        public void AddChild(NodeOfTree<T> node)
        {
            Childrens.Add(node);
        }
        public void PrintValues()
        {
            Console.WriteLine(Value);
            foreach (var node in Childrens)
            {
                node.PrintValues();
            }
    }
}
}
