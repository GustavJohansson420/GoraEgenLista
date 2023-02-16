/*
MyList list = new MyList();
for (int i = 0; i < 11; i++)
{
    list.Add(i);
}

list.RemoveAt(3);

for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}
*/

MyLinkedList linkedList = new MyLinkedList();
linkedList.Add(1);
linkedList.Add(2);
linkedList.Add(3);
linkedList.Add(1);
linkedList.Add(5);
linkedList.Add(1223);
linkedList.Remove(1);

linkedList.Print();