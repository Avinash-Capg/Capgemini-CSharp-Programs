using System;

namespace InterfaceDemoProj;
interface IAdd
{
    int AddMe(int num1, int num2);
}

interface ISub
{
    int SubMe(int num1, int num2);
}

public interface IProd
{
    int ProdMe(int num1, int num2);
}

interface IDiv
{
    float DivMe(int num1, int num2);
}

 interface IAddSub : IAdd, ISub
{
}

interface IAddProdDiv : IAdd, IProd, IDiv
{
}

 interface IAll : IAddProdDiv, ISub
{
}

