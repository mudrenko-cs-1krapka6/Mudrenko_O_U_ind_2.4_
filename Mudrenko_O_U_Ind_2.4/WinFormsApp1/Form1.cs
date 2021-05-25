using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public double[] VectorRead;
        private Vector first;
        private Vector second;
        private static string separator = @"\,";
        private static string regExpTemplate = string.Format(@"^[+-]?\d*(?:[{0}]\d*)?(?:[E][+-]?\d*)?(\s[+-]?\d*(?:[{0}]\d*)?(?:[E][+-]?\d*)?)+$", separator);
        private Regex regExp = new Regex(regExpTemplate);
        class Vector
        {
            private double[] vector;
            private int numElements;
            public Vector(Vector vec)
            {
                vector = new double[0];
                numElements = 0;
            }
            public Vector(double[] vector)
            {
                this.vector = vector;
                this.numElements = vector.Length;
            }
            public double[] VectorValue()
            {
                return this.vector;
            }
            public double ElementsValue(int i)
            {
                return vector[i];
            }
            public int GetLength()
            {
                return numElements;
            }
            public static Vector Add(Vector f, Vector s)
            {
                double[] add = new double[f.GetLength()];
                if (f.GetLength() == s.GetLength())
                {
                    for (int i = 0; i < f.GetLength(); ++i)
                    {
                        add[i] = f.ElementsValue(i) + s.ElementsValue(i);
                    }
                    Vector result = new Vector(add);
                    return result;

                }
                else
                {
                    Vector r = new Vector(add);
                    return r;
                }
            }
            public static Vector Sub(Vector f, Vector s)
            {
                double[] sub = new double[f.GetLength()];
                if (f.GetLength() == s.GetLength())
                {
                    for (int i = 0; i < f.GetLength(); ++i)
                    {
                        sub[i] = f.ElementsValue(i) - s.ElementsValue(i);
                    }
                    Vector result = new Vector(sub);
                    return result;

                }
                else
                {
                    Vector r = new Vector(sub);
                    return r;
                }
            }

            public static double multi_on_const(Vector f, double c)
            {
                double multi = 0;
                for (int i = 0; i < f.GetLength(); ++i)
                {
                    multi += f.ElementsValue(i) * c;

                }
                return multi;
            }
            public static double Scalar(Vector f, Vector s)
            {
                double scal = 0;
                for (int i = 0; i < f.GetLength(); ++i)
                {
                    scal += f.ElementsValue(i) * s.ElementsValue(i);

                }
                return scal;
            }

        }
        public Form1()
        {
            InitializeComponent();
        }
		private bool UpdateData()
		{
			if (regExp.IsMatch(firstVector.Text))
			{
				VectorRead = Array.ConvertAll(firstVector.Text.Split(' '), double.Parse);
				this.first = new Vector(VectorRead);
			}
			else
			{
				this.PromptError();
				return false;
			}

			if (regExp.IsMatch(secondVector.Text))
			{
				VectorRead = Array.ConvertAll(secondVector.Text.Split(' '), double.Parse);
				this.second = new Vector(VectorRead);
			}
			else
			{
				this.PromptError();
				return false;
			}
			return true;
		}
        private void PromptError(string ErrPrompt = "Введені некоректі дані!!!")
        {
            result.Text = ErrPrompt;
        }
 
        private void add_Click_1(object sender, EventArgs e)
        {
            if (!UpdateData())
                return;
            Vector Res = Vector.Add(first, second);
            string r = "";
            foreach (double value in Res.VectorValue())
            {
                r += value.ToString() + " ";
            }
            result.Text = r;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (!UpdateData())
                return;
            Vector Res = Vector.Sub(first, second);
            string r = "";
            foreach (double value in Res.VectorValue())
            {
                r += value.ToString() + " ";
            }
            result.Text = r;
        }

        private void scals_Click(object sender, EventArgs e)
        {
            if (!UpdateData())
                return;
            double scal = Vector.Scalar(first, second);
            result.Text = scal.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // хз
        }
    }
}
