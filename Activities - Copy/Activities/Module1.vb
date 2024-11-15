Module Module1
    Public Function GradeConvert(ByVal initialGrades As Integer) As String
        If initialGrades >= 98 AndAlso initialGrades <= 100 Then
            Return "Grades = 1.00"
        ElseIf initialGrades >= 95 AndAlso initialGrades <= 97 Then
            Return "Grades = 1.25"
        ElseIf initialGrades >= 92 AndAlso initialGrades <= 94 Then
            Return "Grades = 1.50"
        ElseIf initialGrades >= 89 AndAlso initialGrades <= 91 Then
            Return "Grades = 1.75"
        ElseIf initialGrades >= 86 AndAlso initialGrades <= 88 Then
            Return "Grades = 2.00"
        ElseIf initialGrades >= 83 AndAlso initialGrades <= 85 Then
            Return "Grades = 2.25"
        ElseIf initialGrades >= 80 AndAlso initialGrades <= 82 Then
            Return "Grades = 2.50"
        ElseIf initialGrades >= 77 AndAlso initialGrades <= 79 Then
            Return "Grades = 2.75"
        ElseIf initialGrades >= 75 AndAlso initialGrades <= 76 Then
            Return "Grades = 3.00"
        ElseIf initialGrades <= 74 AndAlso initialGrades >= 60 Then
            Return "Grades = 5.00"
        Else
            Return "INVALID INPUT"
        End If
    End Function
End Module
