using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
 



namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
    
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            string link = @"https://www.dodomama.com/";

            driver.Navigate().GoToUrl(link);
            Thread.Sleep(1000);

            driver.FindElement(By.ClassName("headerUyeGiris")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.Id("txtUyeGirisEmail")).SendKeys("deneme@gmail.com");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtUyeGirisPassword")).SendKeys("my123456789");
            Thread.Sleep(1000);
            driver.FindElement(By.ClassName("userLoginBtn")).Click();
            Thread.Sleep(2000);


            driver.Navigate().Refresh();
            driver.FindElement(By.Id("txtbxArama")).SendKeys("tasma"+Keys.Enter);
            Thread.Sleep(3000);
            driver.FindElement(By.LinkText("EASTLAND")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.LinkText("Eastland Kedi Boyun Tasma Çıngıraklı")).Click();     
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("Addtobasket")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("ticiNotyBtn")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Kedi")).Click();
            Thread.Sleep(2000);   
            driver.FindElement(By.LinkText("PrimaCat Classic Pouch Jöle İçinde Dana Etli Tahılsız Kedi Yaş Maması 12 Adet x 85 gr")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("Addtobasket")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("ticiNotyBtn")).Click();
            Thread.Sleep(2000); 
            driver.FindElement(By.LinkText("Köpek")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Warf 2 li Sığır Derisi Köpek Çiğneme Ödülü 100 Gr")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("Addtobasket")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("ticiNotyBtnConfirm")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.LinkText("SİPARİŞİ TAMAMLA")).Click();
            Thread.Sleep(2000); 
            driver.FindElement(By.Id("mainHolder_txtbxSiparisNotu")).SendKeys("Evde kimseyi bulamazsanız ayakkabılığın üstüne bırakabilirsiniz.");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("lnkBtnSiparisKaydet")).Click();


        }
    }
}
