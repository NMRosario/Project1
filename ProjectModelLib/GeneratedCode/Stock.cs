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

public class Stock
{
    protected double _price;
	public virtual double price
	{
		get { return this._price; }
	}

    protected string _name;
	public virtual string name
	{
		get { return this._name; }
	}

	public Stock(string initName, double initPrice)
	{
        this._price = initPrice;
        this._name = initName;
	}

}

