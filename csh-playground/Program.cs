using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csh_playground;

namespace csh_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Input> inputs = new List<Input>();
            inputs.Add(new Input(1, 2, -3));
            inputs.Add(new Input(1, 2, -1));
            
            QuadraticEquasion eq = new QuadraticEquasion();

            foreach (Input input in inputs)
            {
                eq.A = input.m_a;
                eq.B = input.m_b;
                eq.C = input.m_c;

                // ... toodo
            }
        }
    }
}