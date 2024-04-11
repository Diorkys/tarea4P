using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TuProyecto.Tests
{
    [TestFixture]
    public class PruebasUsuario
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void CrearUsuario()
        {
            // Simular la creación de un usuario
            driver.Navigate().GoToUrl("about:blank"); // Simular navegación a una página en blanco
            IWebElement nombreInput = driver.FindElement(By.Id("nombre"));
            nombreInput.SendKeys("Nuevo Usuario");
            IWebElement fechaInput = driver.FindElement(By.Id("fecha"));
            fechaInput.SendKeys(DateTime.Now.ToString("yyyy-MM-dd"));
            IWebElement contrasenaInput = driver.FindElement(By.Id("contrasena"));
            contrasenaInput.SendKeys("contrasena123");
            IWebElement guardarButton = driver.FindElement(By.Id("guardar"));
            guardarButton.Click();

            // Verificar que el usuario se haya creado correctamente (puedes agregar más aserciones según tu lógica de negocio)
            IWebElement confirmacion = driver.FindElement(By.Id("confirmacion"));
            Assert.That(confirmacion.Text, Does.Contain("Usuario creado exitosamente"));
        }

        [Test]
        public void ActualizarUsuario()
        {
            // Simular la actualización de un usuario (requiere que exista un usuario previamente)
            driver.Navigate().GoToUrl("about:blank"); // Simular navegación a una página en blanco
            // Encuentra el usuario que quieres actualizar y realiza las acciones necesarias
            // Por ejemplo, podrías encontrar el usuario por su ID y luego modificar sus datos
            // Luego, haz clic en el botón de actualización y verifica que la actualización se haya realizado correctamente
        }

        [Test]
        public void EliminarUsuario()
        {
            // Simular la eliminación de un usuario (requiere que exista un usuario previamente)
            driver.Navigate().GoToUrl("about:blank"); // Simular navegación a una página en blanco
            // Encuentra el usuario que quieres eliminar y realiza las acciones necesarias
            // Por ejemplo, podrías encontrar el usuario por su ID y luego hacer clic en el botón de eliminar
            // Luego, verifica que el usuario se haya eliminado correctamente (puedes verificar que ya no aparezca en la lista de usuarios, por ejemplo)
        }
    }
}
