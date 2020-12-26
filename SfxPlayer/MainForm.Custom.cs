using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SfxPlayer
{
    public partial class MainForm
    {
        private TreeNode[] CreateTreeNodes(IEnumerable<string> paths)
        {
            var values = new Dictionary<string, TreeNode>();
            var ret = new List<TreeNode>();
            foreach (var path in paths)
            {
                var node = new TreeNode(Path.GetFileName(path)) { Name = path };

                var dir = Path.GetDirectoryName(path);
                if (values.ContainsKey(dir))
                    values[dir].Nodes.Add(node);
                else
                    ret.Add(node);

                values.Add(path, node);
            }

            return ret.ToArray();
        }
    }
}
