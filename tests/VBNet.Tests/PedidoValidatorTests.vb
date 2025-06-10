Imports NUnit.Framework
Imports VBNet.Domain

<TestFixture>
Public Class PedidoValidatorTests

    Private _validator As PedidoValidator

    <SetUp>
    Public Sub SetUp()
        _validator = New PedidoValidator()
    End Sub

    <Test>
    Public Sub Validate_PedidoIsNull_ReturnsError()
        ' Act
        Dim errors = _validator.Validate(Nothing)

        ' Assert
        Assert.AreEqual(1, errors.Count)
        Assert.AreEqual("Pedido não pode ser nulo.", errors(0))
    End Sub

    <Test>
    Public Sub Validate_IdLessThanOrEqualZero_ReturnsError()
        ' Arrange
        Dim pedido = New Pedido(0, 1, DateTime.Now, 10D)

        ' Act
        Dim errors = _validator.Validate(pedido)

        ' Assert
        Assert.Contains("Id deve ser maior que zero.", errors)
    End Sub

    <Test>
    Public Sub Validate_ClienteIdLessThanOrEqualZero_ReturnsError()
        ' Arrange
        Dim pedido = New Pedido(1, 0, DateTime.Now, 10D)

        ' Act
        Dim errors = _validator.Validate(pedido)

        ' Assert
        Assert.Contains("ClienteId deve ser maior que zero.", errors)
    End Sub

    <Test>
    Public Sub Validate_DataIsMinValue_ReturnsError()
        ' Arrange
        Dim pedido = New Pedido(1, 1, DateTime.MinValue, 10D)

        ' Act
        Dim errors = _validator.Validate(pedido)

        ' Assert
        Assert.Contains("Data do pedido é inválida.", errors)
    End Sub

    <Test>
    Public Sub Validate_ValorTotalNegative_ReturnsError()
        ' Arrange
        Dim pedido = New Pedido(1, 1, DateTime.Now, -5D)

        ' Act
        Dim errors = _validator.Validate(pedido)

        ' Assert
        Assert.Contains("ValorTotal não pode ser negativo.", errors)
    End Sub

    <Test>
    Public Sub Validate_AllFieldsValid_ReturnsNoErrors()
        ' Arrange
        Dim pedido = New Pedido(1, 2, DateTime.Now, 100D)

        ' Act
        Dim errors = _validator.Validate(pedido)

        ' Assert
        Assert.IsEmpty(errors)
    End Sub

    <Test>
    Public Sub Validate_MultipleInvalidFields_ReturnsAllErrors()
        ' Arrange
        Dim pedido = New Pedido(0, 0, DateTime.MinValue, -1D)

        ' Act
        Dim errors = _validator.Validate(pedido)

        ' Assert
        Assert.That(errors, Has.Member("Id deve ser maior que zero."))
        Assert.That(errors, Has.Member("ClienteId deve ser maior que zero."))
        Assert.That(errors, Has.Member("Data do pedido é inválida."))
        Assert.That(errors, Has.Member("ValorTotal não pode ser negativo."))
        Assert.AreEqual(4, errors.Count)
    End Sub

End Class
