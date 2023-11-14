Imports System
Imports Org.Mentalis.Utilities

Class TestApp
	Public Shared Sub Main()
		' create a new StopWatch
		Dim s As New StopWatch()
		' when we create a StopWatch, Reset() is automatically called,
		' so we do not need to do that again.
		Dim j As Integer = 0, i As Integer
		For i = 0 To 10000000
			j += 1
		Next i
		' print out the results
		Console.WriteLine("Your system took " + (s.Peek() / CType(10, Single)).ToString() + " milliseconds to process the loop.")
		' Make sure the users gets a chance to read the output
		Console.WriteLine("Press enter to continue...")
		Console.ReadLine()
	End Sub
End Class