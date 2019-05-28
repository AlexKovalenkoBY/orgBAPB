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

        internal TreeCreator()
        {
        }

        internal Podr CreateTree(List<Podr> podrs)
        {
            var podrsWithNonUniqueCodeSp =
                podrs
                   .GroupBy(p => p.CodeSp)
                   .Where(g => g.Count() > 1)
                   .Select(g => g.First().CodeSp)
                   .ToArray();

            _childPodrsByCodSp =
                podrs
                    .ToDictionary(p => p.CodeSp, p => podrs.Where(p2 => p2.parentSP == p.CodeSp));

            Podr root = podrs[0];
            PopulateChilds(root);
            return root;
        }

        private void PopulateChilds(Podr podr)
        {
            IEnumerable<Podr> childs;
            if (_childPodrsByCodSp.TryGetValue(podr.CodeSp, out childs))
            {
                podr.Childs = childs.ToList();
                foreach (Podr child in podr.Childs)
                {
                    PopulateChilds(child);
                }
            }
        }
    }
}
