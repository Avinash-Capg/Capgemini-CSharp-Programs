using System;

namespace InterfaceDemoProj;

public class MathClass : IAll,IAddSub
{
    public int AddMe(int num1, int num2)
    {
        return num1 + num2;
    }

    public int SubMe(int num1, int num2)
    {
        return num1 - num2;
    }

    public int ProdMe(int num1, int num2)
    {
        return num1 * num2;
    }

    public float DivMe(int num1, int num2)
    {
        return (float)num1 / num2;
    }
}

