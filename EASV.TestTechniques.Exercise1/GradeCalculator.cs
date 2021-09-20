﻿namespace EASV.TestTechniques.Exercise1
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
            
            return -1;
        }
    }
}