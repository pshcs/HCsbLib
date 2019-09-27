﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Collections;

namespace HTLib2
{
    public class HLargeList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection
        where T : IEquatable<T>
    {
        List<List<T>> list;
        int listi_maxcapacity = int.MaxValue;

        public HLargeList()
        {
            list = new List<List<T>>();
            list.Add(new List<T>());
        }
        public HLargeList(int capacity)
        {
            list = new List<List<T>>();
            list.Add(new List<T>(capacity));
        }
        public HLargeList(IEnumerable<T> collection)
        {
            list = new List<List<T>>();

            List<T> listi = new List<T>();
            foreach(var item in collection)
            {
                if(listi.Count == listi_maxcapacity)
                {
                    list.Add(listi);
                    listi = new List<T>();
                }
            }

            list.Add(listi);
        }

        T this[long index]
        {
            get
            {
                long idx0 = index / listi_maxcapacity; HDebug.Assert(idx0 <= int.MaxValue);
                long idx1 = index % listi_maxcapacity; HDebug.Assert(idx1 <= int.MaxValue);
                return list[(int)idx0][(int)idx1];
            }
            set
            {
                long idx0 = index / listi_maxcapacity; HDebug.Assert(idx0 <= int.MaxValue);
                long idx1 = index % listi_maxcapacity; HDebug.Assert(idx1 <= int.MaxValue);
                list[(int)idx0][(int)idx1] = value;
            }
        }
        T IList<T>.this[int index]
        {
            get { return this[index]; }
            set {        this[index] = value; }
        }

        //
        // Summary:
        //     Determines the index of a specific item in the System.Collections.Generic.IList`1.
        //
        // Parameters:
        //   item:
        //     The object to locate in the System.Collections.Generic.IList`1.
        //
        // Returns:
        //     The index of item if found in the list; otherwise, -1.
        long IndexOf(T item)
        {
            foreach(var listi in list)
            {
                long indexof = listi.IndexOf(item);
                if(indexof != -1)
                    return indexof;
            }
            return -1;
        }
        int IList<T>.IndexOf(T item)
        {
            long indexof = IndexOf(item);
            HDebug.Assert(indexof <= int.MaxValue);
            return (int)indexof;
        }
        void IList<T>.Insert(int index, T item) { throw new NotImplementedException(); }
        void IList<T>.RemoveAt(int index)       { throw new NotImplementedException(); }

        long Count
        {
            get
            {
                long count = 0;
                foreach(var listi in list)
                    count += listi.Count;
                return count;
            }
        }
        
        int ICollection<T>.Count
        {
            get
            {
                long count = Count;
                HDebug.Assert(count <= int.MaxValue);
                return (int)count;
            }
        }
        bool ICollection<T>.IsReadOnly { get { return false; } }
        void ICollection<T>.Add(T item)
        {
            List<T> listi = list.Last();
            if(listi.Count == listi_maxcapacity)
            {
                listi = new List<T>();
                list.Add(listi);
            }

            listi.Add(item);
        }
        void ICollection<T>.Clear()
        {
            list.Clear();
        }
        bool ICollection<T>.Contains(T item)
        {
            bool   contains = ((this as IList<T>).IndexOf(item) != -1);
            return contains;
        }
        void ICollection<T>.CopyTo(T[] array, int arrayIndex) { throw new NotImplementedException(); }
        bool ICollection<T>.Remove(T item)                    { throw new NotImplementedException(); }
        
        IEnumerable<T> Enum()
        {
            foreach(var listi in list)
                foreach(var item in listi)
                    yield return item;
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return Enum().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Enum().GetEnumerator();
        }

        object IList.this[int index]                        { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        bool   IList.IsReadOnly                             { get { throw new NotImplementedException(); } }
        bool   IList.IsFixedSize                            { get { throw new NotImplementedException(); } }
        int    IList.Add(object value)                      { throw new NotImplementedException(); }
        void   IList.Clear()                                { throw new NotImplementedException(); }
        bool   IList.Contains(object value)                 { throw new NotImplementedException(); }
        int    IList.IndexOf(object value)                  { throw new NotImplementedException(); }
        void   IList.Insert(int index, object value)        { throw new NotImplementedException(); }
        void   IList.Remove(object value)                   { throw new NotImplementedException(); }
        void   IList.RemoveAt(int index)                    { throw new NotImplementedException(); }

        int    ICollection.Count                            { get { throw new NotImplementedException(); } }
        object ICollection.SyncRoot                         { get { throw new NotImplementedException(); } }
        bool   ICollection.IsSynchronized                   { get { throw new NotImplementedException(); } }
        void   ICollection.CopyTo(Array array, int index)   { throw new NotImplementedException(); }
    }
}
