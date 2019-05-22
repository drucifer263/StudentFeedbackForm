using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1
{
    public partial class Processed : System.Web.UI.Page
    {
        //Variables
        private string[] courseQuestions = new string[12];
        private string[] professorQuestions = new string[8];

        private string name = "";
        private string tuID = "";
        private string course = "";
        private string cGrade = "";
        private string pGrade = "";

        private decimal courseScore = 0;
        private decimal professorScore = 0;
        private decimal cRating = 0;
        private decimal pRating = 0;

        private int clength = 0;
        private int plength = 0;

        //Page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //Hides error message
            displayError.Visible = false;

            //Grabs the student information
            getStudentInfo();
            
            //Checks that all input is valid
            if (Validator.validateNumber(tuID, displayError) && Validator.validateString(name, displayError) && Validator.validateString(course, displayError))
            {
                //Generates results for both questonaires
                generateResults(courseQuestions,professorQuestions);

                //Displays results
                displayResults();
            }

            //If data is not valid
            else
            {
                //Makes error message visable and dislplays it
                displayError.Visible = true;
                displayError.Text += " Invalid Data. Re enter Information.";
            } 
        }

        //Grabs student info
        protected void getStudentInfo()
        {
            displayError.Visible = false;

            //Grabs info from request object
            name = Request["txtName"];
            tuID = Request["txtTuID"];
            course = Request["courseSelection"];

            //Grabs course answers from request object
            for (int i = 0; i < courseQuestions.Length; i++)
            {
                //Increases the index for the request object and places
                courseQuestions[i] = Request["question" + (i + 1)];  

            }

            //Grabs professor answers from request object
            for (int i = 0; i < professorQuestions.Length; i++)
            {
                //Has the index start at 13 and adds the request objects to array
                professorQuestions[i] = Request["question" + (i + 13)];
            }
        }

        //Displays results
        protected void displayResults()
        {
            //Places info from variables into lables
            displayInfo.Text = "Name: " + name + "  TUID: " + tuID;
            displayCourse.Text += course;

            //Places info from arrays inro label
            for (int i = 0; i < courseQuestions.Length; i++)
            {
                //Index starts at one
                displayCourseFeedback.Text += "Question "+ (i + 1) + ": "+ courseQuestions[i] + ", \r ";
            }

            //Places info from arrays inro label
            for (int i = 0; i < professorQuestions.Length; i++)
            {
                //Makes index start at 13
                displayProfessorFeedback.Text += "Question " + (i + 13) + ": " + professorQuestions[i] + ", \r ";
            }

            //Places score and grade into labels
            displayCourseScore.Text = "Course Score: " + cRating + "\r Course Grade: " + cGrade;
            displayProfessorScore.Text = "Professor Score: " + pRating + " Professor Grade: " + pGrade;
            
        }

        //Generates results form survey
        protected void generateResults(string[] courseQuestions, string[] professorQuestions)
        {
            //Length variables for arrays
            clength = courseQuestions.Length;
            plength = professorQuestions.Length;

            //Gets the course score from the calcultor class
            courseScore = Calculator.calculateCourseScore(courseQuestions);
            professorScore = Calculator.calculateProfessorScore(professorQuestions);

            //Gets the ratings and grade for course 
            cRating = Calculator.calculateAverage(courseScore, clength);
            cGrade = Calculator.calculateGrade(cRating);

            //Gets rating and grade for professor
            pRating = Calculator.calculateAverage(professorScore, plength);
            pGrade = Calculator.calculateGrade(pRating);
        }
    }
}