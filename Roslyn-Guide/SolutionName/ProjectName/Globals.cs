/*
To test the installed Roslyn API we will go over a simple implementation where we will: 
Create a custom class that stores a string.
Attempt to evaluate a string as code (“var custom_class = new CustomClass(“data”)”) or (“10 * 20”), etc.
After evaluating, output to a console window the result
*/

namespace ProjectName
{
    public class Globals 
    {
        public class MyData 
        {
            public string Data { get; set; }

            public MyData(string data)
            {
                Data = data;
            }

            public override string ToString()
            {
                return Data;
            }
        }
    }
}
