public function PaulSays(byval input as boolean) as string
	If input Then
		return "Hi"
	Else
		return "Blank Expression"
	End If
end function

If PaulSays(true) = "Hi" Then
Console.WriteLine("Paul says hello")
End If

If PaulSays(false) <> "Hi" Then
Console.WriteLine("Paul doesn't greet you")
End If

Console.WriteLine("Paul says " & PaulSays(true))
