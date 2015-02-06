using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;
using StringUtilities;

namespace MyFirstTDD
{
    [Subject(typeof(StringUtilties))]
    public class when_concatenating_two_strings
    {
        private static StringUtilties sut;
        private static string input1;
        private static string input2;
        private static string actualvalue;

        Establish context = () =>
        {
            sut = new StringUtilties();
            input1 = "Hello";
            input2 = "Worldddd";
        };
        private Because of = () =>
        {
            actualvalue = sut.Concatenate(input1, input2);
        };
        private It should_concatenate_both_input_strings = () =>
        {
            actualvalue.ShouldEqual("HelloWorld"); 
        };
        
    }
    

    
}
