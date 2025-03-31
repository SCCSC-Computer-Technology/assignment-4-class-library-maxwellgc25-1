using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace M_Cantrell_CPT_206_Lab_4
{
    //Max Cantrell
    //CPT 206-A80S
    //Lab 4-Class Library for Lab 3
    //3-28-25
    public class StateInfoLibrary
    {
        //fields - properties
        public int stateId { get; set; }
        public string state { get; set; }
        public string capital { get; set; }
        public int population { get; set; }
        public string flower { get; set; }
        public string bird { get; set; }
        public string largestCities { get; set; }
        public string colors { get; set; }
        public int medianIncome { get; set; }
        public int compJobsPerc { get; set; }
        public string flagDesc { get; set; }


        //default constructor
        public StateInfoLibrary()
        {
            stateId = 0;
            state = string.Empty;
            capital = string.Empty;
            population = 0;
            flower = string.Empty;
            bird = string.Empty;
            largestCities = string.Empty;
            colors = string.Empty;
            medianIncome = 0;
            compJobsPerc = 0;
            flagDesc = string.Empty;
        }
        //constructor 1
        public StateInfoLibrary(int idState, string stateName, string statecapital, int statepopulation,
            string stateflower, string statebird, string largeCities, string statecolors,
            int statemedianIncome, int statecompJobs, string stateflagDesc)
        {
            stateId = idState;
            state = stateName;
            capital = statecapital;
            population = statepopulation;
            flower = stateflower;
            bird = statebird;
            largestCities = largeCities;
            colors = statecolors;
            medianIncome = statemedianIncome;
            compJobsPerc = statecompJobs;
            flagDesc = stateflagDesc;
        }
    }
}
