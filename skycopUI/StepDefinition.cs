using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;


namespace SeleniumTemplate
{
    [Binding]
    public class StepDefinition
    {
        private PageObject _pageObject;
        public PageObject PageObject => _pageObject ?? (_pageObject = new PageObject());
        public static IWebDriver Driver;
        public class Browser 

        {
            public IWebDriver Chrome;

            public Browser()
            {
                var options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                Chrome = new ChromeDriver(options);
            }
        }

        public StepDefinition(Browser browser)
        {
            Driver = browser.Chrome;
            PageFactory.InitElements(Driver, PageObject);
        }

        
        

        [Given(@"I navigate to claims")]
        public void GivenINavigateToClaims()
        {
            Driver.Url = "https://claim.skycop.com";
        
        }

        [Then(@"I set Kaunas as departure airport")]
        public void ThenISetKaunasAsDepartureAirport()
        {
            Thread.Sleep(2000);

            PageObject.DeparturePort.SendKeys(Constants.City);

            Thread.Sleep(2000);
            
            PageObject.KaunasSelection.Click();
        }
        [Then(@"I set London Gatwick airport, click the Gatwick option")]
        public void ThenISetLondonGatwickAirportClickTheGatwickOption()
        {
            Thread.Sleep(2000);
            
            PageObject.arriveairportfield.SendKeys(Constants.City2);

            Thread.Sleep(2000);
            var GetwickSelection = Driver.FindElement(By.XPath("//div[@title='London Gatwick Airport']"));
            GetwickSelection.Click();
        }
        [Then(@"I set airlines")]
        public void ThenISetAirlines()
        {
            Thread.Sleep(2000);
            var ArrowSelection = Driver.FindElement(By.XPath("//label[contains(text(),'Airlines *')]/..//span[@class='Select-arrow']"));
            ArrowSelection.Click();

            Thread.Sleep(2000);
            var AirlinesField = Driver.FindElement(By.XPath("(//input[@class='Select-input'])[3]"));
            AirlinesField.SendKeys(Constants.Airlines1);

            Thread.Sleep(2000);
            var RyanairSelection = Driver.FindElement(By.XPath("//div[@title='Ryanair']"));
            RyanairSelection.Click();
        }
        [Then(@"I enter Flight number and date")]
        public void ThenIEnterFlightNumber()
        {
            Thread.Sleep(2000);
            var FlightNumberField = Driver.FindElement(By.XPath("//input[@name='failedFlightNumberDigits']"));
            FlightNumberField.SendKeys("234");

            Thread.Sleep(2000);
            var FlightDate = Driver.FindElement(By.XPath("//div[@name='failedFlightDate']"));
            FlightDate.Click();
            Thread.Sleep(2000);
            var JanuaryDate = Driver.FindElement(By.XPath("//th[@class='rdtPrev']"));
            JanuaryDate.Click();
            Thread.Sleep(2000);
            var JanuarySeventhDate = Driver.FindElement(By.XPath("//td[@data-value='7']"));
            JanuarySeventhDate.Click();
        }
        [Then(@"set the problem of the flight")]
        public void ThenSetTheProblemOfTheFlight()
        {
            Thread.Sleep(2000);
            var DelayedSet = Driver.FindElement(By.XPath("//span[@class='form-check-label form-check-label--bold']"));
            DelayedSet.Click();

            Thread.Sleep(2000);
            var MissedConnectingDelayedSet = Driver.FindElement(By.XPath("(//span[@class='form-check-label form-check-label--bold'])[6]"));
            MissedConnectingDelayedSet.Click();
        }
        [Then(@"I choose reason provided by airlines")]
        public void ThenIChooseReasonProvidedByAirlines()
        {
            Thread.Sleep(2000);
            var ReasonProvidedByAirlines = Driver.FindElement(By.XPath("(//span[@class='Select-arrow'])[5]"));
            ReasonProvidedByAirlines.Click();

            Thread.Sleep(2000);
            var NoReason = Driver.FindElement(By.XPath("//div[@id='react-select-6--option-5']"));
            NoReason.Click();
        }
        [Then(@"where did you hear about us")]
        public void ThenWhereDidYouHearAboutUs()
        {
            Thread.Sleep(2000);
            var IHeartfromArrow = Driver.FindElement(By.XPath("(//span[@class='Select-arrow'])[6]"));
            IHeartfromArrow.Click();

            Thread.Sleep(2000);
            var NewsBlogSelection = Driver.FindElement(By.XPath("//div[@id='react-select-7--option-5']"));
            NewsBlogSelection.Click();
        }
        [Then(@"Mext Button Selection in (.*)")]
        public void ThenMextButtonSelectionIn(string p0)
        {
            Thread.Sleep(2000);
            var NextButtonSelection = Driver.FindElement(By.XPath("//button[@class='sc-jzgbtB fuZkWY sc-lhVmIH hgYwDF']"));
            NextButtonSelection.Click();
        }
        [Then(@"I whrite short History")]
        public void ThenIWhriteShortHistory()
        {
            Thread.Sleep(2000);
            var HistoryComplain = Driver.FindElement(By.XPath("//textarea[@class='form-control sc-dUjcNx eiJlti']"));
            HistoryComplain.SendKeys("Departure was delaied and I didn't get to next flight");
        }
        [Then(@"enter flight reservation number")]
        public void ThenEnterFlightReservationNumber()
        {
            PageObject.FlightReservationNumber.SendKeys(Constants.FRezNum);
        }
        [Then(@"I press Button Travelers Details")]
        public void ThenIPressButtonTravelersDetails()
        {
            PageObject.ButtonTravelersDetails.Click();
        }
        [Then(@"Filling Personal Info")]
        public void ThenFillingPersonalInfo()
        {
            PageObject.PersonInfoName.SendKeys(Constants.Name);
            PageObject.PersonInfoSurName.SendKeys(Constants.Surname);
            PageObject.BirthDate.Click();
            Thread.Sleep(2000);
            PageObject.BirthDateArrow1.Click();
            Thread.Sleep(4000);
            PageObject.BirthDateArrow2.Click();
            PageObject.BirthDateYear.Click();
            PageObject.BirthDateMoth.Click();
            PageObject.BirthDateDay.Click();
            PageObject.Email.Click();
            PageObject.Email.SendKeys(Constants.PersnEmail);
            PageObject.EmailConfirm.Click();
            PageObject.EmailConfirm.SendKeys(Constants.PersnEmail);
            //PageObject.PhoneCode.Click();
            //PageObject.PhoneCodeSearchField.Click();
            //Thread.Sleep(2000);
            //PageObject.PhoneCodeSubField.SendKeys("Lithuania");
        }
        [Then(@"Filling contact info")]
        public void ThenFillingContactInfo()
        {
            PageObject.Address.Click();
            PageObject.Address.SendKeys(Constants.Address);
            PageObject.CityAddress.Click();
            PageObject.CityAddress.SendKeys(Constants.CityAddress);
            PageObject.Postcode.Click();
            PageObject.Postcode.SendKeys(Constants.Postcode);
            //PageObject.CountryAddressArrow.Click();
            PageObject.CountryAddressField.SendKeys(Constants.Country);
            PageObject.CountryAddressChoose.Click();
            PageObject.CountryLanguageArrow.Click();
            PageObject.CountryLanguageField.Click();
            PageObject.TravellingAloneSeting.Click();
            PageObject.FelowPassengersSeting.Click();
        }
        [Then(@"Fellow Passengers Setting")]
        public void ThenFellowPassengersSetting()
        {
            PageObject.NameFellow1Passenger.SendKeys(Constants.NameFellow);
            PageObject.SurnameFellow1Passenger.SendKeys(Constants.SurnameFellow);
            PageObject.BirthDateFellow1.Click();
            PageObject.BirthFellow1Arrow.Click();
        }



    }


}