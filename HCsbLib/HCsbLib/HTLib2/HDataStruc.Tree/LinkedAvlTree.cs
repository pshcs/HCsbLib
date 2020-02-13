﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTLib2
{
    /// <summary>
    /// AVL tree whose nodes are linked as a linked-list in increasing order
    /// </summary>
    public partial class LinkedAvlTree<T>
    {
        public class Node
        {
            public T    value;
            public Node prev { get { return _prev; } }
            public Node next { get { return _next; } }

            internal Node _prev;
            internal Node _next;
            internal Node(T value, Node prev, Node next)
            {
                this.value = value;
                this._prev = prev ;
                this._next = next ;
            }

            public override string ToString()
            {
                return value.ToString();
            }
        }

        Node head;
        Node tail;
        BTree.AvlTree<Node> avl;
        Comparison<T> comp;
        int nodecomp(Node x, Node y) { return comp(x.value, y.value); }

        public LinkedAvlTree(Comparison<T> comp)
        {
            this.head = null;
            this.tail = null;
            this.comp = comp;
            this.avl  = BTree.AvlTree<Node>.NewAvlTree(nodecomp);
        }
        public static LinkedAvlTree<T> New(Comparison<T> comp)
        {
            return new LinkedAvlTree<T>(comp);
        }
        public Node GetHead()
        {
            return head;
        }
        public Node GetTail()
        {
            return tail;
        }
        public bool IsEmpty()
        {
            if(avl.IsEmpty() == true)
            {
                HDebug.Assert(head == null);
                HDebug.Assert(tail == null);
                return true;
            }
            else
            {
                HDebug.Assert(head != null);
                HDebug.Assert(tail != null);
                return false;
            }
        }
        public bool Contains(T query)
        {
            return (Search(query) != null);
        }
        public Node Search(T query)
        {
            var nodequery = new Node(query, null, null);;

            var value = avl.Search(nodequery);

            if(value == null)
                return null;
            return value.Value.value;
        }
        public (Node value, Node parent_value) SearchWithParent(T query)
        {
            var nodequery = new Node(query, null, null);;

            var (val, parent_val) = avl.SearchWithParent(nodequery);

            Node value        = null; if(val        != null) value        = val       .Value.value;
            Node parent_value = null; if(parent_val != null) parent_value = parent_val.Value.value;

            return (value, parent_value);
        }
        public (Node value, (Node left_value, Node right_value)) SearchRange(T query)
        {
            var nodequery = new Node(query, null, null); ;

            var (val, parent_val) = avl.SearchWithParent(nodequery);

            if(val == null)
            {
                HDebug.Assert(parent_val != null);
                Node parent_value = parent_val.Value.value;
                int cmp = comp(query, parent_value.value);
                HDebug.Assert(cmp != 0);
                if(cmp < 0)
                {
                    HDebug.Assert(false);
                    //  parent->prev < query:null < parent)
                    return (null, (parent_value.prev, parent_value));
                }
                else
                {
                    HDebug.Assert(false);
                    //  parent < query:null < parent->next
                    return (null, (parent_value, parent_value.next));
                }
            }
            else
            {
                HDebug.Assert(parent_val != null);
                Node value        = val       .Value.value;
                Node parent_value = parent_val.Value.value;
                int cmp = comp(value.value, parent_value.value);
                HDebug.Assert(cmp != 0);
                if (cmp < 0)
                {
                    HDebug.Assert(false);
                    //  value->prev < value < parent)
                    return (value, (value.prev, parent_value));
                }
                else
                {
                    HDebug.Assert(false);
                    //  parent < value < value->next
                    return (value, (parent_value, value.next));
                }
            }
        }
        public Node Insert(T value)
        {
            Node node = new Node(value, null, null);

            if(avl.IsEmpty() == true)
            {
                var avlnode = avl.AvlInsert(node);
                HDebug.Assert(avlnode.value.value == node);

                node._prev = null;
                node._next = null;
                head = tail = node;
            }
            else
            {
                var avlnode = avl.AvlInsert(node);
                HDebug.Assert(avlnode.value.value == node);

                var avlnode_successor = avlnode.Successor();
                if (avlnode_successor == null)
                {
                    // added to tail
                    HDebug.Assert(avl.AvlSearch(tail).Successor().value.value == node);
                    HDebug.Assert(nodecomp(tail, node) < 0);
                    tail._next = node;
                    node._prev = tail;
                    tail = node;
                }
                else if (avlnode_successor.value.value == head)
                {
                    // added to head
                    HDebug.Assert(nodecomp(node, head) < 0);
                    head._prev = node;
                    node._next = head;
                    head = node;
                }
                else
                {
                    Node node_next = avlnode_successor.value.value;
                    Node node_prev = node_next.prev;
                    HDebug.Assert(node_prev.next == node_next);
                    HDebug.Assert(node_next.prev == node_prev);
                    HDebug.Assert(nodecomp(node_prev, node_next) < 0);
                    HDebug.Assert(nodecomp(node_prev, node     ) < 0);
                    HDebug.Assert(nodecomp(node     , node_next) < 0);
                    node._next = node_next;
                    node._prev = node_prev;
                    node_prev._next = node;
                    node_next._prev = node;
                }
            }
            return node;
        }
        public List<Node> InsertRange(params T[] values)
        {
            return InsertRange(values as IEnumerable<T>);
        }
        public List<Node> InsertRange(IEnumerable<T> values)
        {
            List<Node> nodes = new List<Node>();
            foreach(var value in values)
            {
                Node node = Insert(value);
                nodes.Add(node);
            }
            return nodes;
        }
        public Node Delete(T query)
        {
            var nodequery = new Node(query, null, null);;

            var del = avl.Delete(nodequery);
            if(del == null)
                return null;

            Node node = del.Value.value;

            if(avl.IsEmpty())
            {
                HDebug.Assert(node == head);
                HDebug.Assert(node == tail);
                head = tail = null;
            }
            else if(node == head)
            {
                head = node.next;
                node._next = null;
            }
            else if(node == tail)
            {
                tail = node.prev;
                node._prev = null;
            }
            else
            {
                Node node_prev = node.prev;
                Node node_next = node.next;
                node_prev._next = node_next;
                node_next._prev = node_prev;
                node._next = null;
                node._prev = null;
            }

            HDebug.Assert(node.prev == null);
            HDebug.Assert(node.next == null);
            return node;
        }
        public bool Validate()
        {
            // check AVL validate
            if(avl.Validate() == false) return false;

            // check linked-list validate
            Node n = head;
            while(n != null)
            {
                Node n_next = n.next;
                if(n_next != null && (nodecomp(n, n_next) <= 0) == false)
                    return false;
                n = n_next;
            }

            return true;
        }
    }
}
