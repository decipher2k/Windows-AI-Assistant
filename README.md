
<h1>Windows AI Assistant</h1><br>
<br>
<b>A voice-controlled AI Assistant for Microsoft Windows</b><br><br>
<h2>Features:</h2><br>
-Seamlessly integrates with Ollama, ChatGPT and Awan.<br>
-Advanced voice recognition powered by Azure speech services<br>
-Plugin System<br>
-Hands-free interaction with Windows:<br>
--Program starter using key sentences<br>
--Webhooks using key sentences for integration with IFTTT (home automation etc.) - https://ifttt.com/ <br>
  (untested)
<br><br>

<h2>Download:</h2><br>
https://github.com/decipher2k/Windows-AI-Assistant/releases/download/v0.5/Windows.AI.Assistant.zip<br><br>
<h2>Usage:</h2><br>
<br>
After starting the application, a tray icon is being added. Doubleclick on it to configure the settings.<br>
Setup the API keys and other information using the "Settings" buttons.<br>
<br>
<h3>Keyword:</h3><br>
You can set a custom keyword for starting speech recognition. Default is "Computer".<br>
Thus you can say "Computer, who was John F. Kennedy" to get informations about John F. Kennedy.<br>
<br>
<h2>Plugins</h2>
Plugins can be configured using the "Commands" button.
This is an example for the media player plugin:
<br><br>
<img src="https://github.com/user-attachments/assets/ad6ddca7-6669-4751-a30c-5d5bf54b233e" width="600"></img>
<br><br>
The media player plugin is included in the release of the program.<br><br>
The first column defines whether to use speech recognition and keywords or the chat AI to start the plugin.<br>
Speech recognition will listen for the exact sentence.<br>
Using the Chat AI allows you to vary sentences. The program does automatically precede the sentence with "if the user asks for". Thus, the sentence "playing media" will allow you to say either "play media", or "play the song" etc.<br>
The second column defines the sentence that the program uses to recognize the command.<br>
The third column defines the name of the plugin DLL.<br>
The following columns are there to parametrize the plugin. They do differ from plugin to plugin. Please read the plugin's manual for more information.<br><br>

<h1>Speech recognition</h1>
<h3>Microsoft Azure speech recognition:</h3><br>
Go to Microsoft Azure https://azure.microsoft.com/en-us/ and sign up for free with a Microsoft account, you may need to add a credit card to activate the account<br>
Go to Create Speech Services https://portal.azure.com/#create/Microsoft.CognitiveServicesSpeechServices to create a new speech service, create a new resource group, such as cognitive-services, select a region, give the service a unique name, select the free pricing tier, and click on Review + create to validate the provided details, then click on Create and wait for the service to be created<br>
Go to Cognitive Services https://portal.azure.com/#view/Microsoft_Azure_ProjectOxford/CognitiveServicesHub/~/SpeechServices and click on the newly created service<br>
Go to Resource Management > Keys and Endpoint and click on Show Keys<br>
Copy the first displayed API key<br>
<br>
Thankfully copied from https://github.com/dessant/buster/wiki/Configuring-Microsoft-Azure-Speech-to-Text <br>
<br>
<h1>AI Chat</h1>
<h3>ChatGPT:</h3><br>
https://medium.com/latinxinai/how-to-get-api-key-for-chat-gpt-3-5-or-4-0-fce40b35aa00 <br>
<b>You will need ChatGPT API credits, not ChatGPT Plus!</b><br>
<br>
<h3>Ollama:</h3><br>
(https://ollama.com/)<br>
Ollama is a locally hosted Chat AI. Good hardware (Geforce RTX) is required.<br>
Low quality models (3B etc.) will require 4GB VRAM.<br>
Average models (7B/8B) will require about 12GB VRAM.<br>
Good models (70B) will require 24GB VRAM and more.<br><br>
Set the model name and a system prompt in the settings window.<br>
The model will be automatically downloaded if it does not exist yet.<br>
You can find models at https://ollama.com/search <br><br>
<h3>Awan:</h3><br>
(https://www.awanllm.com)<br>
Awan is a free API for LLAMA models.
<br>
<br>
<h1>Speech synthesis</h1>
<h3>Elevenlabs:</h3><br>
Log in to your ElevenLabs account.<br>
In the top-right corner, click on your profile icon > Profile.<br>
Next to the API Key field, click the eye icon to view and copy your API key and store it in a safe place.<br>
Please note: The "voice" field referes to the name of the voice, not to its ID.<br>
<br>
<h1>Costs</h1><br>
<br>
<h3>Speech Recognition:</h3><br>
-Microsoft Azure (5h/month are free)<br>
<br>
<h3>AI Chat - one of the following:</h3><br>
-Ollama (free, requires good hardware, slow)<br>
-Awan (free, slow)<br>
-ChatGPT API (about 10$/month)<br>
<br>
<h3>Speech output - one of the following:</h3><br>
-Microsoft Windows Speech (free, average quality)<br>
-Elevenlabs (about 10$/month, good quality)<br>
<br>
Please note that prices are dependent on real usage and may vary.<br><br>
<h2>Writing a plugin</h2><br>
To write a plugin, add "WAIA Plugin.dll" to a new Visual Studio 2022 DotNet 8.0 class library project, derive a class from the interface IWAIAPlugin and implement the following method:<br>         
public String RunPlugin(String text);<br><br>
String text is the spoken input.<br><br>
The return value of the function will be sent to the speech synthesis engine.



