using System.Collections.Generic;

namespace Dirmap {
    public class Treenode<T> {
        public T Value { get; set; }
        public IList<Treenode<T>> Children { get; set; }
        public Treenode<T> Parent { get; set; }
        public Treenode<T> Last { get; set; }

        public Treenode(T value, Treenode<T> parent = null) {
            this.Value = value;
            this.Parent = parent;
            this.Children = new List<Treenode<T>>();
        }

        public void AddChild(T value) {
            this.Children.Add(Last = new Treenode<T>(value, this));
        }

        public void Traverse(TreenodeVisitor<T> visitor) {
            visitor?.Invoke(this);
            foreach(var child in Children)
                child.Traverse(visitor);
        }

        public override string ToString() {
            var tree = "";
            this.Traverse((node) => {
                var parent = node;
                var result = node.Value.ToString();
                var currentLevel = 0;

                while(parent.Parent != null) {
                    if(parent.Parent.Last == parent) {
                        if(currentLevel == 0) result = "   └─" + result;
                        else result = "    " + result;
                    } 
                    else {
                        if(currentLevel == 0) result = "   ├─" + result;
                        else result = "   │" + result;
                    }

                    parent = parent.Parent;
                    ++currentLevel;
                }
                tree += result + "\n";
            });
            return tree;
        }

    }
}