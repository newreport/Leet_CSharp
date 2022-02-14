

using Leet;

Sort();

void Sort()
{

    Sort sort = new();
    List<int> ls = new List<int>();
    Random rd = new Random();
    for (int i = 0; i < 10; i++)
    {
        ls.Add(rd.Next(0, 9999));
    }
    //冒泡
    sort.Bubble(ls.ToArray());


}