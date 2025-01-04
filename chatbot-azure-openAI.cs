using Azure;
using OpenAI.Chat;
using Microsoft.Data.SqlClient;
using Azure.AI.OpenAI;

string key = "AZURE_OPENAI_ENDPOINT";
string endpoint = "AZURE_OPENAI_KEY";
string model = "AZURE_OPENAI_MODEL_NAME";

// Add the client info
// Initialize the Azure OpenAI client with key-based authentication  
AzureOpenAIClient azureClient = new(
    new Uri(endpoint),
    new AzureKeyCredential(key));

// Assign the model to the client
ChatClient chatClient = azureClient.GetChatClient(model);

// Prepare the request for chat generation
ChatCompletionOptions completionOptions = new()
{
    Temperature = (float)0.7,
};

// SystemChatMessage and userChatMessage
string systemChatMsg = "YOUR_SYSTEM_MESSAGE";
string userChatMsg = "Necesito un modelo entidad relación";

// Chat List Messages
List<ChatMessage> messages = [
    new SystemChatMessage(systemChatMsg),
    new UserChatMessage(userChatMsg),

    ];

ChatCompletion completion = chatClient.CompleteChat(messages, completionOptions);

// Print the response 
Console.WriteLine($"{completion.Role}: {completion.Content[0].Text}");

