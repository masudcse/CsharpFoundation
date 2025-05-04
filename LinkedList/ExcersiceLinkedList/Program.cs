using ExcersiceLinkedList;
class Program
{
    static void Main(string[] args)
    {
        SampleLinkedListGeneric<int> sampleLinkedList = new  SampleLinkedListGeneric<int>();
        sampleLinkedList.AddLast(1);
        sampleLinkedList.AddLast(2);
        sampleLinkedList.AddLast(3);
        sampleLinkedList.AddLast(4);
        sampleLinkedList.AddLast(5);
        //sampleLinkedList.AddFirst(0);
        //  sampleLinkedList.RemoveLast(4);
        sampleLinkedList.ReadAll();
        sampleLinkedList.ReverseReadAll();
    }
}
