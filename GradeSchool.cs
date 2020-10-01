using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    public Dictionary<string, int> School = new Dictionary<string, int>();
    
    public void Add(string student, int grade)
    {
        School.Add(student, grade);
    }

    public IEnumerable<string> Roster()
    {
        return School
            .OrderBy(item => item.Value).ThenBy(item => item.Key)
            .Select(item => item.Key);
    }

    public IEnumerable<string> Grade(int grade)
    {
        return School
            .Where(item => item.Value == grade)
            .OrderBy(item => item.Key)
            .Select(item => item.Key);
    }
}