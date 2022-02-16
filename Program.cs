using Leet;

Console.WriteLine(F(6)); 

//Sort();

int F(int x)
{
    if (x == 1)
        return 1;
    if (x == 2)
        return 2;
    return F(x-1)+F(x-2);
}

void Sort()
{

    Sort sort = new();
    List<int> ls = new List<int>();
    Random rd = new Random();
    for (int i = 0; i < 100; i++)
    {
        ls.Add(rd.Next(0, 9999));
    }
    //冒泡
    sort.Bubble(ls.ToArray());
    //选择
    sort.Selection(ls.ToArray());

}