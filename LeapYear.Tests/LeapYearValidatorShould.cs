using NUnit.Framework;

namespace LeapYear.Tests
{
    [TestFixture]
    public class LeapYearValidatorShould
    {
        [TestCase(2001, false)]
        [TestCase(1996, true)]
        [TestCase(1900, false)]
        [TestCase(2000, true)]
        public void ValidateALeapYear(int year, bool isValid)
        {
            var leapYearValidator = new LeapYearValidator();

            var result = leapYearValidator.Validate(year);

            Assert.That(result, Is.EqualTo(isValid));
        }
    }
}
