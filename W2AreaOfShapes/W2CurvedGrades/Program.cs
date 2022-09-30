using System.Data;

class W2CurvedGrades
{
    static void Main (string[] args)
    {
        ///Establish total points per assignment and intake students scores then determine percentages

        Console.WriteLine("How many points is this assignment worth?");
        int maxPoints = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What was the score of student 1?");
        int scoreStudent1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What was the score of student 2?");
        int scoreStudent2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What was the score of student 3?");
        int scoreStudent3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What was the score of student 4?");
        int scoreStudent4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What was the score of student 5?");
        int scoreStudent5 = Convert.ToInt32(Console.ReadLine());

        int percentStudent1 = (int)Math.Round((double)(100 * scoreStudent1) / maxPoints);
        int percentStudent2 = (int)Math.Round((double)(100 * scoreStudent2) / maxPoints);
        int percentStudent3 = (int)Math.Round((double)(100 * scoreStudent3) / maxPoints);
        int percentStudent4 = (int)Math.Round((double)(100 * scoreStudent4) / maxPoints);
        int percentStudent5 = (int)Math.Round((double)(100 * scoreStudent5) / maxPoints);

        string percent1 = percentStudent1.ToString("0.00%");
        string percent2 = percentStudent2.ToString("0.00%");
        string percent3 = percentStudent3.ToString("0.00%");
        string percent4 = percentStudent4.ToString("0.00%");
        string percent5 = percentStudent5.ToString("0.00%");

        ///Reassign highest score as point maximum and calculate curved percentages and scores

        int curvedMaxPoints = Math.Max(scoreStudent1, Math.Max(scoreStudent2, Math.Max(scoreStudent3, Math.Max(scoreStudent4, scoreStudent5))));

        int curvedPercent1 = (int)Math.Round((double)(100 * scoreStudent1) / curvedMaxPoints);
        int curvedPercent2 = (int)Math.Round((double)(100 * scoreStudent2) / curvedMaxPoints);
        int curvedPercent3 = (int)Math.Round((double)(100 * scoreStudent3) / curvedMaxPoints);
        int curvedPercent4 = (int)Math.Round((double)(100 * scoreStudent4) / curvedMaxPoints);
        int curvedPercent5 = (int)Math.Round((double)(100 * scoreStudent5) / curvedMaxPoints);

       

        ///Create table and display relevant info for each student.
        
        DataTable grades = new DataTable();
        grades.Columns.Add("Student 1");
        grades.Columns.Add("Student 2");
        grades.Columns.Add("Student 3");
        grades.Columns.Add("Student 4");
        grades.Columns.Add("Student 5");
        DataRow UncurvedPoints = grades.NewRow();
        UncurvedPoints["Student 1"] = scoreStudent1;
        UncurvedPoints["Student 2"] = scoreStudent2;
        UncurvedPoints["Student 3"] = scoreStudent3;
        UncurvedPoints["Student 4"] = scoreStudent4;
        UncurvedPoints["Student 5"] = scoreStudent5;
        DataRow UncurvedPercent = grades.NewRow();
        UncurvedPercent["Student 1"] = percent1;
        UncurvedPercent["Student 2"] = percent2;
        UncurvedPercent["Student 3"] = percent3;
        UncurvedPercent["Student 4"] = percent4;
        UncurvedPercent["Student 5"] = percent5;
        DataRow CurvedPercent = grades.NewRow();
        CurvedPercent["Student 1"] = curvedPercent1;
        CurvedPercent["Student 2"] = curvedPercent2;
        CurvedPercent["Student 3"] = curvedPercent3;
        CurvedPercent["Student 4"] = curvedPercent4;
        CurvedPercent["Student 5"] = curvedPercent5;
        

    }
}
