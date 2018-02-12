public function Paul(byval input as boolean) as string
	If input Then
		return "Hi"
	Else
		return "Blank Expression"
	End If
end function

If Paul(true) = "Hi" Then
Console.WriteLine("Paul says hello")
End If

If Paul(false) <> "Hi" Then
Console.WriteLine("Paul doesn't greet you")
End If

Console.WriteLine("Paul says " & Paul(true))

Console.WriteLine("Paul says " & Paul(true) fair enough!)