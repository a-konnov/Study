using System;

namespace BinarySearchTree {
    internal class Program {
        public class BinaryTree<T> where T : IComparable<T> {
            private BinaryTree<T> parent;
            private BinaryTree<T> left;
            private BinaryTree<T> right;
            private T value;

            public BinaryTree(T val, BinaryTree<T> parent) {
                this.value = val;
                this.parent = parent;
            }

            public void Add(T val) {
                if (val.CompareTo(this.value) < 0) {
                    if (this.left == null) {
                        this.left = new BinaryTree<T>(val, this);
                    } 
                    else if (this.left != null) {
                        this.left.Add(val);
                    }
                }
                else if (val.CompareTo(this.value) > 0) {
                    if (this.right == null) {
                        this.right = new BinaryTree<T>(val, this);
                    } 
                    else if (this.right != null) {
                        this.right.Add(val);
                    }
                } else {
                    this.value = val;
                }
            }

            private BinaryTree<T> Search(BinaryTree<T> tree, T val) {
                if (tree == null) {
                    return null;
                }
                var compareResult = val.CompareTo(tree.value);
                if (compareResult > 0) {
                    return Search(tree.right, val);
                }
                else if (compareResult < 0) {
                    return Search(tree.left, val);
                } else {
                    return tree;
                }
            }

            public bool DeleteNode(T val) {
                BinaryTree<T> tree = Search(this, val);
                if(tree == null){
                    return false;
                }
            }
        }

        public static void Main(string[] args) {}
    }
}