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

public class Portfolio
{
	protected virtual Dictionary<string,Position> positions
	{
		get;
		set;
	}

	public virtual IEnumerable<Position> Position
	{
		get;
		set;
	}

	public virtual double AccountBalance()
	{
		throw new System.NotImplementedException();
	}

	public virtual void ToString()
	{
		throw new System.NotImplementedException();
	}

	public virtual bool Purchase(string symbol, Trade purchase)
	{
		throw new System.NotImplementedException();
	}

	public virtual bool Sell(string symbol, Trade sale)
	{
		throw new System.NotImplementedException();
	}

	public virtual double GainLossReport(DateTime startDate, DateTime endDate)
	{
		throw new System.NotImplementedException();
	}

	public Portfolio()
	{
	}

}

