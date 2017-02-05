namespace OperatorExample
{
    public struct Money
    {
        public decimal Value;
        public Currency Code;

        public Money(decimal value, Currency code)
        {
            Value = value;
            Code = code;
        }

        public static Money operator + (Money m1, Money m2)
        {
            if(m1.Code != m2.Code)
            {
                throw new DifferentCurrencyException(m1.Code, m2.Code);
            }

            Money sum;
            sum.Value = m1.Value + m2.Value;
            sum.Code = m1.Code;

            return sum;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.Value.ToString("n2"), this.Code.ToString());
        }
    }
}