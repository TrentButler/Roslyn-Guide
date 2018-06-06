using System;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace ProjectName
{
    public class Class1
    {
        public Task Eval<T>(string source)
        {
            return CSharpScript.RunAsync<T>(source);
        }
    }
}