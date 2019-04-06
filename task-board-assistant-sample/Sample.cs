using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBoardAssistant;

namespace TaskBoardAssistantSample
{
    class Sample
    {
        static void Main(string[] args)
        {
            Assistant.ExecuteFromPath("../../trelloPolicy.json");
        }
    }
}
