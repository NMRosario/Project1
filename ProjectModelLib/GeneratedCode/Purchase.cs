﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Purchase : Trade
{
	public override double value
	{
		get { return this._numShares * this._shareValue; }
	}
    public Purchase(int newNumShares, double newShareValue, DateTime newTradeDate)
    {
        this._numShares = newNumShares;
        this._shareValue = newShareValue;
        this._tradeDate = newTradeDate;
    }
}

