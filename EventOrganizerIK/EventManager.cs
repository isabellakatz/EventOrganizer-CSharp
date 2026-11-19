using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizerV2
{
    internal class EventManager
    {
        private double costPerPerson;
        private double feePerPerson;
        private ParticipantManager participantManager = new ParticipantManager();
        private string title;

        public EventManager()
        { }


        //Properties
        public double CostPerPerson
        {
            get { return costPerPerson; }
            set 
            {
                if (value >= 0.0)
                    costPerPerson = value;
            }
        }

        public double FeePerPerson
        {
            get { return feePerPerson; }
            set 
            {
                if (value >= 0.0)
                    feePerPerson = value;
            }
        }

        public ParticipantManager Participants
        {
            get { return participantManager; }

        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }


       //Methods
       public double CalcTotalCost()
        {
            return participantManager.Count * costPerPerson;
        }

       public double CalcTotalFees()
       {
            return participantManager.Count * feePerPerson;
       }

        public double CalcSurplusOrDeficit()
        {
            return CalcTotalFees() - CalcTotalCost();
        }

        public int NumberOfParticipants
        {
            get { return participantManager.Count; }
        }
    }
}
