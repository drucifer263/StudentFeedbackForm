using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1
{
    //Class calculates the course and professor scores and grades
    public class Calculator
    {
        //Calculates course score and returns decimal value
        public static decimal calculateCourseScore(string[] courseQuestions)
        {    
            decimal courseScore = 0;

            //Collects each converted question and places and sums it into courseScore
            for (int i = 0; i < courseQuestions.Length; i++)
            {
                courseScore += calculateScore(courseQuestions[i]);
            }

            return courseScore;
        }

        //Calculates professor score and returns decimal value
        public static decimal calculateProfessorScore(string[] professorQuestions)
        {
            decimal professorScore = 0;

            //Collects each converted question and places and sums it into professorScore
            for (int i = 0; i < professorQuestions.Length; i++)
            {

                professorScore += calculateScore(professorQuestions[i]);
            }

            return professorScore;   
        }

        //Calculates the average score based on the number of questions
        public static decimal calculateAverage(decimal score, int length)
        {
            decimal average = 0;
            decimal perfectScore = 0;
            int countQuestions = 0;

            //Gets the number of items in the series
            countQuestions = length;

            //Calculates what the perfect score or idea average is
            perfectScore = countQuestions * 5;

            //Calculates and returns the average score
            average = (score / perfectScore) * 100;

            return average;
        }

        //Converts the question to a numerical value
        public static int calculateScore(string question)
        {
            //Calculates and returns the numerical value for each question answered
            int score = 0;

            if (question == "Strongly Agree")
            {
                score = 5;
            }

            else if (question == "Agree")
            {
                score = 4;

            }

            else if (question == "Neutral")
            {
                score = 3;
            }

            else if (question == "Disagree")
            {
                score = 2;
            }

            else
            {
                score = 1;
            }

            return score;
        }

        //Calculates the grade based of the score sent
        public static string calculateGrade(decimal score)
        {
            string letterGrade = "";

            //Checks to see where the score lies and returns a letter based on numerical values
            if (score >= 90)
            {
                letterGrade = "A";
            }

            else if (score >= 80 && score < 90)
            {
                letterGrade = "B";
            }

            else if (score >= 70 && score < 80)
            {
                letterGrade = "C";
            }

            else if (score >= 65 && score < 70)
            {
                letterGrade = "D";
            }

            else
            {
                letterGrade = "F";
            }

            return letterGrade;
        }
    }
}