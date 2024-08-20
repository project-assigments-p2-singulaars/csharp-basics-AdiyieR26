 //CON FORMATEO
 // Datos del estudiante y cursos
        string studentName = "Sophia Johnson";
        string course1Name = "English 101";
        string course2Name = "Algebra 101";
        string course3Name = "Biology 101";
        string course4Name = "Computer Science I";
        string course5Name = "Psychology 101";

        int course1Credit = 3;
        int course2Credit = 3;
        int course3Credit = 4;
        int course4Credit = 4;
        int course5Credit = 3;

        int gradeA = 4;
        int gradeB = 3;

        int course1Grade = gradeA;
        int course2Grade = gradeB;
        int course3Grade = gradeB;
        int course4Grade = gradeB;
        int course5Grade = gradeA;

        // Cálculo de las horas de crédito y puntos de calificación totales
        int totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
        int totalGradePoints = (course1Credit * course1Grade) +
                                (course2Credit * course2Grade) +
                                (course3Credit * course3Grade) +
                                (course4Credit * course4Grade) +
                                (course5Credit * course5Grade);

        // Cálculo del GPA
        decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

        // Extracción de los dígitos del GPA
        int leadingDigit = (int)gradePointAverage;
        int firstDigit = (int)(gradePointAverage * 10) % 10;
        int secondDigit = (int)(gradePointAverage * 100) % 10;

        // Salida en la consola con formato
        Console.WriteLine($"Student: {studentName}\n");
        Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

        Console.WriteLine($"{course1Name,-20}\t{course1Grade}\t{course1Credit}");
        Console.WriteLine($"{course2Name,-20}\t{course2Grade}\t{course2Credit}");
        Console.WriteLine($"{course3Name,-20}\t{course3Grade}\t{course3Credit}");
        Console.WriteLine($"{course4Name,-20}\t{course4Grade}\t{course4Credit}");
        Console.WriteLine($"{course5Name,-20}\t{course5Grade}\t{course5Credit}");

        Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");
    
 //SIN FORMATEO
 // Datos del estudiante y cursos
        // string studentName = "Sophia Johnson";
        // string course1Name = "English 101";
        // string course2Name = "Algebra 101";
        // string course3Name = "Biology 101";
        // string course4Name = "Computer Science I";
        // string course5Name = "Psychology 101";

        // int course1Credit = 3;
        // int course2Credit = 3;
        // int course3Credit = 4;
        // int course4Credit = 4;
        // int course5Credit = 3;

        // int gradeA = 4;
        // int gradeB = 3;

        // int course1Grade = gradeA;
        // int course2Grade = gradeB;
        // int course3Grade = gradeB;
        // int course4Grade = gradeB;
        // int course5Grade = gradeA;

        // // Cálculo de las horas de crédito y puntos de calificación totales
        // int totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
        // int totalGradePoints = (course1Credit * course1Grade) +
        //                         (course2Credit * course2Grade) +
        //                         (course3Credit * course3Grade) +
        //                         (course4Credit * course4Grade) +
        //                         (course5Credit * course5Grade);

        // // Cálculo del GPA
        // decimal gradePointAverage = (decimal)totalGradePoints / totalCreditHours;

        // // Extracción de los dígitos del GPA
        // int leadingDigit = (int)gradePointAverage;
        // int firstDigit = (int)(gradePointAverage * 10) % 10;
        // int secondDigit = (int)(gradePointAverage * 100) % 10;

        // // Salida en la consola
        // Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
        // Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
        // Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
        // Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
        // Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}");

        // // Mostrar el GPA final con formato
        // Console.WriteLine($"Final GPA: {leadingDigit}.{firstDigit}{secondDigit}");