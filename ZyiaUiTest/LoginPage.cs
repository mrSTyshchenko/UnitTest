using OpenQA.Selenium;

namespace ZyiaUiTest;

public class LoginPage(IWebDriver driver)
{
    private readonly string UserNameXpath = "//*[@id=\"MasterContentBody1_txt_username\"]";
    private readonly string PasswordXpath = "//*[@id=\"MasterContentBody1_txt_password\"]";
    private readonly string LoginButtonXpath = "//*[@id=\"btnLogin\"]";

    public HomePage ClickLogInButton(string userName, string password)
    {
        var userNameField = driver.FindElement(By.XPath(UserNameXpath));
        var passwordField = driver.FindElement(By.XPath(PasswordXpath));
        var loginButton = driver.FindElement(By.XPath(LoginButtonXpath));

        userNameField.SendKeys(userName);
        passwordField.SendKeys(password);

        loginButton.Click();

        return new HomePage();
    }
}
