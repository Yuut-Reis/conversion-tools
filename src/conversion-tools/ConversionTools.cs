namespace conversion_tools;

public class ConversionTools
{

    public string? strVariable;
    public int? intVariable;
    public double? doubleVariable;

    public void ConvertStrToInt()
    {
        if(strVariable is string) intVariable = Convert.ToInt32(strVariable);
    }

    public void ConvertStrToDouble()
    {   
       if(strVariable is string) doubleVariable = Convert.ToDouble(strVariable);
    }

    public void ConvertIntToStr()
    {
        if(intVariable is int) strVariable = Convert.ToString(intVariable);
    }

    public void ConvertDoubleToStr()
    {
        if(doubleVariable is double) strVariable = Convert.ToString(doubleVariable);
    }

}
