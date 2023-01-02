using ChapterBET9.Controllers;
using ChapterBET9.Interfaces;
using ChapterBET9.Models;
using ChapterBET9.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;

namespace TesteIntegracao
{
    public class LoginControllerTeste
    {
        [Fact]
        public void LoginControllerRetornarUserInvalio()
        {
            // Arrange
            var usuarioRepository = new Mock<IUsuarioRepository>();

            usuarioRepository.Setup(x => x.Login(It.IsAny<string>(), It.IsAny<string>())).Returns((Usuario)null);

            var controller = new LoginController(usuarioRepository.Object);

            LoginViewModel dadosUsuarios = new LoginViewModel();

            dadosUsuarios.Email = "teste@mail.com";
            dadosUsuarios.Senha = "teste";

            // Act
            var result = controller.Login(dadosUsuarios);

            // Assert
            Assert.IsType<UnauthorizedResult>(result);
        }

        [Fact]
        public void LoginControllerRetornarToken()
        {
            // Arrange
            var usuarioRetornado = new Usuario();
            usuarioRetornado.Id = 1;
            usuarioRetornado.Email = "teste@mail.com";
            usuarioRetornado.Senha = "teste";
            usuarioRetornado.Tipo = "1";

            var reposotoryFake = new Mock<IUsuarioRepository>();

            reposotoryFake.Setup(x => x.Login(It.IsAny<string>(), It.IsAny<string>())).Returns(usuarioRetornado);

            LoginViewModel dadosUsuarios = new LoginViewModel();

            dadosUsuarios.Email = "bananinha@email.com";
            dadosUsuarios.Senha = "bananinha";

            var controller = new LoginController(reposotoryFake.Object);

            // Act

            OkObjectResult result = (OkObjectResult)controller.Login(dadosUsuarios);

            string token = result.Value.ToString().Split(" ")[3];

            var JwtHandler = new JwtSecurityTokenHandler();
            var tokenJwt = JwtHandler.ReadJwtToken(token);

            // Assert

            Assert.Equal("Chapter.WebApi", tokenJwt.Issuer);
        }
    }
}