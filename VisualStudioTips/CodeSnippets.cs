
using System;
using System.CodeDom;

namespace VisualStudioTips
{

    public class CodeInspector
    {

    }
    public class CodeSnippets
    {

        private readonly CodeInspector _code;
        public CodeSnippets(CodeInspector code)
        {
            _code = code;
        }
        
        // Put the cursor here and type "ctor" and then press the Tab. This will create a constructor for this class.

        public string FirstName { get; set; }

        // Now put the cursor here and type "prop" and then press the Tab. This will create an auto-implemented property.
        // Note that the "type" is highlighted. Type in "string" and press the Tab. Now you can type a name for this property.
        // Then press the Tab or Enter to finish editing. 
        private int _value;
        public int MyProperty
        {
            get { return _value; }
            set { _value = value; }
        }

        // Now type "propfull" to create a property with a private field. Press the tab and specify the values accordingly.

        public void Start()
        {
            // Put the cursor here and type "for" and press the Tab. 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            // Do the same with "foreach".


            // Now type "try" to create a try/catch block.



            // Repeat with "tryf" to create a try/finally block.


            // Now create a for loop with "for".


            // Or a for loop that decrements the loop variable using "forr".

            
        }
        
    }
}
