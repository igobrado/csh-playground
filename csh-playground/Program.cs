using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshPlayground
{
    public class NotRealRootsException : ArithmeticException
    {
        public NotRealRootsException()
        {
        }

        public NotRealRootsException(string message) : base(message)
        {
        }
    }
    public class QuadraticEquasion
    {
        private double m_a;
        private double m_b;
        private double m_c;

        public double A
        {
            get { return m_a; }
            set { m_a = value; }
        }

        public double B
        {
            get { return m_b; }
            set { m_b = value; }
        }

        public double C
        {
            get { return m_c; }
            set { m_c = value;  }
        }

        public QuadraticEquasion() { }
        public QuadraticEquasion(double a, double b, double c) 
        {
            m_a = a; 
            m_b = b; 
            m_c = c;
        }

        public double Y(double x)
        {
            return m_a * Math.Pow(x, 2) + m_b * x + m_c;
        }

        public double Discriminant 
        { 
            get { return Math.Pow(m_a, 2) - 4 * m_a * m_c; }
        }

        public double[] Roots
        {
            get
            {
                double discriminant = Discriminant;
                if (discriminant <= 0)
                {
                    throw new NotRealRootsException();
                }

                double x, y;
                x = (-m_b + Math.Sqrt(Discriminant)) / 2 * m_a;
                y = (-m_b - Math.Sqrt(Discriminant)) / 2 * m_a;
                return new double[2] {x,y};
            }
        }
    }

    class Program
    {
        struct Input
        {
            public double m_a, m_b, m_c;
            public Input (double a, double b, double c)
            {
                m_a = a;
                m_b = b;
                m_c = c;
            }
            
        }

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