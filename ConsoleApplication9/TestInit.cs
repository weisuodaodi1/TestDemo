using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using ConsoleApplication9;

[assembly: PreApplicationStartMethod(typeof(TestInit), "")]
namespace ConsoleApplication9
{
    public class TestInit
    {
    }
}
