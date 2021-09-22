namespace EASV.TestTechniques.Exercise1
{
    public class GradeCalculator : IGradeCalculator
    {
        public int ToGrade(int percentage)
        {
            int grade = 0;
            if (percentage >= 0 && percentage <= 5)
            {
                grade = -3;
                return grade;
            }

            if (percentage >= 6 && percentage <= 49)
            {
                grade = 0;
                return grade;
            }

            if (percentage >= 50 && percentage <= 59)
            {
                grade = 2;
                return grade;
            }

            if (percentage >= 60 && percentage <= 79)
            {
                grade = 4;
                return grade;
            }

            if (percentage >= 80 && percentage <= 84)
            {
                grade = 7;
                return grade;
            }

            if (percentage >= 85 && percentage <= 94)
            {
                grade = 10;
                return grade;
            }

            return 12;
        }
    }
}