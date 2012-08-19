@Code
    ViewData("Title") = "Welcome"
End Code

<h2>Welcome</h2>

@ViewBag.NumTimes
@ViewBag.Message
<ul>
    
    @Code
        'Basically you put @ symbols in front of lines that are html interpreted
        '   In a code block, it is assumed that the code is language interpreted
        For i As Integer = 0 To ViewBag.NumTimes Step 1
            @<li>@ViewBag.Message</li>
            @<li>"sldfjsldk"</li>
        Next
    End Code
</ul>