<Query Kind="Program">
  <Connection>
    <ID>536b2f1b-b7dd-4c78-9913-d8d6fbf7e9e6</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DCOL-DAS-SqlServer-WEU.database.windows.net</Server>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
    <Database>DASPayments</Database>
    <SqlSecurity>true</SqlSecurity>
    <UserName>DASPaymentROUser</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAeIJ8+4/2jUyCQ0tlOZ9uSgAAAAACAAAAAAAQZgAAAAEAACAAAAAEXOy3/3k/sseiFurxL9p3GfNS39CBHhZf1fV+lJSuPAAAAAAOgAAAAAIAACAAAADdz+WXej0+vvymyRhR1ytqRWNjHMwxSsF+YODiAEaxD1AAAADUefvmBO3sv4RNDE/fTg0gRLz/PQNcPq2wzbtPu2ak6G5MTZcmLvIo5Mkj0cZZoQhk7r8zbipeCjDjAMGUa5CV7HwVWNcDjktIpFpPapEvJUAAAADgW33hw4lBC6PDJHmQ5IDQqsRfXtMXNp8+3ZBUGLPbJ1Wo/r9+/PRRGzOqGLMKQNsXJK1O28DPaCSrSWsvKrjg</Password>
    <DbVersion>Azure</DbVersion>
  </Connection>
</Query>

void Main()
{
    Currency cur = "£";
    cur.Value = 10;
    cur.ToString().Dump("Implicit assignment");
    
    Currency c1 = 10;
    c1.ToString().Dump("Implicit conversion from integer");
    
    decimal d1 = c1;
    d1.ToString().Dump("Implicit conversion to decimal");
    
    Currency c2 = 10.33m;
    long l1 = c2;
    l1.ToString().Dump("Implicit conversion to long");
}


public class Currency
{
    public string Sign { get; set; }
    public decimal Value { get; set; }
    
    public Currency(decimal value, string sign)
    {
        Sign = sign;
        Value = value;
    }
    
    public static implicit operator Currency(string sign) => new Currency(0, sign);
    public static implicit operator Currency(int value) => new Currency(value,"$");
    public static implicit operator Currency(decimal value) => new Currency(value,"$");
    public static implicit operator decimal(Currency cur) => cur.Value;
    public static implicit operator long(Currency cur) => (long)cur.Value;

    public override string ToString()
    {
        return $"{Sign}{Value}";
    }
}