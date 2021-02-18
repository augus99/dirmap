using System.IO;

namespace Dirmap {
    public static class Dirtree {
        public static Treenode<string> From(string directory, int depth = int.MaxValue) {
            if(!Directory.Exists(directory)) return null;
            var realName = Path.GetDirectoryName(directory);
            var root = new Treenode<string>(realName);
            RecursiveDirMatcher(directory, root, depth);
            return root;
        }

        private static void RecursiveDirMatcher(string currentdir, Treenode<string> parent, int depth) {
            if(depth > 0) {
                string[] dirs = Directory.GetDirectories(currentdir);
                string[] files = Directory.GetFiles(currentdir);

                foreach(var dir in dirs) {
                    parent.AddChild(Path.GetFileName(dir));
                    RecursiveDirMatcher(dir, parent.Last, depth - 1);
                }
                
                foreach(var file in files)
                    parent.AddChild(Path.GetFileName(file));
            }
        }
    }
}