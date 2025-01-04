# Azure OpenAI

Azure OpenAI es un servicio de Microsoft Azure que permite a los desarrolladores integrar modelos avanzados de inteligencia artificial generativa, como **GPT** (*Generative Pre-trained Transformer*) de OpenAI, en sus aplicaciones. 

Estos modelos pueden realizar tareas como generación de texto, creación de contenido, comprensión de lenguaje natural, análisis de datos y mucho más.

Al estar integrado en Azure, el servicio ofrece escalabilidad, seguridad y cumplimiento normativo, aprovechando la infraestructura robusta de Microsoft.

## Modelos avanzados:

Incluye modelos de OpenAI como **GPT-4**, **GPT-3.5**, Codex (para generación de código) y DALL·E (para generación de imágenes).

## Chatbot

Un chatbot es un programa de software diseñado para simular conversaciones humanas utilizando el **procesamiento de lenguaje natural** (*NLP*) e inteligencia artificial (IA). 

# ChatBot con Azure OpenAI y C# (.NET)

## Crear el recurso de Azure OpenAI:

1. Inicia sesión en el portal de Azure.
2. Navega a Crear un recurso > Azure OpenAI.
3. Configura el recurso: selecciona suscripción, grupo de recursos, región y nombre del recurso.
Una vez creado, obtendrás el Key (clave) y el Endpoint (punto de conexión) necesarios.
4. Selecciona el modelo que mejor se ajuste al caso de uso (por ejemplo, GPT-4 para generación de texto avanzado).
5. Configura los parámetros para personalizar las respuestas del modelo, como el nivel de creatividad (Temperature) o la longitud de la respuesta (MaxToken).

## Configurar permisos:

1. Configura accesos a las funcionalidades del servicio Azure OpenAI en la sección **Access control** (IAM).
2. Gestiona las claves y configuraciones desde la sección de Claves y extremos del recurso creado.

## Configuración en el proyecto .NET

1. Crea un nuevo proyecto de C# Console en Visual Studio.
2. Copia y edita el código del archivo [ChatBot-AzureOpenAI](/)
3. Usa NuGet para instalar los paquetes requeridos:

```bash
dotnet add package Azure.AI.OpenAI
dotnet add package Microsoft.Data.SqlClient
```

4. Ahora puedes realizar cualquier consulta a tu chat escribiéndolo desde en la variable `userChatMsg`.
