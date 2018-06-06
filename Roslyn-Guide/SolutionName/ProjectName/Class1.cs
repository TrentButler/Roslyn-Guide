using System;
using Microsoft.CodeAnalysis.CSharp.Scripting;

/*
To test the installed Roslyn API we will go over a simple implementation where we will: 
Create a custom class that stores a string.
Attempt to evaluate a string as code (“var custom_class = new CustomClass(“data”)”) or (“10 * 20”), etc.
After evaluating, output to a console window the result
*/

namespace ProjectName
{
    class Class1
    {
        public string Data { get; set; } //STRING AUTO PROPTERY

        public Class1(string data) //CLASS INITIALIZER
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data;
        }
    }
}
