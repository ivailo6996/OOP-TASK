using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASK
{
    public class Referee:Person
    {
        private const int MaxAssistantReferees = 2;
        private int assistantRefereeCount;

        public int AssistantRefereeCount
        {

            get { return assistantRefereeCount; }
        }


    }
}
