using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz10
{
    internal class Event
    {
        public int Date { get; set; }
        public int ParticipantsPerGroup { get; set; }
        public int NumberOfGroups { get; set; }
        public List<string> SelectedParticipants { get; set; }

        public Event(int date, int participantsPerGroup, int numberOfGroups)
        {
            Date = date;
            ParticipantsPerGroup = participantsPerGroup;
            NumberOfGroups = numberOfGroups;
        }

        public bool CanProceed()
        {
            // Логика проверки возможности проведения события
            return true;
        }

        public List<string> GenerateParticipants()
        {
            // Логика генерации участников
            return new List<string>();
        }

        public override string ToString()
        {
            return $"Дата: {Date}, Участники в группе: {ParticipantsPerGroup}, Количество групп: {NumberOfGroups}";
        }
    }
}

