﻿namespace conversion_tools;

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
        var formatDecimalPlace = 10;
        if(strVariable is string) doubleVariable =  Convert.ToDouble(strVariable) / formatDecimalPlace;
    }

    public void ConvertIntToStr()
    {
        throw new NotImplementedException();
    }

    public void ConvertDoubleToStr()
    {
        throw new NotImplementedException();
    }

}
