using System;
using System.Threading.Tasks;
using Moq;
using src.Api.Domain.Dtos.UserDto;
using src.Api.Domain.Interfaces.Services.User;
using Xunit;

namespace src.Api.Service.Test.Usuario
{
    public class QuandoForExecutadoGet : UsuarioTestes
    {
        private IUserService _service;
        private Mock<IUserService> _serviceMock;

        [Fact(DisplayName = "É possivel Executar o Método GET.")]
        public async Task E_Possivel_Executar_Metodo_Get()
        {
            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(m => m.Get(IdUsuario)).ReturnsAsync(userDto);
            _service = _serviceMock.Object;

            var result = await _service.Get(IdUsuario);

            Assert.NotNull(result);
            Assert.True(result.Id == IdUsuario);
            Assert.Equal(NomeUsuario, result.Name);

            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(m => m.Get(It.IsAny<Guid>())).Returns(Task.FromResult((UserDto)null));
            _service = _serviceMock.Object;

            var _record = await _service.Get(IdUsuario);
            Assert.Null(_record);
        }
    }
}
