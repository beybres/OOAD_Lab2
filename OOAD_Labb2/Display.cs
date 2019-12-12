using System;
using System.Collections.Generic;
using static System.Console;

namespace OOAD_Labb2
{
    public class Display
    {
        private INetwork service;

        public Display(INetwork service)
        {
            this.service = service;
        }

        public void Start()
        {
            WriteLine("Press enter to see list of people in space!!!");
            ReadLine();
            DisplayPeople(service.getPeopleInSpace());
        }
        private static void DisplayPeople(List<Astronauts> people)
        {
            for (int i = 0; i < people.Count; i++)
            {
                var person = people[i];

                WriteLine("Name: " + person.name);
                WriteLine("Aircraft: " + person.craft + "/n");
                WriteLine(" ");
            }
        }
    }
}