namespace Harley.Enum.Transition
{
    #region TransitionFormTypesEnum

    public enum Direction
    {
        Normal = 0X0,
        HorizantalPositive = 0X1,
        HorizantalNegative = 0X2,
        VerticalPositive = 0X4,
        VerticalNegative = 0X8,
        DiagonalPositive = 0X6,
        Center = 0X10,
        Blend = 0X80000
    }

    public enum Speed
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        TwentyFive = 25,
        Fifty = 50,
        OneHundred = 100,
        TwoHundred = 200,
        ThreeHundred = 300,
        FourHundred = 400,
        FiveHundred = 500,
        SixHundred = 600,
        SevenHundred = 700,
        EightHundred = 800,
        NineHundred = 900,
        OneSecond = 1000,
        TwoSecond = 2000,
        ThreeSecond = 3000,
        FourSecond = 4000,
        FiveSecond = 5000,
        SixSecond = 6000,
        SevenSecond = 7000,
        EightSecond = 8000,
        NineSecond = 9000,
        TenSecond = 10000
    }

    #endregion
}