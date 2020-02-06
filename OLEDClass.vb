Class OLEDClass
    Sub OLED_ShowChar(x As Object, y As Object, c As Object)
        Console.WriteLine("-----------OLED_ShowChar------------")
        Console.WriteLine("x:" & x.ToString)
        Console.WriteLine("y:" & y.ToString)
        Console.WriteLine("c:" & c.ToString)
        Return
    End Sub
    Sub OLED_Clear()
        Console.WriteLine("-----------OLED_Clear------------")
        Return
    End Sub
End Class