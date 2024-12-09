
<h1>Windows AI Assistant</h1><br>
<br>
<b>A voice-controlled AI Assistant for Microsoft Windows</b><br><br>
<a href="https://www.kickstarter.com/projects/r0ulaboard/windows-ai-assistant">Support WAIA on Kickstarter</a>
<h2>Features:</h2><br>
-Seamlessly integrates with ChatGPT, Groq, Ollama and Awan.<br>
-Advanced voice recognition powered by Azure speech services<br>
-Voice controlled interaction with Windows:<br>
--Plugin system<br>
--Program starter using key sentences<br>
--Webhooks using key sentences for integration with IFTTT (home automation etc.) - https://ifttt.com/ <br>
  (untested)
<br><br>
<h2>Download:</h2><br>
https://github.com/decipher2k/Windows-AI-Assistant/releases<br><br>
<h1>Usage:</h1><br>
<br>
After starting the application, a tray icon is being added. Doubleclick on it to configure the settings.<br>
Setup the API keys and other information using the "Settings" buttons.<br>
<br>
A green point on the tray icon means that speech is being recorded.<br>
A blue point means that the recorded text has been sent to the Chat AI.<br>
<br>
                                                                 
How to allways show a tray icon:<br>
https://www.lifewire.com/show-or-hide-icons-in-system-tray-in-windows-10-5115219 <br>
<br>
How to remove the microphone tray icon:<br>
https://github.com/valinet/ExplorerPatcher<br>
<h3>Keyword:</h3><br>
You can set a custom keyword for starting speech recognition. Default is "Computer".<br>
Thus you can say "Computer, who was John F. Kennedy" to get informations about John F. Kennedy.<br>
<br>
<h3>Keyword Detection:</h3><br>
There is now a keyword detection using Windows Speech Recognition.<br>
It can be good to use it in a noisy environment, like when watching TV or listening to music to prevent speech recognition quota draining.<br>
Keyword detection sets the keyword to "Computer", which can't be changed. Reliability differes between systems.<br><br>
Recognition quality can be enhaced by training:<br>
https://www.tenforums.com/tutorials/120674-add-delete-change-speech-recognition-profiles-windows-10-a.html<br>
To access the control panel in Windows 11, hit the "Windows" key and enter "control panel".<br>
<br>
<h3>Windows Sound Recording Level:</h3>
If the voice recognition is active too often without you saying anything, you can try to adjust the microphone recording level in the Windows settings, or use the keyword detection to prevent draining of the cloud voice recognition quota.
<br>
<br>
<h3>Suggested Services:</h3>
I had good experiences with the following setup:<br><br>
Voice recognition: Windows Azure. Make sure to adjust the microphone recording level to prevent quota draining.<br>
Chat AI: Groq ist the fastest one.<br>
Voice Output: Windows Speech until Google Cloud AI has been implemented.<br>
<br>
<h2>Program Starter</h2>
The program starter can be configured using the "Commands" button.<br>
This is an example for starting Windows explorer:<br><br>

<img src="https://github.com/user-attachments/assets/5fa40e98-4d8e-4d8c-8895-702e6cc632db" width="600">
<br><br>
The first column defines whether to use speech recognition and keywords or the chat AI to start the plugin.<br>
Speech recognition will listen for the exact sentence.<br>
Using the Chat AI allows you to vary sentences. The program does automatically precede the sentence with "if the user asks for". Thus, the sentence "starting windows explorer" will allow you to say either "start windows explorer", or "run windows explorer" etc.<br>
<b>Chat AI commands are not implemented yet.</b><br>
The third column is the program file that should be started.<br>
The fourth column allows you to set command parameters.<br><br>

<h2>Webhooks</h2>
Webhooks can be configured using the "Commands" button.<br>
They can be used to raise events in webapplications, for example IFTTT. IFTTT can be used to control home automation systems etc.<br>
This is an example for a webhook that turns on the light:<br><br>
<img src="https://github.com/user-attachments/assets/28477f74-f1b1-41c2-8cb7-8b27ba639c13" width="600"></img>
<br><br>
The first column defines whether to use speech recognition and keywords or the chat AI to execute the webhook.<br>
Speech recognition will listen for the exact sentence.<br>
Using the Chat AI allows you to vary sentences. The program does automatically precede the sentence with "if the user asks for". Thus, the sentence "turning on the light" will allow you to say either "turn on the light", or "switch on the light" etc.<br>
<b>Chat AI commands are not implemented yet.</b><br>
The second column defines the sentence that the program uses to recognize the command.<br>
The third column is the URL of the webhook.<br>
The fourth column defines whether to use HTTP POST or HTTP GET. For most webhooks, this will be HTTP GET.<br>
The fifth colummn defines parameters to the webhook.<br>
In case of GET messages, these parameters will be appended to the URL, for example "?light=on" will lead to "https://example.com/webhook?light=on".<br>
In case of POST messages, these parameters will define the data that is being sent with the POST request, for example JSON data.<br><br>

<h2>Plugins</h2>
Plugins can be configured using the "Commands" button.<br>
This is an example for the media player plugin:<br>
<br><br>
<img src="https://github.com/user-attachments/assets/ad6ddca7-6669-4751-a30c-5d5bf54b233e" width="600"></img>
<br><br>
The media player plugin is included in the release of the program.<br><br>
The first column defines whether to use speech recognition and keywords or the chat AI to start the plugin.<br>
Speech recognition will listen for the exact sentence.<br>
Using the Chat AI allows you to vary sentences. The program does automatically precede the sentence with "if the user asks for". Thus, the sentence "playing media" will allow you to say either "play media", or "play the song" etc.<br>
<b>Chat AI commands are not implemented yet.</b><br>
The second column defines the sentence that the program uses to recognize the command.<br>
The third column defines the name of the plugin DLL.<br>
The following columns are there to parametrize the plugin. They do differ from plugin to plugin. Please read the plugin's manual for more information.<br>
<b>Only use Plugins from trusted sources</b>
<br><br>
<h2>The [TEXT] variable</h2>
Whenever you enter the token [TEXT] in a parameter of the commands section, the token will be replace with the text that has been said after the command.<br>
For example "Create a note: Shopping" using the key sentence "Create a note: [TEXT]" will pass the word "Shopping" instead of the [TEXT] token to a plugin, a webhook, or a program.<br>
This will only work with Speech Recognition commands, not with Chat AI ones.<br>

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
<h3>Groq Speech Recognition:</h3>
Groq can be found at https://groq.com<br>
The API keys can be created at https://console.groq.com/keys <br>
<br>
<h1>AI Chat</h1>
<h3>ChatGPT:</h3><br>
https://medium.com/latinxinai/how-to-get-api-key-for-chat-gpt-3-5-or-4-0-fce40b35aa00 <br>
<b>You will need ChatGPT API credits, not ChatGPT Plus!</b><br>
<br>
<h3>Groq LLM API:</h3>
Groq can be found at https://groq.com <br>
The API keys can be created at https://console.groq.com/keys <br>
<br><br>
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
<h3>Windows Speech Synthesis</h3>
Average Quality.<br>
You may need to set a voice according to your language in the settings.
<br>
<h1>Costs</h1><br>
<br>
<h3>Speech Recognition - one of the following:</h3><br>
-Microsoft Azure (5h/month are free)<br>
-Groq (free, usage limits, fast)<br>
<br>
<h3>AI Chat - one of the following:</h3><br>
-ChatGPT (about 10$/month)<br>
-Groq LLM API (free, usage limits, fast) <br>
-Ollama (free, requires good hardware, slow)<br>
-Awan(free, usage limits, slow)<br>
<br>
<h3>Speech output - one of the following:</h3><br>
-Microsoft Windows Speech (free, average quality)<br>
-Elevenlabs (about 10$-20$/month, good quality)<br>
<br>
Please note that prices are dependent on real usage and may vary.<br><br>
<h2>Writing a plugin</h2><br>
To write a plugin, add "WAIA Plugin.dll" to a new Visual Studio 2022 DotNet 8.0 class library project, implement the interface IWAIAPlugin and the following method:<br><br>      
public String RunPlugin(String text);<br><br>
The parameter "text" is the spoken input.<br><br>
The return value of the Functions will be sent to the speech synthesis engine.



