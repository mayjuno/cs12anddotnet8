using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared;

public class BankAccount
{
    public string? AccountName; // Instance member. It could be null.
    public decimal Balance; // Instance member. Default value is 0.
    public static decimal InterestRate; // Static member (Shared member). Default value is 0.
}
