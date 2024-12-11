WAIA, the Windows AI Assistant

A voice-controlled AI Assistant for Microsoft Windows

Update v2.4: Speech recognition does now detect longer sentences. Groq quota draining has been prevented. Chat history addet. It is now possible to do real conversations.

The Groq speech detection is now independent of Background noise without speech. The Azure speech recognition is still prone to quota draining.

Features:

Seamlessly integrates with ChatGPT and Groq
Advanced voice recognition powered by Azure speech services or Groq
Voice controlled interaction with Windows
Plugin system
Program starter using key sentences
Webhooks using key sentences for integration with IFTTT (home automation etc.) - https://ifttt.com/ 
  (untested)

  
  

Download:
https://github.com/decipher2k/Windows-AI-Assistant/releases
Usage

After starting the application, a tray icon is being added. Doubleclick on it to configure the settings.
Setup the API keys and other informations using the "Settings" buttons.

A green point on the tray icon means that speech has been recorded.
A blue point means that the recorded text has been sent to the Chat AI.

                                                                 
How to allways show a tray icon:
https://www.lifewire.com/show-or-hide-icons-in-system-tray-in-windows-10-5115219 
Chat History:
The chat history contains the last 3 messages. Thus you can really chat with the AI.
The Awan implementation does not support a chat history.
Keyword:
You can set a custom keyword for starting speech recognition. Default is "Computer".
Thus you can say "Computer, who was John F. Kennedy" to get informations about John F. Kennedy.

<s>Keyword Detection:
There is now a keyword detection using Windows Speech Recognition.
It can be good to use it in a noisy environment, like when watching TV or listening to music, to prevent speech recognition quota draining.
Keyword detection sets the keyword to "Computer", which can't be changed. Reliability differes between systems.
Recognition quality can be enhaced by training:
https://www.tenforums.com/tutorials/120674-add-delete-change-speech-recognition-profiles-windows-10-a.html
To access the control panel in Windows 11, hit the "Windows" key and enter "control panel".</s>

Windows Sound Recording Level:
If the voice recognition is active too often without you saying anything, or no speech is being detected, you can try to adjust the microphone recording level in the Windows settings.


Suggested Services:
I had good experiences with the following setup.
All suggested services are available for free.

Voice recognition: Groq. Azure tends to drain the quota when there is background noise.
Chat AI: Groq ist the fastest one.
Voice Output: Windows Speech until Google Cloud AI has been implemented.

Program Starter
The program starter can be configured using the "Commands" button.

The first column defines whether to use speech recognition or the chat AI to start the plugin.
Speech recognition will listen for the exact sentence.
Using the Chat AI allows you to vary sentences. The program does automatically precede the sentence with "if the user asks for". Thus, the sentence "starting windows explorer" will allow you to say either "start windows explorer", or "run windows explorer" etc.
Chat AI commands have not been implemented yet.
The third column is the program file that should be started.
The fourth column allows you to set command parameters.

Webhooks
Webhooks can be configured using the "Commands" button.
They can be used to raise events in webapplications, for example IFTTT. IFTTT can be used to control home automation systems etc.

The first column defines whether to use speech recognition or the chat AI to execute the webhook.
Speech recognition will listen for the exact sentence.
Using the Chat AI allows you to vary sentences. The program does automatically precede the sentence with "if the user asks for". Thus, the sentence "turning on the light" will allow you to say either "turn on the light", or "switch on the light" etc.
Chat AI commands have not been implemented yet.
The second column defines the sentence that the program uses to recognize the command.
The third column is the URL of the webhook.
The fourth column defines whether to use HTTP POST or HTTP GET. For most webhooks, this will be HTTP GET.
The fifth colummn defines parameters to the webhook.
In case of GET messages, these parameters will be appended to the URL, for example "?light=on" will lead to "https://example.com/webhook?light=on".
In case of POST messages, these parameters will define the data that is being sent with the POST request, for example JSON data.

Plugins
Plugins can be configured using the "Commands" button.

The media player plugin is included in the release of the program.
The first column defines whether to use speech recognition or the chat AI to start the plugin.
Speech recognition will listen for the exact sentence.
Using the Chat AI allows you to vary sentences. The program does automatically precede the sentence with "if the user asks for". Thus, the sentence "playing media" will allow you to say either "play media", or "play the song" etc.
Chat AI commands have not been implemented yet.
The second column defines the sentence that the program uses to recognize the command.
The third column defines the name of the plugin DLL.
The following columns are there to parametrize the plugin. They do differ from plugin to plugin. Please read the plugin's manual for more information.
Only use Plugins from trusted sources

The [TEXT] variable
Whenever you enter the token [TEXT] in a parameter of the commands section, the token will be replaced with the text that has been said after the command.
For example "Create a note: Shopping" using the key sentence "Create a note: [TEXT]" will pass the word "Shopping" instead of the [TEXT] token to a plugin, a webhook, or a program.
This will only work with Speech Recognition commands, not with Chat AI ones.

Speech recognition
Microsoft Azure speech recognition:
Go to Microsoft Azure https://azure.microsoft.com/en-us/ and sign up for free with a Microsoft account, you may need to add a credit card to activate the account
Go to Create Speech Services https://portal.azure.com/#create/Microsoft.CognitiveServicesSpeechServices to create a new speech service, create a new resource group, such as cognitive-services, select a region, give the service a unique name, select the free pricing tier, and click on Review + create to validate the provided details, then click on Create and wait for the service to be created
Go to Cognitive Services https://portal.azure.com/#view/Microsoft_Azure_ProjectOxford/CognitiveServicesHub/~/SpeechServices and click on the newly created service
Go to Resource Management > Keys and Endpoint and click on Show Keys
Copy the first displayed API key

Thankfully copied from https://github.com/dessant/buster/wiki/Configuring-Microsoft-Azure-Speech-to-Text 

Groq Speech Recognition:
Groq can be found at https://groq.com
The API keys can be created at https://console.groq.com/keys 

AI Chat
ChatGPT:
https://medium.com/latinxinai/how-to-get-api-key-for-chat-gpt-3-5-or-4-0-fce40b35aa00 
You will need ChatGPT API credits, not ChatGPT Plus!

Groq LLM API:
Groq can be found at https://groq.com 
The API keys can be created at https://console.groq.com/keys 

Ollama:
(https://ollama.com/)
Ollama is a locally hosted Chat AI. Good hardware (Geforce RTX) is required.
Low quality models (3B etc.) will require 4GB VRAM.
Average models (7B/8B) will require about 12GB VRAM.
Good models (70B) will require 24GB VRAM and more.
Set the model name and a system prompt in the settings window.
The model will be automatically downloaded if it does not exist yet.
You can find models at https://ollama.com/search 
Awan:
(https://www.awanllm.com)
Awan is a free API for LLAMA models.


Speech Synthesis
Elevenlabs:
Log in to your Elevenlabs account.
In the top-right corner, click on your profile icon > Profile.
Next to the API Key field, click the eye icon to view and copy your API key and store it in a safe place.
Please note: The "voice" field referes to the name of the voice, not to its ID.
Windows Speech Synthesis:
Average Quality.
You may need to set a voice according to your language in the settings.

Costs

Speech Recognition - one of the following:
-Microsoft Azure (5h/month are free)
-Groq (free, usage limits, fast)

AI Chat - one of the following:
-ChatGPT (about 10$/month)
-Groq LLM API (free, usage limits, fast) 
-Ollama (free, requires good hardware, slow)
-Awan (free, usage limits, slow)

Speech output - one of the following:
-Microsoft Windows Speech (free, average quality)
-Elevenlabs (about 10$-20$/month, good quality)

Please note that prices are dependent on real usage and may vary.
Writing a plugin
To write a plugin, add "WAIA Plugin.dll" to a new Visual Studio 2022 DotNet 8.0 class library project, implement the interface IWAIAPlugin and the following method:      
public String RunPlugin(String text);
The parameter "text" is the spoken input.
The return value of the function will be sent to the speech synthesis engine.

Troubleshooting
If the speech doesn't get detected, try the following:
-Adjust the microphone level of Windows
-Enable online speech recognition in Windows settings
-Speak slow and clearly
-Speak faster
-Use shorter sentences


