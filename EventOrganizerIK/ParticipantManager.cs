using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizerV2
{
    internal class ParticipantManager
    {
        private List<Participant> participants = new List<Participant>();

        //constructor
        public ParticipantManager()
        { 
        }

        //Properties
        public int Count
        {
            get { return participants.Count; }
        }
        
        //Methods
        public bool AddParticipant(Participant participantIn)
        {
            if (participantIn == null)
                return false;

            participants.Add(participantIn);
            return true;
        }

        public bool CheckIndex(int index)
        {
            return index >= 0 && index < participants.Count;
        }


        public Participant GetParticipantAt(int index)
        {
            if (!CheckIndex(index))
                return null;

            return participants[index];
        }

        public string[] GetParticipantInfo()
        {
            string[] info = new string[participants.Count];

            for (int i = 0; i < participants.Count; i++)
                info[i] = participants[i].ToString();

            return info;
        }

        public bool DeleteParticipantAt(int index)
        {
            if (!CheckIndex(index))
                return false;

            participants.RemoveAt(index);
            return true;
        }
        
        public bool ChangeParticipantAt(Participant participantIn, int index)
        {
            if (participantIn == null)
                return false;

            if (!CheckIndex(index))
                return false;

            participants[index] = participantIn;
            return true;
        }
    }
}
