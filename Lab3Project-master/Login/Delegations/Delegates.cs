using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabProject
{
    public delegate void Methods9Strings(string str1, string str2, string str3, string str4, string str5, string str6,
                                        string str7, string str8, string str9);
    public delegate void Methods5Strings(string str1, string str2, string str3, string str4, string str5);
    public delegate void MethodsNoParamaters();
    public delegate void Methods1String(string str);
    public delegate void Methods2Strings(string str1, string str2);

    public delegate void Methods2Points1String(Point p1, Point p2, string str);
    public delegate void Methods1Point(Point p);
    public delegate void Methods6Strings(string str1, string str2, string str3, string str4, string str5, string str6);
    public delegate void Methods1Bool(bool b);

    public delegate void Methods2Points(Point p1, Point p2);

    

}   
