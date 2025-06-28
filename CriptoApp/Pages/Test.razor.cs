using Microsoft.AspNetCore.Components;

public class TestBase : ComponentBase
{
    public string result = "";

    public void DoLogic()
    {
        result = "тест";
    }
}