using Service;

namespace Entitites
{
    internal class Lista
    {
        public void TestandoList()
        {
            List<int> listInt = new List<int>();

            listInt.Add(1);
            listInt.Add(2);
            listInt.Add(3);
            listInt.Add(3); //Vai

            RetornoService.RetornarValores(listInt);
        }
    }
}
