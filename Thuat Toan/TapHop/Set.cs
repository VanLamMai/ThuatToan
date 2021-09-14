using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapHop
{
    public class Set
    {
        public ToanCuc tc;
        public int[] A;
        public int[] B;

        public int len = 0;

        public List<int> o;
        public List<char> o_char;

        public Set()
        {
            this.len = 0;
            this.o = new List<int>();
            this.o_char = new List<char>();
        }

        public Set(int n)
        {
            this.len = n;
            this.o = new List<int>(this.len);
            this.o_char = new List<char>(this.len);
        }

        public Set(int n, List<int> a)
        {
            this.len = n;
            this.o = new List<int>(this.len);
            for (int i = 0; i < a.Count; i++)
                this.o.Add(a[i]);
        }

        public Set(int n, List<char> a)
        {
            this.o_char = new List<char>();
            int nobjs_char = ToanCuc.obj_char;
            int[] A1 = new int[nobjs_char];
            int i;
            for (i = 0; i < nobjs_char; i++)
            {
                A1[i] = 0;
            }
            int kq = -1;
            for (i = 0; i < a.Count; i++)
            {
                kq = FindValue(ToanCuc.mangchar, a[i]);
                if (kq != -1)
                    A1[kq] = 1;
            }
            for (i = 0; i < nobjs_char; i++)
                if (A1[i] != 0) this.o_char.Add(ToanCuc.mangchar[i]);
            this.len = this.o_char.Count;
        }

        public int FindValue(char[] MangChar, char a)
        {
            for (int i = 0; i < MangChar.Length; i++)
                if (MangChar[i] == a) return i;
            return -1;
        }

        public void Sort()
        {
            if (this.o != null)
                this.o.Sort();
            else
                this.o_char.Sort();

        }

        ~Set()
        {
            this.len = 0;
            this.o = null;
            this.o_char = null;
        }

        public Set(Set s)
        {

            this.len = s.len;
            this.o = new List<int>(this.len);
            for (int i = 0; i < s.len; i++)
                o.Add(s.o[i]);
        }

        public void Display()
        {
            if (len > 0)
            {
                Console.Write("{");
                for (int i = 0; i < len - 1; i++)
                    Console.Write("{0},", o[i]);
                Console.Write("{0}", o[len - 1]);
                Console.Write("}");
            }
            else
                Console.Write("{}");
        }

        public string ConvertSetToString()
        {
            string tam = "";
            if (this.len > 0)
            {
                if (this.o != null)
                {
                    tam = tam + "{";
                    for (int i = 0; i < this.len - 1; i++)
                        tam = tam + o[i].ToString() + ",";
                    tam = tam + o[this.len - 1].ToString() + "}";
                    return tam;
                }
                else
                {
                    tam = tam + "{";
                    for (int i = 0; i < this.len - 1; i++)
                        tam = tam + o_char[i].ToString() + ",";
                    tam = tam + o_char[this.len - 1].ToString() + "}";
                    return tam;
                }
            }
            else return "{}";
        }

        public void Hop(Set a, Set b, ref Set c)
        {
            int nobjs = ToanCuc.objs;
            int nobjs_char = ToanCuc.obj_char;
            int[] A1 = new int[nobjs];
            int[] B1 = new int[nobjs];
            int[] C1 = new int[nobjs];
            c = new Set(); ;
            int i;
            if (a.o != null && b.o != null)
            {
                for (i = 0; i < nobjs; i++)
                {
                    A1[i] = 0;
                    B1[i] = 0;
                    C1[i] = 0;
                }
                for (i = 0; i < a.len; i++)
                    A1[a.o[i]] = 1;
                for (i = 0; i < b.len; i++)
                    B1[b.o[i]] = 1;
                for (i = 0; i < nobjs; i++)
                    if (A1[i] == 1 || B1[i] == 1) C1[i] = 1;
                for (i = 0; i < nobjs; i++)
                    if (C1[i] != 0) c.o.Add(i);
                c.len = c.o.Count;
                c.o_char = null;
            }
            else
            {
                for (i = 0; i < nobjs_char; i++)
{
                    A1[i] = 0;
                    B1[i] = 0;
                    C1[i] = 0;
                }
                a.Sort();
                int kq = -1;
                for (i = 0; i < a.len; i++)
                {
                    kq = FindValue(ToanCuc.mangchar, a.o_char[i]);
                    if (kq != -1) A1[kq] = 1;
                }
                kq = -1;
                b.Sort();
                for (i = 0; i < b.len; i++)

                {
                    kq = FindValue(ToanCuc.mangchar, b.o_char[i]);
                    if (kq != 0) B1[kq] = 1;
                }
                for (i = 0; i < nobjs_char; i++)
                    if (A1[i] == 1 || B1[i] == 1) C1[i] = 1;
                for (i = 0; i < nobjs_char; i++)
                    if (C1[i] != 0) c.o_char.Add(ToanCuc.mangchar[i]);
                c.len = c.o_char.Count;
                c.o = null;
            }
        }

        public void Giao(Set a, Set b, ref Set c)
        {
            int nobjs = ToanCuc.objs;
            int nobjs_char = ToanCuc.obj_char;
            int[] A1 = new int[nobjs];
            int[] B1 = new int[nobjs];
            int[] C1 = new int[nobjs];
            c = new Set();
            int i;
            if (a.o != null && b.o != null)
            {
                for (i = 0; i < nobjs; i++)
                {
                    A1[i] = 0;
                    B1[i] = 0;
                    C1[i] = 0;
                }
                for (i = 0; i < a.len; i++)
                    A1[a.o[i]] = 1;
                for (i = 0; i < b.len; i++)
                    B1[b.o[i]] = 1;
                for (i = 0; i < nobjs; i++)
                    if (A1[i] == 1 && B1[i] == 1) C1[i] = 1;
                for (i = 0; i < nobjs; i++)
                    if (C1[i] != 0) c.o.Add(i);
                c.len = c.o.Count;
                c.o_char = null;
            }
            else
            {
                for (i = 0; i < nobjs_char; i++)
                {
                    A1[i] = 0;
                    B1[i] = 0;
                    C1[i] = 0;
                }
                a.Sort();
                int kq = 0;
                for (i = 0; i < a.len; i++)
                {

                    kq = FindValue(ToanCuc.mangchar, a.o_char[i]);
                    if (kq != 0) A1[kq] = 1;
                }
                kq = 0;
                b.Sort();
                for (i = 0; i < b.len; i++)
                {
                    kq = FindValue(ToanCuc.mangchar, b.o_char[i]);
                    if (kq != 0) B1[kq] = 1;
                }
                for (i = 0; i < nobjs_char; i++)
                    if (A1[i] == 1 && B1[i] == 1) C1[i] = 1;
                for (i = 0; i < nobjs_char; i++)
                    if (C1[i] != 0) c.o_char.Add(ToanCuc.mangchar[i]);
                c.len = c.o_char.Count;
                c.o = null;
            }
        }

        public void TapBu(Set a, ref Set c)
        {
            int nobjs = ToanCuc.objs;
            int nobjs_char = ToanCuc.obj_char;
            int[] A1 = new int[nobjs];
            int[] C1 = new int[nobjs];
            c = new Set();
            int i;
            if (a.o != null)
            {
                for (i = 0; i < nobjs; i++)
                {
                    A1[i] = 0;
                    C1[i] = 1;
                }
                for (i = 0; i < a.len; i++)
                    A1[a.o[i]] = 1;
                for (i = 0; i < nobjs; i++)
                    if (A1[i] == 1) C1[i] = 0;
                for (i = 0; i < nobjs; i++)
                    if (C1[i] != 0) c.o.Add(i);
                c.len = c.o.Count;
                c.o_char = null;
            }
            else
            {
                for (i = 0; i < nobjs_char; i++)
                {
                    A1[i] = 0;
                    C1[i] = 1;
                }
                a.Sort();
                int kq = -1;
                for (i = 0; i < a.len; i++)
                {
                    kq = FindValue(ToanCuc.mangchar, a.o_char[i]);
                    if (kq != -1) A1[kq] = 1;
                }
                for (i = 0; i < nobjs_char; i++)
                    if (A1[i] == 1) C1[i] = 0;
                for (i = 0; i < nobjs_char; i++)
                    if (C1[i] != 0) c.o_char.Add(ToanCuc.mangchar[i]);
                c.len = c.o_char.Count;
                c.o = null;
            }
        }

        public void Hieu(Set a, Set b, ref Set c)
        {
            int nobjs = ToanCuc.objs;
            int nobjs_char = ToanCuc.obj_char;
            int[] A1 = new int[nobjs];
            int[] B1 = new int[nobjs];
            int[] C1 = new int[nobjs];
            c = new Set();
            int i;
            if (a.o != null && b.o != null)
            {
                for (i = 0; i < nobjs; i++)
                {
                    A1[i] = 0;
                    B1[i] = 0;
                    C1[i] = 0;
                }
                for (i = 0; i < a.len; i++)
                    A1[a.o[i]] = 1;
                for (i = 0; i < b.len; i++)
                    B1[b.o[i]] = 1;
                for (i = 0; i < nobjs; i++)
                    if (A1[i] == 1 && B1[i] == 0) C1[i] = 1;
                for (i = 0; i < nobjs; i++)
                    if (C1[i] != 0) c.o.Add(i);
                c.len = c.o.Count;
                c.o_char = null;
            }
            else
            {
                for (i = 0; i < nobjs_char; i++)
{
                    A1[i] = 0;
                    B1[i] = 0;
                    C1[i] = 0;
                }
                a.Sort();
                int kq = -1;
                for (i = 0; i < a.len; i++)
{
                    kq = FindValue(ToanCuc.mangchar, a.o_char[i]);
                    if (kq != -1) A1[kq] = 1;
                }
                kq = -1;
                b.Sort();
                for (i = 0; i < b.len; i++)
{
                    kq = FindValue(ToanCuc.mangchar, b.o_char[i]);
                    if (kq != -1) B1[kq] = 1;
                }

                for (i = 0; i < nobjs_char; i++)
                    if (A1[i] == 1 && B1[i] == 0) C1[i] = 1;
                for (i = 0; i < nobjs_char; i++)
                    if (C1[i] != 0) c.o_char.Add(ToanCuc.mangchar[i]);
                c.len = c.o_char.Count;
                c.o = null;
            }
        }
    }
}
