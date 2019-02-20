using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTemplate
{
    public class PageObject
    {
        
        [FindsBy(How = How.XPath, Using = "(//input[@class='Select-input'])[1]")]
        public IWebElement DeparturePort;

        [FindsBy(How = How.XPath, Using = "(//div[@title='Kaunas International Airport'])[1]")]
        public IWebElement KaunasSelection;

        [FindsBy(How = How.XPath, Using = "(//input[@class='Select-input'])[2]")]
        public IWebElement arriveairportfield;



        [FindsBy(How = How.XPath, Using = "(//input[@class='form-control sc-kkGfuU eUxbsH'])")]
        public IWebElement FlightReservationNumber;

        [FindsBy(How = How.XPath, Using = "(//button[@class='sc-lkqHmb gWdxsM sc-lhVmIH hgYwDF'])")]
        public IWebElement ButtonTravelersDetails;

        [FindsBy(How = How.XPath, Using = "(//input[@class='sc-kkGfuU eUxbsH'])[1]")]
        public IWebElement PersonInfoName;

        [FindsBy(How = How.XPath, Using = "(//input[@class='sc-kkGfuU eUxbsH'])[2]")]
        public IWebElement PersonInfoSurName;

        [FindsBy(How = How.XPath, Using = "(//input[@class='form-control form-control--datepicker js-datepicker js-checkable bg-white needsclick data-hj-whitelist'])")]
        public IWebElement BirthDate;

        [FindsBy(How = How.XPath, Using = "(//th[@class='rdtNext'])")]
        public IWebElement BirthDateArrow1;

        [FindsBy(How = How.XPath, Using = "(//th[@class='rdtNext'])")]
        public IWebElement BirthDateArrow2;

        [FindsBy(How = How.XPath, Using = "(//td[@data-value='2000'])")]
        public IWebElement BirthDateYear;

        [FindsBy(How = How.XPath, Using = "(//td[@data-value='2'])")]
        public IWebElement BirthDateMoth;

        [FindsBy(How = How.XPath, Using = "(//td[@data-value='15'])")]
        public IWebElement BirthDateDay;

        [FindsBy(How = How.XPath, Using = "(//input[@class='sc-kkGfuU eUxbsH'])[3]")]
        public IWebElement Email;

        [FindsBy(How = How.XPath, Using = "(//input[@class='sc-kkGfuU eUxbsH'])[4]")]
        public IWebElement EmailConfirm;

        // [FindsBy(How = How.XPath, Using = "(//input[@class='sc-kkGfuU eUxbsH'])[5]")]
        //public IWebElement PhoneCode;

        //[FindsBy(How = How.XPath, Using = "(//div[@class='Select-input'])[1]")]
        //public IWebElement PhoneCodeSearchField;

        //[FindsBy(How = How.XPath, Using = "(//input[@class='sc-kkGfuU eUxbsH'])[6]")]
        //public IWebElement PhoneCodeSubField;

        // [FindsBy(How = How.XPath, Using = "(//input[@role='combobox'])")]
        // public IWebElement ;

        [FindsBy(How = How.XPath, Using = "(//input[@class='sc-kkGfuU eUxbsH'])[7]")]
        public IWebElement Address;

        [FindsBy(How = How.XPath, Using = "(//input[@class='sc-kkGfuU eUxbsH'])[8]")]
        public IWebElement CityAddress;

        [FindsBy(How = How.XPath, Using = "(//input[@class='sc-kkGfuU eUxbsH'])[9]")]
        public IWebElement Postcode;

        //[FindsBy(How = How.XPath, Using = "//label[contains(text(),'Country *')]/..//span[@class='Select-arrow']")]
        //public IWebElement CountryAddressArrow;

        [FindsBy(How = How.XPath, Using = "(//input[@class='Select-input'])[1]")]
        public IWebElement CountryAddressField;

        [FindsBy(How = How.XPath, Using = "(//div[@id='react-select-10--option-0'])")]
        public IWebElement CountryAddressChoose;

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Language *')]/..//span[@class='Select-arrow']")]
        public IWebElement CountryLanguageArrow;

        [FindsBy(How = How.XPath, Using = "(//div[@id='react-select-11--option-1'])")]
        public IWebElement CountryLanguageField;

        [FindsBy(How = How.XPath, Using = "(//label[@class='sc-eqIVtm buildE'])[2]")]
        public IWebElement TravellingAloneSeting;

        [FindsBy(How = How.XPath, Using = "(//label[@class='sc-eqIVtm buildE'])[1]")]
        public IWebElement FelowPassengersSeting;

        [FindsBy(How = How.XPath, Using = "(//input[@class='sc-kkGfuU eUxbsH'])[10]")]
        public IWebElement NameFellow1Passenger;

        [FindsBy(How = How.XPath, Using = "(//input[@class='sc-kkGfuU eUxbsH'])[11]")]
        public IWebElement SurnameFellow1Passenger;

        [FindsBy(How = How.XPath, Using = "(//input[@class='form-control form-control--datepicker js-datepicker js-checkable bg-white needsclick data-hj-whitelist'])[2]")]
        public IWebElement BirthDateFellow1;

        [FindsBy(How = How.XPath, Using = "(//th[@class='rdtNext'])[2]")]
        public IWebElement BirthFellow1Arrow;

       // [FindsBy(How = How.XPath, Using = "(//td[@data-value='2000'])")]
       // public IWebElement BirthDateYear;

    }
}
