# Gerar estrutura básica

-> `dotnet new webapi`

# Rodar a aplicação (vscode) terminal 

-> `dotnet watch run`

# Url - Postman

-> `http://localhost:port/controllerNome`

# Url - Swagger

-> `https://localhost:port/controllerNome`


# Curiosidades

-> O `IActionResult` tipo de retorno é apropriado quando vários ActionResult tipos de retorno são possíveis em uma ação. Os tipos ActionResult representam vários códigos de status HTTP. Qualquer classe não abstrata derivada de ActionResult qualifica como um tipo de retorno válido.