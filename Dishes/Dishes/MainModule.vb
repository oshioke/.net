'1.	You must enter time of day as “morning” or “night” 
'2.	You must enter a comma delimited list of dish types with at least one selection
'3.	The output must print food in the following order: entrée, side, drink, dessert
'4.	There is no dessert for morning meals
'5.	Input is not case sensitive
'6.	If invalid selection is encountered, display valid selections up to the error, then print error
'7.	In the morning, you can order multiple cups of coffee
'8.	At night, you can have multiple orders of potatoes
'9.	Except for the above rules, you can only order 1 of each dish type



Module MainModule


    Sub Main()

        Dim timeOfDay As String
        Console.WriteLine("Welcome, Please enter the time of day as morning or night : ")
        timeOfDay = Console.ReadLine()
        Console.WriteLine(timeOfDay)

        If timeOfDay = "morning" Then
            Console.WriteLine("What would you like this morning? ")

        Else
            Console.WriteLine("do again ")



        End If
        Console.ReadKey()


    End Sub

   

End Module
