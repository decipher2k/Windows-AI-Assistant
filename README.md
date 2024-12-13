
<h1>WAIA, the Windows AI Assistant</h1><br>
<br>
<b>A voice-controlled AI Assistant for Microsoft Windows</b><br>
<br>
<b>Speech recognition does now detect longer sentences. Groq quota draining has been prevented. Chat history addet. It is now possible to do real conversations.</b><br>
<br>
<b>The Groq speech detection is now independent of background noise without speech. The Azure speech recognition has been didsabled.</b><br><br>
<b>Please note that WAIA is just a client that unifies different AI services. The program itself does not provide any AI capabilities.</b><br>
<b>Windows control is done using Plugins. So you will need plugins for it.</b><br><br>
<b>Only use Plugins from this GitHub repository. Otherwise, they may containt malware.</b><br>
The URL of the repository is https://github.com/decipher2k/Windows-AI-Assistant.<br><br>
<h2>Features:</h2><br>
<ul>
<li>Seamlessly integrates with ChatGPT and Groq</li>
<li>Advanced voice recognition powered by Groq</li>
<li>Voice controlled interaction with Windows</li>
<ul><li>Plugin system</li>
<li>Program starter using key sentences</li>
<li>Webhooks using key sentences for integration with IFTTT (home automation etc.) - https://ifttt.com/ <br>
  (untested)</li>
</ul>
  </li>
  </ul>
<br><br>
<h2>Download:</h2>
https://github.com/decipher2k/Windows-AI-Assistant/releases<br><br>
<h1>Usage</h1>
<br>
After starting the application, a tray icon is being added. Doubleclick on it to configure the settings.<br>
Setup the API keys and other informations using the "Settings" buttons.<br>
<br>
A green point on the tray icon means that speech has been recorded.<br>
A blue point means that the recorded text has been sent to the Chat AI.
<br>
                                                                 
How to allways show a tray icon:<br>
https://www.lifewire.com/show-or-hide-icons-in-system-tray-in-windows-10-5115219 <br>
<h3>Chat History:</h3>
The chat history contains the last 3 messages. Thus you can really chat with the AI.<br>
<h3>Keyword:</h3>
You can set a custom keyword for starting speech recognition. Default is "Computer".<br>
Thus you can say "Computer, who was John F. Kennedy" to get informations about John F. Kennedy.<br>
<br>
<s><h3>Keyword Detection:</h3>
There is now a keyword detection using Windows Speech Recognition.<br>
It can be good to use it in a noisy environment, like when watching TV or listening to music, to prevent speech recognition quota draining.<br>
Keyword detection sets the keyword to "Computer", which can't be changed. Reliability differes between systems.<br><br>
Recognition quality can be enhaced by training:<br>
https://www.tenforums.com/tutorials/120674-add-delete-change-speech-recognition-profiles-windows-10-a.html<br>
To access the control panel in Windows 11, hit the "Windows" key and enter "control panel".<br></s>
<br>
<h3>Windows Sound Recording Level:</h3>
If the voice recognition is active too often without you saying anything, or no speech is being detected, you can try to adjust the microphone recording level in the Windows settings.
<br>
<br>
<h3>Suggested Services:</h3>
I had good experiences with the following setup.<br>
All suggested services are available for free.<br>
<br>
Voice recognition: Groq.<br>
Chat AI: Groq ist the fastest one.<br>
Voice Output: Windows Speech until Google Cloud AI has been implemented.<br>
<br>
<h2>Program Starter</h2>
The program starter can be configured using the "Commands" button.
<br><br>
The first column defines whether to use speech recognition or the chat AI to start the plugin.<br>
Speech recognition will listen for the exact sentence.<br>
Using the Chat AI allows you to vary sentences. The program does automatically precede the sentence with "if the user asks for". Thus, the sentence "starting windows explorer" will allow you to say either "start windows explorer", or "run windows explorer" etc.<br>
<b>Chat AI commands have not been implemented yet.</b><br>
The third column is the program file that should be started.<br>
The fourth column allows you to set command parameters.<br><br>

<h2>Webhooks</h2>
Webhooks can be configured using the "Commands" button.<br>
They can be used to raise events in webapplications, for example IFTTT. IFTTT can be used to control home automation systems etc.<br>

<br><br>
The first column defines whether to use speech recognition or the chat AI to execute the webhook.<br>
Speech recognition will listen for the exact sentence.<br>
Using the Chat AI allows you to vary sentences. The program does automatically precede the sentence with "if the user asks for". Thus, the sentence "turning on the light" will allow you to say either "turn on the light", or "switch on the light" etc.<br>
<b>Chat AI commands have not been implemented yet.</b><br>
The second column defines the sentence that the program uses to recognize the command.<br>
The third column is the URL of the webhook.<br>
The fourth column defines whether to use HTTP POST or HTTP GET. For most webhooks, this will be HTTP GET.<br>
The fifth colummn defines parameters to the webhook.<br>
In case of GET messages, these parameters will be appended to the URL, for example "?light=on" will lead to "https://example.com/webhook?light=on".<br>
In case of POST messages, these parameters will define the data that is being sent with the POST request, for example JSON data.<br><br>

<h2>Plugins</h2>
Plugins can be configured using the "Commands" button.
<br><br>
The media player plugin is included in the release of the program.<br><br>
The first column defines whether to use speech recognition or the chat AI to start the plugin.<br>
Speech recognition will listen for the exact sentence.<br>
Using the Chat AI allows you to vary sentences. The program does automatically precede the sentence with "if the user asks for". Thus, the sentence "playing media" will allow you to say either "play media", or "play the song" etc.<br>
<b>Chat AI commands have not been implemented yet.</b><br>
The second column defines the sentence that the program uses to recognize the command.<br>
The third column defines the name of the plugin DLL.<br>
The following columns are there to parametrize the plugin. They do differ from plugin to plugin. Please read the plugin's manual for more information.<br>
<b>Only use Plugins from this GitHub repository. Otherwise, they may containt malware.</b>
<br><br>
<h2>The [TEXT] variable</h2>
Whenever you enter the token [TEXT] in a parameter of the commands section, the token will be replaced with the text that has been said after the command.<br>
For example "Create a note: Shopping" using the key sentence "Create a note: [TEXT]" will pass the word "Shopping" instead of the [TEXT] token to a plugin, a webhook, or a program.<br>
This will only work with Speech Recognition commands, not with Chat AI ones.<br>

<h1>Speech recognition</h1>
<h3>Groq Speech Recognition:</h3>
Groq can be found at https://groq.com<br>
The API keys can be created at https://console.groq.com/keys <br>
<br>
<h1>AI Chat</h1>
<h3>ChatGPT:</h3>
https://medium.com/latinxinai/how-to-get-api-key-for-chat-gpt-3-5-or-4-0-fce40b35aa00 <br>
<b>You will need ChatGPT API credits, not ChatGPT Plus!</b><br>
<br>
<h3>Groq LLM API:</h3>
Groq can be found at https://groq.com <br>
The API keys can be created at https://console.groq.com/keys
<br>
<br>
<h1>Speech Synthesis</h1>
<h3>Elevenlabs:</h3>
Log in to your Elevenlabs account.<br>
In the top-right corner, click on your profile icon > Profile.<br>
Next to the API Key field, click the eye icon to view and copy your API key and store it in a safe place.<br>
Please note: The "voice" field referes to the name of the voice, not to its ID.<br>
<h3>Windows Speech Synthesis:</h3>
Average Quality.<br>
You may need to set a voice according to your language in the settings.
<br>
<h1>Costs</h1><br>
<br>
<h3>Speech Recognition - one of the following:</h3><br>
-Groq (available for free, usage limits, fast)<br>
<br>
<h3>AI Chat - one of the following:</h3><br>
-ChatGPT (about 10$/month)<br>
-Groq LLM API (available for free, usage limits, fast) <br>
<br>
<h3>Speech output - one of the following:</h3><br>
-Microsoft Windows Speech (free, average quality)<br>
-Elevenlabs (about 10$-20$/month, good quality)<br>
<br>
Please note that prices are dependent on actual usage and may vary.<br><br>
<h2>Writing a plugin</h2><br>
To write a plugin, add "WAIA Plugin.dll" to a new Visual Studio 2022 DotNet 8.0 class library project, implement the interface IWAIAPlugin and the following method:<br><br>      
public String RunPlugin(String text, String[] parameters);<br><br>
The parameter "String text" is the spoken input.<br>
The parameter "String[] parameters" allows you to pass parameters to the plugin.<br><br>
The return value of the function will be sent to the speech synthesis engine.<br>
If the third parameter of "String[] parameters" is "AI", the return value of the function will be sent to the Chat AI.<br>
<br>
<h1>Troubleshooting</h1>
If the speech doesn't get detected, try the following:<br>
-Adjust the microphone level of Windows<br>
-Enable online speech recognition in Windows settings<br>
-Speak slow and clearly<br>


