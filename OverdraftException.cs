using System;
using System.Runtime.Serialization;

namespace BankingDomain
{
    public class OverdraftException : Exception
    {
        public OverdraftException()
        {
        }

    }
}