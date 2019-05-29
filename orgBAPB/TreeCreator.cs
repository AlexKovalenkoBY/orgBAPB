using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orgBAPB
{
    internal class TreeCreator
    {
        private Dictionary<string, IEnumerable<Podr>> _childPodrsByCodSp;
        /*определили словарь для дочерних СП*/
        internal TreeCreator()
        {
        }

        internal Podr CreateTree(List<Podr> podrs) //метод создания дерева
        {
            /* подразделения без уникальных номеров и правила их выделения*/
            var podrsWithNonUniqueCodeSp =
                podrs
                   .GroupBy(p => p.CodeSp)
                   .Where(g => g.Count() > 1)
                   .Select(g => g.First().CodeSp) 
                   .ToArray(); //записали в массив

            _childPodrsByCodSp =
                podrs
                    .ToDictionary(p => p.CodeSp, p => podrs.Where(p2 => p2.parentSP == p.CodeSp));
            /* в словарь записать те СП, у которых код родительского СП = коду текущего СП*/

            Podr root = podrs[0]; //выбрали начальное СП
            PopulateChilds(root);
            return root;
        }

        private void PopulateChilds(Podr podr) //метод построения дерева дочерних СП (структуры банка в цело мначиная от рута)
        {
            IEnumerable<Podr> childs; //список дочерних СП типа podr
            if (_childPodrsByCodSp.TryGetValue(podr.CodeSp, out childs))
            { //рекурсия
                podr.Childs = childs.ToList();
                foreach (Podr child in podr.Childs)   //для всех СП из  podr.Childs
                {
                    PopulateChilds(child);
                }
            }
        }
    }
}
