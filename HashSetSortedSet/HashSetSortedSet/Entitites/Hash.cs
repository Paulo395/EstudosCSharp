using Service;

namespace Entitites
{
    internal class Hash
    {
        public void TestandoHash()
        {
            HashSet<String> set = new HashSet<String>();

            set.Add("a");
            set.Add("b");
            set.Add("c");
            set.Add("d");
            set.Add("d"); //Não Vai!

            RetornoService.RetornarValores(set);
        }
    }
}
