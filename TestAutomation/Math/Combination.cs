using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    public class Combination<T>
    {
        private long subsetCount = 0;
        private long totalCount = 0;
        private long[] indexes = null;
        private T[] items;

        /// <summary> A combination n of the items </summary>
        public Combination(long totalCount, long subsetCount = -1)
        {
            this.totalCount = totalCount;
            Init(subsetCount);
        }

        /// <summary> A combination n of the items </summary>
        public Combination(List<T> items, long subsetCount = -1)
        {
            items.CopyTo(this.items);
            this.totalCount = items.Count;
            Init(subsetCount);
        }

        /// <summary> A combination n of the items </summary>
        public Combination(T[] items, long subsetCount = -1)
        {
            items.CopyTo(this.items, 0);
            this.totalCount = items.Length;
            Init(subsetCount);
        }

        /// <summary> A combination n of the items </summary>
        public Combination(long subsetCount, params T[] items)
        {
            items.CopyTo(this.items, 0);
            this.totalCount = items.Length;
            Init(subsetCount);
        }

        private void Init(long n)
        {
            this.subsetCount = n;

            if (n < 0 || totalCount < 0)
                throw new Exception("Negative argument in constructor");
            this.indexes = new long[totalCount];
            for (long i = 0; i < totalCount; ++i) this.indexes[i] = i;
        }

        public string IToString()
        {
            string s = "{ ";
            for (long i = 0; i < this.totalCount; ++i)
                s += this.indexes[i] + " ";
            s += "}";
            return s;
        }

        public override string ToString()
        {
            string s = "{ ";
            for (long i = 0; i < this.totalCount; ++i)
                s += this.items[this.indexes[i]] + " ";
            s += "}";
            return s;
        }

        public T this[int index]
        {
            get
            {
                return this.items[index];
            }
        }

        public long NumberOfAllPossible()
        {
            return NumberOfAllPossible(this.totalCount, this.subsetCount);
        }

        public static long NumberOfAllPossible(long totalCount, long subsetCount)
        {
            if (totalCount < 0 || subsetCount < 0)
                throw new Exception("Negative argument in Choose");
            if (totalCount < subsetCount)
                return 0;
            if (totalCount == subsetCount)
                return 1;
            long delta, iMax;
            if (subsetCount < totalCount - subsetCount)
            {
                delta = totalCount - subsetCount;
                iMax = subsetCount;
            }
            else
            {
                delta = subsetCount;
                iMax = totalCount - subsetCount;
            }

            long ret = delta + 1;
            for (long i = 2; i <= iMax; ++i)
            {
                checked { ret = (ret * (delta + i)) / i; }
            }
            return ret;
        }

        public Combination<T> Successor()
        {
            if (this.indexes[0] == this.totalCount - this.subsetCount) return null;

            Combination<T> ret = new Combination<T>(this.totalCount, this.subsetCount);

            for (long i = 0; i < this.subsetCount; ++i) ret.indexes[i] = this.indexes[i];

            long x = 0;
            for (x = this.subsetCount - 1; x > 0 && ret.indexes[x] == this.totalCount - this.subsetCount + x; --x) ;

            ++ret.indexes[x];

            for (long j = x; j < this.subsetCount - 1; ++j) ret.indexes[j + 1] = ret.indexes[j] + 1;

            return ret;
        }

        public Combination<T> Predecessor()
        {
            if (this.indexes[this.subsetCount - 1] == this.subsetCount - 1)
                return null;
            Combination<T> ret = new Combination<T>(this.totalCount, this.subsetCount);

            for (long i = 0; i < this.subsetCount; ++i) ret.indexes[i] = this.indexes[i];
            
            long x;
            for (x = this.subsetCount - 1; x > 0 && ret.indexes[x] == ret.indexes[x - 1] + 1; --x) ;

            --ret.indexes[x];

            for (long j = x + 1; j < this.subsetCount; ++j) ret.indexes[j] = this.totalCount - this.subsetCount + j;
            return ret;
        }
    }
}